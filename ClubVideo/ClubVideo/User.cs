using ClubVideo.Properties;
using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubVideo
{
    public class User
    {
        private string Name;
        public string Username { get; private set; }
        private string LastName;
        private int UserID;

        public int ID
        {
            get { 
                return UserID;
            }
        }

        private bool LoggedIn;
        private Permissions Perms;

        public Permissions Permissions 
        {
            get 
            { 
                return Perms;
            }
        }

        public User()
        {

            // Members Initializations
            LoggedIn = false;
        }

        public bool Login(string username, string plainPassword)
        {
            if (LoggedIn) throw new Exception("User already logged-in.");

            Username = username;
            UserID = Database_Connector.GetUserIdByUsernameAndPassword(username, plainPassword);

            if (UserID > 0)
            {
                LoggedIn = true;

                LoadSettings();
                LoadPermissions();

                return true;
            }
            return false;
        }

        private void LoadSettings()
        {
            Settings.Default["Language"] = Database_Connector.Select.LanguageSetting();

            /* Fonction to load ALL SETTINGS */ 
            //OracleConnection conn_ = Database_Connector.GetConnection();
            //string select = "SELECT key, value FROM user_settings WHERE user_id=:userid";
            //OracleCommand cmd = new OracleCommand(select, conn_);
            //cmd.Parameters.Add(new OracleParameter("userid", Main.user.ID.ToString()));

            //OracleDataReader dr = cmd.ExecuteReader();

            //while (dr.Read())
            //{
            //    string key = Convert.ToString(dr["key"]);
            //    string value = Convert.ToString(dr["value"]);

            //    Settings.Default[key] = value;
            //}
            //conn_.Close();
        }

        private void LoadPermissions()
        {
            Perms = new Permissions(UserID);
        }
    }
}
