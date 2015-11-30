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
        private static OracleDataAdapter Movie_DataAdapter;

        private static string Movie_Select = "SELECT * FROM movies";

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

        private static void GetMovies()
        {
            Movie_DataAdapter = new OracleDataAdapter(new OracleCommand(Movie_Select, Database_Connector.GetConnection()));
            Movie_DataAdapter.Fill(DS, "Movies");
            Database_Connector.CloseConnection();
        }

        public static void FillDataSet()
        {
            GetMovies();
        }

        public static class Update
        {
            public static void Movies()
            {
                DS.Tables["ListeEtudiants"].Clear();
                GetMovies();
            }
        }
    }
}
