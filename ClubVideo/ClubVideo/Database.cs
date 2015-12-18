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
        ),
        NBCopyFree as
        (  
          select movie_id, count(movie_id) as NBCOPIESFREE 
          from movies_copies left outer join rentals on rentals.copy_id = movies_copies.id where rentals.returndate is not null or rentals.id is null
          group by movies_copies.movie_id
        )

        select
            Movies.id,
            Movies.name_en,
            Movies.name_fr,
            Movies.description_fr,
            Movies.description_en,
            Movies.Directors,
            Movies.releasedate,
            Movies.rating,
            Movies.runtime,
            Movies.image,
            Categories.NAME_EN as Category_EN,
            Categories.NAME_FR as Category_FR,
            coalesce(NBCopy.NBCOPIES, 0) as NBCOPIES,
            coalesce(NBCopyFree.NBCOPIESFREE, 0) as NBCOPIESFREE
        from Movies left outer join NBCopy on NBCopy.Movie_ID = Movies.ID left outer join NbCopyFree on NbCopyFree.movie_id=Movies.ID inner join Categories on Categories.ID = Movies.CATEGORY where DELETEDATE is null";

        private static string Permissions_Select = "SELECT * FROM permissions";
        private static string Users_Select = "SELECT ID, USERNAME, NAME, LASTNAME FROM Users";
        private static string Members_Select = "SELECT * FROM Members";
        private static string Categories_Select = "SELECT * FROM CATEGORIES";
        private static string Copies_Select = "SELECT * FROM MOVIES_COPIES";
        private static string Locations_Select = "SELECT * FROM RENTALS";

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
            GetDBData("Members", Members_Select);
            GetDBData("Categories", Categories_Select);
            GetDBData("Movies_Copies", Copies_Select);
            GetDBData("Rentals", Locations_Select);
        }

        public static class GetData
        {
            public static List<string> List(string Table, string Column, bool Sort = true)
            {
                List<string> List = new List<string>();

                if (DS.Tables[Table].Rows.Count == 0) throw new Exception("LIST_EMPTY");

                foreach (DataRow dr in DS.Tables[Table].Rows)
                {
                    List.Add(dr[Column].ToString());
                }

                // SORT
                if (Sort) List = List.OrderBy(q => q).ToList();

                return List;
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

            public static DataTable Members()
            {
                DataTable tmp = DS.Tables["Members"].Clone();

                foreach (DataRow dr in DS.Tables["Members"].Rows)
                    tmp.Rows.Add(dr.ItemArray);

                return tmp;
            }

            public static DataTable Categories()
            {
                DataTable tmp = DS.Tables["Categories"].Clone();

                foreach (DataRow dr in DS.Tables["Categories"].Rows)
                    tmp.Rows.Add(dr.ItemArray);

                return tmp;
            }

            public static DataTable Copies()
            {
                DataTable tmp = DS.Tables["Movies_Copies"].Clone();

                foreach (DataRow dr in DS.Tables["Movies_Copies"].Rows)
                    tmp.Rows.Add(dr.ItemArray);

                return tmp;
            }

            public static DataTable Locations()
            {
                DataTable tmp = DS.Tables["Rentals"].Clone();

                foreach (DataRow dr in DS.Tables["Rentals"].Rows)
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
                Users();
                Members();
                Copies();
                Locations();
            }

            public static void Movies()
            {
                DS.Tables["Movies"].Clear();
                GetDBData("Movies", Movies_Select);
            }

            public static void Copies()
            {
                DS.Tables["Movies_Copies"].Clear();
                GetDBData("Movies_Copies", Movies_Select);
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

            public static void Members()
            {
                DS.Tables["Members"].Clear();
                GetDBData("Members", Members_Select);
            }

            public static void Categories()
            {
                DS.Tables["Categories"].Clear();
                GetDBData("Categories", Categories_Select);
            }
            public static void Locations()
            {
                DS.Tables["Rentals"].Clear();
                GetDBData("Rentals", Movies_Select);
            }
            
        }
    }
}
