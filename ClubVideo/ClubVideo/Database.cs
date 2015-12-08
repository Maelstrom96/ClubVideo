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

        private static string Movies_Select = @"with NBCopy as
            (
              select movie_id, count(movie_id) as NBCOPIES
              from movies_copies
              group by movies_copies.movie_id
            )

            select
                Movies.id,
                Movies.name_en,
                Movies.name_fr,
                Movies.description_fr,
                Movies.description_en,
                Movies.releasedate,
                Movies.rating,
                Movies.runtime,
                Movies.image,
                coalesce(NBCopy.NBCOPIES, 0) as NBCOPIES
            from Movies left outer join NBCopy on NBCopy.Movie_ID = Movies.ID";

        private static string Permissions_Select = "SELECT * FROM permissions";
        private static string Users_Select = "SELECT ID, USERNAME, NAME, LASTNAME FROM Users";

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
            GetDBData("Movies", Movies_Select);
            GetDBData("Permissions", Permissions_Select);
            GetDBData("Users", Users_Select);
        }

        public static class GetData
        {
            public static List<string> ListPermissions()
            {
                List<string> ListPermissions = new List<string>();

                if (DS.Tables["Permissions"].Rows.Count == 0) throw new Exception("PERMLIST_EMPTY");

                foreach(DataRow dr in DS.Tables["Permissions"].Rows)
                {
                    ListPermissions.Add(dr["Permission"].ToString());
                }

                // SORT
                ListPermissions = ListPermissions.OrderBy(q => q).ToList();

                return ListPermissions;
            }

            public static DataTable Users()
            {
                DataTable tmp = DS.Tables["Users"].Clone();

                foreach (DataRow dr in DS.Tables["Users"].Rows) 
                    tmp.Rows.Add(dr.ItemArray);

                return tmp;
            }

            public static DataTable Movies()
            {
                DataTable tmp = DS.Tables["Movies"].Clone();

                foreach (DataRow dr in DS.Tables["Movies"].Rows)
                    tmp.Rows.Add(dr.ItemArray);

                return tmp;
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

            public static void Users()
            {
                DS.Tables["Users"].Clear();
                GetDBData("Users", Users_Select);
            }
        }
    }
}
