using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubVideo
{
    class Permissions
    {
        private HashSet<String> UserPermissions = new HashSet<string>();

        public Permissions()
        {

        }

        public bool HasPermission(string Perm)
        {
            return UserPermissions.Contains(Perm.ToLower());
        }

        public void AddPermission(string Perm)
        {
            UserPermissions.Add(Perm.ToLower());
        }
    }
}
