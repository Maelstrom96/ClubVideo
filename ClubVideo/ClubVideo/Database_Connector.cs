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
        static public void AddUser(string username, string password)
        {
            Guid userGuid = System.Guid.NewGuid();
            string hashedPassword = Security.HashSHA1(password + userGuid.ToString());

            string insert = "INSERT INTO Users (ID, Username, Password, Guid) VALUES (UserID.NEXTVAL, :username, :password, :userguid)";

            OracleCommand cmd = new OracleCommand(insert, GetConnection());

            cmd.Parameters.Add(new OracleParameter("username", username));
            cmd.Parameters.Add(new OracleParameter("password", hashedPassword));
            cmd.Parameters.Add(new OracleParameter("userguid", userGuid.ToString()));

            cmd.ExecuteNonQuery();
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

                // EN
                movie.Nom_en = data["Title"];
                movie.Description_en = data["Plot"];
                movie.Rated = data["Rated"];
                movie.Runtime = data["Runtime"];
                movie.Year = data["Year"];
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
        }

        public static class Update
        {
            public static void UserPassword()
            {
                
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
