using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                throw new Exception(Main_Menu.resManager.GetString("Exception_DB_Already_Open", Main_Menu.culInfo));
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

            OracleCommand cmd = new OracleCommand(insert, conn_);

            cmd.Parameters.Add(new OracleParameter("username", username));
            cmd.Parameters.Add(new OracleParameter("password", hashedPassword));
            cmd.Parameters.Add(new OracleParameter("userguid", userGuid.ToString()));

            cmd.ExecuteNonQuery();
        }

        public static int GetUserIdByUsernameAndPassword(string username, string password)
        {
            int userId = 0;

            string select = "SELECT Id, Password, Guid FROM Users WHERE LOWER(username)=LOWER(:username)";

            OracleCommand cmd = new OracleCommand(select, conn_);

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
    }
}
