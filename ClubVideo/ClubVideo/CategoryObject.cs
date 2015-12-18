using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubVideo
{
    public class CategoryObject
    {
        public int ID { get; set; }
        public string Name_En { get; set; }
        public string Name_Fr { get; set; }
        public string Description_En { get; set; }
        public string Description_Fr { get; set; }
        public decimal Price { get; set; }


        public static string GetCategoryName(int id)
        {
            CultureInfo tmp = CultureInfo.CreateSpecificCulture("fr");

            DataTable dt = Database.GetData.Categories();

            string name = string.Empty;
            string column = string.Empty;

            // FR
            if (Main.culInfo.Equals(tmp))
                column = "NAME_FR";
            // EN
            else
                column = "NAME_EN";


            foreach (DataRow row in dt.Rows)
            {
                if (int.Parse(row["ID"].ToString()) == id)
                {
                    name = row[column].ToString();
                }
            } 

            return name;
        }

        public static int GetCategoryID(string Name)
        {
            CultureInfo tmp =  CultureInfo.CreateSpecificCulture("fr");

            DataTable dt = Database.GetData.Categories();

            int id = -1;
            string column = string.Empty;

            // FR
            if (Main.culInfo.Equals(tmp))
                column = "NAME_FR";
            // EN
            else
                column = "NAME_EN";


            foreach (DataRow row in dt.Rows)
            {
                if (row[column].ToString() == Name)
                {
                    id = int.Parse(row["ID"].ToString());
                }
            }

            //id = (from DataRow dr in dt.Rows
            //      where dr[column] == Name
            //      select (int)dr["ID"]).First();

            if (id == -1) throw new Exception("SOMETHING_WENT_WRONG");
            return id;
        }
    }
}
