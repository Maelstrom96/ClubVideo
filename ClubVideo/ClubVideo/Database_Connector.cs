using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using System.Drawing;
using ClubVideo.Properties;
using System.IO;
using System.Drawing.Imaging;

namespace ClubVideo
{
    class Database_Connector
    {
        static private OracleConnection conn_ = new OracleConnection();
        static private string DataSource = "(DESCRIPTION="
            + "(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)" 
            + "(HOST=" + Properties.Settings.Default.DB_HostName 
            + ")(PORT=" + Properties.Settings.Default.DB_Port.ToString()
            + ")))(CONNECT_DATA=(SERVICE_NAME=" + Properties.Settings.Default.DB_ServiceName
            + ")))";

        static private string ConnectionString;

        static public void OpenConnection()
        {
            ConnectionString = "Data Source =" + DataSource
                + " ; User Id=" + Properties.Settings.Default.DB_Username
                + " ; Password=" + Properties.Settings.Default.DB_Password + ";";

            if (conn_.State == ConnectionState.Closed)
            {
                conn_.ConnectionString = ConnectionString;
                conn_.Open();
            }
            else
            {
                throw new Exception(Main.resManager.GetString("Exception_DB_Already_Open", Main.culInfo));
            }
        }

        static public OracleConnection GetConnection()
        {
            if (conn_.State != ConnectionState.Open) conn_.Open();
            return conn_;
        }

        static public void CloseConnection()
        {
            conn_.Close();
        }
        static public void AddUser(string username, string password, string name, string lastName)
        {
            if (Select.UsernameExist(0, username)) throw new Exception("USERNAME_ALREADY_EXIST");

            Guid userGuid = System.Guid.NewGuid();
            string hashedPassword = Security.HashSHA1(password + userGuid.ToString());

            string insert = "INSERT INTO Users (ID, Username, Password, Guid, Name, LastName) VALUES (UserID.NEXTVAL, :username, :password, :userguid, :name, :lastname)";

            OracleCommand cmd = new OracleCommand(insert, GetConnection());

            cmd.Parameters.Add(new OracleParameter("username", username));
            cmd.Parameters.Add(new OracleParameter("password", hashedPassword));
            cmd.Parameters.Add(new OracleParameter("userguid", userGuid.ToString()));
            cmd.Parameters.Add(new OracleParameter("name", name));
            cmd.Parameters.Add(new OracleParameter("lastname", lastName));

            cmd.ExecuteNonQuery();

            Database.Update.Users();
        }

        public static int GetUserIdByUsernameAndPassword(string username, string password)
        {
            int userId = 0;

            string select = "SELECT Id, Password, Guid FROM Users WHERE LOWER(username)=LOWER(:username)";

            OracleCommand cmd = new OracleCommand(select, GetConnection());

            cmd.Parameters.Add(new OracleParameter("username", username.ToLower()));

            OracleDataReader dr = cmd.ExecuteReader();

            while(dr.Read())
            {
                int dbUserId = Convert.ToInt32(dr["ID"]);
                string dbPassword = Convert.ToString(dr["Password"]);
                string dbUserGuid = Convert.ToString(dr["Guid"]);

                string hashedPassword = Security.HashSHA1(password + dbUserGuid);

                if (dbPassword == hashedPassword)
                {
                    userId = dbUserId;
                }
            }

            return userId;
        }

        public static MovieObject GetFromIMDB(string id)
        {
            string url = "http://www.omdbapi.com/?i=" + id + "&plot=full&r=json";
            string urlfr = "https://api.themoviedb.org/3/find/" + id + "?external_source=imdb_id&language=fr&api_key=51418c9e34d1e5629a84126ff72fe09a";
            string json;
            string jsonfr;
            MovieObject movie;

            using (WebClient wc = new WebClient())
            {
                wc.Encoding = System.Text.Encoding.UTF8;
                json = wc.DownloadString(url);
                jsonfr = wc.DownloadString(urlfr);
            }
            dynamic data = JObject.Parse(json);
            dynamic datafr = JObject.Parse(jsonfr);

            try
            {
                movie = new MovieObject();

                string runtime = data["Runtime"];
                runtime = new String(runtime.TakeWhile(Char.IsDigit).ToArray());
                if (runtime.Equals(string.Empty)) runtime = "0";

                string Year = data["Year"];
                Year = new String(Year.TakeWhile(Char.IsDigit).ToArray());
                if (Year.Equals(string.Empty)) Year = "0";

                // EN
                movie.Nom_en = data["Title"];
                movie.Description_en = data["Plot"];
                movie.Rated = data["Rated"];
                movie.Runtime = int.Parse(runtime);
                movie.Year = int.Parse(Year); // Released -> Release date.
                movie.Director = data["Director"];

                // FR
                movie.Description_fr = datafr["movie_results"][0]["overview"];
                movie.Nom_fr = datafr["movie_results"][0]["title"];

                string imgurl = data["Poster"];
                // Load Image
                var request = WebRequest.Create(imgurl);

                using (var response = request.GetResponse())
                using (var stream = response.GetResponseStream())
                {
                    movie.Poster = Bitmap.FromStream(stream);
                }
            }
            catch (Exception e)
            {
                movie = null;
            }

            return movie;
        }

        public static class Select
        {
            public static List<string> UserPermissions(int userid)
            {
                List<string> tempPerms = new List<string>();
                string select = "SELECT PERMISSION FROM USER_PERMISSIONS WHERE USER_ID=:userid";
                OracleCommand cmd = new OracleCommand(select, GetConnection());

                cmd.Parameters.Add(new OracleParameter("userid", userid));

                OracleDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    tempPerms.Add(dr["PERMISSION"].ToString());
                }

                CloseConnection();

                return tempPerms;
            }

