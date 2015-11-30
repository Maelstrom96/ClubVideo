using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubVideo
{
    public static class Database
    {
        private static DataSet DS = new DataSet();

        private static string Movies_Select = "SELECT * FROM movies";
        private static string Permissions_Select = "SELECT * FROM permissions";

        public static DataSet DataSet
        {
            get
            {
                return DS;
            }
        }

        public static void ResetDataSet()
        {
            DS.Clear();
        }

        private static void GetDBData(string TableName, string SelectSQL)
        {
            OracleDataAdapter DataAdapter = new OracleDataAdapter(new OracleCommand(SelectSQL, Database_Connector.GetConnection()));
            DataAdapter.Fill(DS, TableName);
            Database_Connector.CloseConnection();
        }

        public static void FillDataSet()
        {
            //GetDBData("Movies", Movies_Select);
            GetDBData("Permissions", Permissions_Select);
        }

        public static class GetData
        {
            public static List<string> ListPermissions()
            {
                List<string> ListPermissions = new List<string>();

                foreach(DataRow dr in DS.Tables["Permissions"].Rows)
                {
                    ListPermissions.Add(dr["Permission"].ToString());
                }

                // SORT
                ListPermissions = ListPermissions.OrderBy(q => q).ToList();

                return ListPermissions;
            }
        }

        public static class Update
        {
            public static void All()
            {
                Movies();
                Permissions();
            }

            public static void Movies()
            {
                DS.Tables["Movies"].Clear();
                GetDBData("Movies", Movies_Select);
            }

            public static void Permissions()
            {
                DS.Tables["Permissions"].Clear();
                GetDBData("Permissions", Permissions_Select);
            }
        }
    }
}
