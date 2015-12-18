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
using System.Globalization;

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

                string date = data["Released"];

                // EN
                movie.Nom_en = data["Title"];
                movie.Description_en = data["Plot"];
                movie.Rated = data["Rated"];
                movie.Runtime = int.Parse(runtime);
                movie.Year = int.Parse(Year); // Released -> Release date.
                movie.Date = DateTime.ParseExact(date, "dd MMM yyyy", CultureInfo.InvariantCulture);
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

            /// <summary>
            /// 
            /// 
            /// Comment : If the user doesn't have the settings, insert them.
            /// </summary>
            /// <returns></returns>
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
                    // Insert default value here.
                    value = Settings.Default.Language;
                    //Insert.LanguageSetting(Settings.Default.Language);
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
            public static void UserPermissions(int userid, List<string> ParamsToDel)
            {
                string delete = "DELETE FROM user_permissions WHERE user_id=:userid AND LOWER(permission)=LOWER(:permission)";

                OracleCommand cmd = new OracleCommand(delete, GetConnection());

                foreach (string param in ParamsToDel)
                {
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add(new OracleParameter("userid", userid));
                    cmd.Parameters.Add(new OracleParameter("permission", param));

                    cmd.ExecuteNonQuery();
                }

                if (userid == Main.user.ID) Database.Update.Permissions();
            }

            public static void User(int id)
            {
                string delete = "DELETE FROM users where id=:userid";

                OracleCommand cmd = new OracleCommand(delete, GetConnection());

                cmd.Parameters.Add(new OracleParameter("userid", id));

                cmd.ExecuteNonQuery();

                Database.Update.Users();
            }

            public static void Member(int id)
            {
                string delete = "DELETE FROM members where id=:memberid";

                OracleCommand cmd = new OracleCommand(delete, GetConnection());

                cmd.Parameters.Add(new OracleParameter("memberid", id));

                cmd.ExecuteNonQuery();

                Database.Update.Members();
            }

            public static void Movie(int id)
            {
                string delete = "DELETE FROM movies where id=:movieid";

                OracleCommand cmd = new OracleCommand(delete, GetConnection());

                cmd.Parameters.Add(new OracleParameter("movieid", id));

                cmd.ExecuteNonQuery();

                Database.Update.Movies();
            }
            public static void Category(int id)
            {
                string delete = "DELETE FROM categories where id=:categoryid";

                OracleCommand cmd = new OracleCommand(delete, GetConnection());

                cmd.Parameters.Add(new OracleParameter("categoryid", id));

                cmd.ExecuteNonQuery();

                Database.Update.Categories();
            }
        }

        public static class Insert
        {
            public static void Category(CategoryObject obj)
            {
                string insert = "INSERT INTO categories VALUES (CATEGORYID.NEXTVAL, :name_en, :name_fr, :description_en, :description_fr, :price)";

                OracleCommand cmd = new OracleCommand(insert, GetConnection());

                cmd.Parameters.Add(new OracleParameter("name_en", obj.Name_En));
                cmd.Parameters.Add(new OracleParameter("name_fr", obj.Name_Fr));
                cmd.Parameters.Add(new OracleParameter("description_en", obj.Description_En));
                cmd.Parameters.Add(new OracleParameter("description_fr", obj.Description_Fr));
                cmd.Parameters.Add(new OracleParameter("price", obj.Price));

                cmd.ExecuteNonQuery();
                CloseConnection();
                Database.Update.Categories();
            }

            public static void UserPermissions(int userid, List<string> ParamsToAdd)
            {
                string insert = "INSERT INTO user_permissions VALUES (:userid, :permission)";

                OracleCommand cmd = new OracleCommand(insert, GetConnection());


                foreach (string param in ParamsToAdd)
                {
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add(new OracleParameter("userid", userid));
                    cmd.Parameters.Add(new OracleParameter("permission", param));

                    cmd.ExecuteNonQuery();
                }

                if (userid == Main.user.ID) Database.Update.Permissions();
            }

            public static void Member(MemberObject obj)
            {
                string insert = "INSERT INTO members VALUES (MEMBERID.NEXTVAL, :name, :last_name, :address, :postalcode, :city, :province, :telephonenumber)";

                OracleCommand cmd = new OracleCommand(insert, GetConnection());

                cmd.Parameters.Add(new OracleParameter("name", obj.Name));
                cmd.Parameters.Add(new OracleParameter("last_name", obj.LastName));
                cmd.Parameters.Add(new OracleParameter("address", obj.Address));
                cmd.Parameters.Add(new OracleParameter("postalcode", obj.PostalCode));
                cmd.Parameters.Add(new OracleParameter("city", obj.City));
                cmd.Parameters.Add(new OracleParameter("province", obj.Province));
                cmd.Parameters.Add(new OracleParameter("telephonenumber", obj.TelNumber));
                if (obj.Name == "" || obj.LastName == "" || obj.Address == "" || obj.PostalCode == "" || obj.City == "" || obj.Province == "" || obj.TelNumber == "")
                    throw new Exception("Les champs ne doivent pas etre vides");
                cmd.ExecuteNonQuery();
                CloseConnection();
                Database.Update.Members();
            }

            public static void Settings(string key, string value)
            {
                string insert = "INSERT INTO user_settings VALUES (:userid, :keyp, :valuep)";

                OracleCommand cmd = new OracleCommand(insert, GetConnection());

                cmd.Parameters.Add(new OracleParameter("userid", Main.user.ID.ToString()));
                cmd.Parameters.Add(new OracleParameter("keyp", key));
                cmd.Parameters.Add(new OracleParameter("valuep", value));

                cmd.ExecuteNonQuery();
            }

            public static void Copies(int movie)
            {
                string insert = "INSERT INTO movies_copies VALUES (COPIESID.NEXTVAL, :movieID, null)";

                OracleCommand cmd = new OracleCommand(insert, GetConnection());

                cmd.Parameters.Add(new OracleParameter("movieID", movie));
                cmd.ExecuteNonQuery();
            }
            public static void Movie(MovieObject movie)
            {
                string insert = "INSERT INTO movies VALUES (MOVIEID.NEXTVAL, :name_en, :name_fr, :desc_en, :desc_fr, :directors, :releasedate, :rating, :runtime, :image, :category, :deletedate)";

                OracleCommand cmd = new OracleCommand(insert, GetConnection());

                cmd.Parameters.Add(new OracleParameter("name_en", movie.Nom_en));
                cmd.Parameters.Add(new OracleParameter("name_fr", movie.Nom_fr));
                cmd.Parameters.Add(new OracleParameter("desc_en", movie.Description_en));
                cmd.Parameters.Add(new OracleParameter("desc_fr", movie.Description_fr));
                cmd.Parameters.Add(new OracleParameter("directors", movie.Director));
                cmd.Parameters.Add(new OracleParameter("releasedate", movie.Date));
                cmd.Parameters.Add(new OracleParameter("rating", movie.Rated));
                cmd.Parameters.Add(new OracleParameter("runtime", movie.Runtime));

                // Add Image
                OracleParameter image = new OracleParameter("image", OracleDbType.Blob);

                Image pb_Image = movie.Poster;
                MemoryStream memoryStream = new MemoryStream();
                pb_Image.Save(memoryStream, ImageFormat.Jpeg);
                byte[] imageBt = memoryStream.ToArray();

                image.Value = imageBt;

                cmd.Parameters.Add(image);
                cmd.Parameters.Add(new OracleParameter("category", movie.Category));
                cmd.Parameters.Add(new OracleParameter("deletedate", DBNull.Value));

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
                cmd.Parameters.Add(new OracleParameter("name", name));
                cmd.Parameters.Add(new OracleParameter("lastname", lastName));
                cmd.Parameters.Add(new OracleParameter("userid", id));

                cmd.ExecuteNonQuery();

                Database.Update.Users();
            }

            public static int Settings(string key, string value)
            {
                string update = "UPDATE user_settings SET value=:valuep WHERE user_id=:userid AND key=:keyp";

                OracleCommand cmd = new OracleCommand(update, GetConnection());

                cmd.Parameters.Add(new OracleParameter("valuep", value));
                cmd.Parameters.Add(new OracleParameter("userid", Main.user.ID.ToString()));
                cmd.Parameters.Add(new OracleParameter("keyp", key));

                return cmd.ExecuteNonQuery();
            }

            public static void Member(MemberObject obj)
            {
                string update = "UPDATE members SET name=:name, last_name=:last_name, address=:address, postalcode=:postalcode, city=:city, province=:province, telephonenumber=:telephonenumber WHERE id=:memberid";

                OracleCommand cmd = new OracleCommand(update, GetConnection());

                cmd.Parameters.Add(new OracleParameter("name", obj.Name));
                cmd.Parameters.Add(new OracleParameter("last_name", obj.LastName));
                cmd.Parameters.Add(new OracleParameter("address", obj.Address));
                cmd.Parameters.Add(new OracleParameter("postalcode", obj.PostalCode));
                cmd.Parameters.Add(new OracleParameter("city", obj.City));
                cmd.Parameters.Add(new OracleParameter("province", obj.Province));
                cmd.Parameters.Add(new OracleParameter("telephonenumber", obj.TelNumber));
                cmd.Parameters.Add(new OracleParameter("memberid", obj.ID));

                cmd.ExecuteNonQuery();

                Database.Update.Members();
            }

            public static void Movie(MovieObject obj)
            {
                string update = "UPDATE movies SET NAME_EN=:nameEN, NAME_FR=:nameFR, DESCRIPTION_EN=:descEN, DESCRIPTION_FR=:descFR, RELEASEDATE=:year, RATING=:rated, RUNTIME=:runtime WHERE ID=:movieID";
                OracleCommand cmd = new OracleCommand(update, GetConnection());
                
                cmd.Parameters.Add(new OracleParameter("nameEN", obj.Nom_en));
                cmd.Parameters.Add(new OracleParameter("nameFR", obj.Nom_fr));
                cmd.Parameters.Add(new OracleParameter("descEN", obj.Description_en));
                cmd.Parameters.Add(new OracleParameter("descFR", obj.Description_fr));
                cmd.Parameters.Add(new OracleParameter("year", obj.Year));
                cmd.Parameters.Add(new OracleParameter("rated", obj.Rated));
                cmd.Parameters.Add(new OracleParameter("runtime", obj.Runtime));
                cmd.Parameters.Add(new OracleParameter("movieID", obj.ID));

                cmd.ExecuteNonQuery();

                Database.Update.Movies();
            }

            public static void Category(CategoryObject obj)
            {
                string update = "UPDATE categories SET NAME_EN=:nameEN, NAME_FR=:nameFR, DESCRIPTION_EN=:descEN, DESCRIPTION_FR=:descFR, PRICE=:price WHERE ID=:categoryID";
                OracleCommand cmd = new OracleCommand(update, GetConnection());

                cmd.Parameters.Add(new OracleParameter("nameEN", obj.Name_En));
                cmd.Parameters.Add(new OracleParameter("nameFR", obj.Name_Fr));
                cmd.Parameters.Add(new OracleParameter("descEN", obj.Description_En));
                cmd.Parameters.Add(new OracleParameter("descFR", obj.Description_Fr));
                cmd.Parameters.Add(new OracleParameter("price", obj.Price));
                cmd.Parameters.Add(new OracleParameter("categoryID", obj.ID));

                cmd.ExecuteNonQuery();

                Database.Update.Categories();
            }
        }
    }
}
