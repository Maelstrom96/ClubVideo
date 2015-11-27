using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubVideo
{
    class User
    {
        private string Name;
        private string Username;
        private string LastName;
        private int UserID;
        private bool LoggedIn;
        private Permissions Perms = new Permissions();

        public User()
        {

            // Members Initializations
            LoggedIn = false;
        }

        public void Login(string username, string plainPassword)
        {
            if (LoggedIn) throw new Exception("User already logged-in.");



            LoggedIn = true;
        }
    }
}
