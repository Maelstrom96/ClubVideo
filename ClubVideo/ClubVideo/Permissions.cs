using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubVideo
{
    public class Permissions
    {
        private HashSet<String> UserPermissions = new HashSet<string>();
        int UserID;

        public Permissions(int Userid)
        {
            UserID = Userid;
            Load(UserID);
        }

        public bool HasPermission(string Perm)
        {
            if (UserPermissions.Contains(Perm.ToLower())) return true; // Permission is in the HashSet.
            if (HasWildCard(Perm)) return true;

            return false; // Nothing true;
        }

        public void AddPermission(string Perm)
        {
            UserPermissions.Add(Perm.ToLower());
        }

        private bool HasWildCard(string Perm)
        {
            if (UserPermissions.Contains("*")) return true; // Has Admin wildcard

            int LastIndex = 0;

            for (int i = 0; i < Perm.Count(x => x == '.'); i++)
            {
                LastIndex = Perm.IndexOf(".", LastIndex);
                string TempPerm = Perm.Substring(0, LastIndex + 1);

                if (UserPermissions.Contains(TempPerm + "*")) return true;
            }

            return false; 
        }

        private void Load(int Userid)
        {
            string select = "SELECT PERMISSION FROM USER_PERMISSIONS where USER_ID=:userid UNION ALL SELECT PERMISSION FROM USER_GROUPS inner join GROUP_PERMISSIONS on USER_GROUPS.GROUP_ID=GROUP_PERMISSIONS.GROUP_ID where USER_GROUPS.USER_ID=:userid";

            OracleCommand cmd = new OracleCommand(select, Database_Connector.GetConnection());

            cmd.Parameters.Add(new OracleParameter("userid", UserID.ToString()));
            OracleDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                UserPermissions.Add(dr["PERMISSION"].ToString());
            }

            Database_Connector.CloseConnection();
        }
    }
}
