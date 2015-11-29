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
            return UserPermissions.Contains(Perm.ToLower());
        }

        public void AddPermission(string Perm)
        {
            UserPermissions.Add(Perm.ToLower());
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