            public static string LanguageSetting()
            {
                string value = null;

                OracleConnection conn_ = Database_Connector.GetConnection();
                string select = "SELECT value FROM user_settings WHERE user_id=:userid AND key=:keyp";
                OracleCommand cmd = new OracleCommand(select, conn_);
                cmd.Parameters.Add(new OracleParameter("userid", Main.user.ID.ToString()));
                cmd.Parameters.Add(new OracleParameter("keyp", "Language"));

                OracleDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    value = Convert.ToString(dr["value"]);
                }
                else 
                {
                    value = Settings.Default.Language;
                    Insert.LanguageSetting(Settings.Default.Language);
                }
                conn_.Close();

                return value;
            }

            public static bool UsernameExist(int id, string username)
            {
                string select = "SELECT id, username FROM users where LOWER(username)=LOWER(:username)";
                OracleCommand cmd = new OracleCommand(select, GetConnection());
                cmd.Parameters.Add(new OracleParameter("username", username));

                OracleDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    if (dr["id"].ToString() == id.ToString()) return false;
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public static string GUID(int id)
            {
                string select = "SELECT Guid FROM Users WHERE id=:id";
                OracleCommand cmd = new OracleCommand(select, GetConnection());

                cmd.Parameters.Add(new OracleParameter("id", id));

                OracleDataReader dr = cmd.ExecuteReader();

                if(dr.Read())
                {
                    return Convert.ToString(dr["guid"]);
                }
                else
                {
                    throw new Exception("ERROR_USERID_NOT_FOUND");
                }
            }
        }

        public static class Delete
        {
            public static void User(int id)
            {
                string insert = "DELETE FROM users where id=:userid";

                OracleCommand cmd = new OracleCommand(insert, GetConnection());

                cmd.Parameters.Add(new OracleParameter("userid", id));

                cmd.ExecuteNonQuery();

                Database.Update.Users();
            }
        }

        public static class Insert
        {
            public static void LanguageSetting(string Language)
            {
                string insert = "INSERT INTO user_settings VALUES (:userid, :keyp, :valuep)";

                OracleCommand cmd = new OracleCommand(insert, GetConnection());

                cmd.Parameters.Add(new OracleParameter("userid", Main.user.ID.ToString()));
                cmd.Parameters.Add(new OracleParameter("keyp", "Language"));
                cmd.Parameters.Add(new OracleParameter("valuep", Language));

                cmd.ExecuteNonQuery();

                Settings.Default.Language = Language;
            }

            public static void Movie(MovieObject movie)
            {
                string insert = "INSERT INTO movies VALUES (MOVIEID.NEXTVAL, :name_en, :name_fr, :desc_en, :desc_fr, :releasedate, :rating, :runtime, :image)";

                OracleCommand cmd = new OracleCommand(insert, GetConnection());

                cmd.Parameters.Add(new OracleParameter("name_en", movie.Nom_en));
                cmd.Parameters.Add(new OracleParameter("name_fr", movie.Nom_fr));
                cmd.Parameters.Add(new OracleParameter("desc_en", movie.Description_en));
                cmd.Parameters.Add(new OracleParameter("desc_fr", movie.Description_fr));
                cmd.Parameters.Add(new OracleParameter("releasedate", movie.Year));
                cmd.Parameters.Add(new OracleParameter("rating", movie.Rated));
                cmd.Parameters.Add(new OracleParameter("runtime", movie.Runtime));

                // Add Image
                OracleParameter image = new OracleParameter("image", OracleDbType.Blob);

                Image pb_Image = movie.Poster;
                MemoryStream memoryStream = new MemoryStream();
                pb_Image.Save(memoryStream, ImageFormat.Png);
                byte[] imageBt = memoryStream.ToArray();

                image.Value = imageBt;

                cmd.Parameters.Add(image);

                cmd.ExecuteNonQuery();
                CloseConnection();
                Database.Update.Movies();
            }
        }

        public static class Update
        {
            public static void UserPassword(int id, string password)
            {
                string hashedPassword = Security.HashSHA1(password + Select.GUID(id));

                string update = "UPDATE users SET password=:password WHERE id=:userid";

                OracleCommand cmd = new OracleCommand(update, GetConnection());

                cmd.Parameters.Add(new OracleParameter("password", hashedPassword));
                cmd.Parameters.Add(new OracleParameter("userid", id));

                cmd.ExecuteNonQuery();

                CloseConnection();
            }

            public static void User(int id, string username, string name, string lastName)
            {
                if (username.Equals(string.Empty)) throw new Exception("USERNAME_CANNOT_BE_NULL");
                if (Select.UsernameExist(id, username)) throw new Exception("USERNAME_EXIST");

                string update = "UPDATE users SET username=:username, name=:name, lastname=:lastname WHERE id=:userid";

                OracleCommand cmd = new OracleCommand(update, GetConnection());

                cmd.Parameters.Add(new OracleParameter("username", username));
                cmd.Parameters.Add(new OracleParameter("keyp", name));
                cmd.Parameters.Add(new OracleParameter("keyp", lastName));
                cmd.Parameters.Add(new OracleParameter("userid", id));

                cmd.ExecuteNonQuery();

                Database.Update.Users();
            }

            public static void LanguageSetting(string Language)
            {
                string update = "UPDATE user_settings SET value=:valuep WHERE user_id=:userid AND key=:keyp";

                OracleCommand cmd = new OracleCommand(update, GetConnection());

                cmd.Parameters.Add(new OracleParameter("valuep", Language));
                cmd.Parameters.Add(new OracleParameter("userid", Main.user.ID.ToString()));
                cmd.Parameters.Add(new OracleParameter("keyp", "Language"));

                cmd.ExecuteNonQuery();

                Settings.Default.Language = Language;
            }
        }
    }
}
