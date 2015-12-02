using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubVideo
{
    public partial class Manage_Users : Form
    {
        private BindingSource bs_Users;

        public Manage_Users()
        {
            InitializeComponent();

            LoadUsers();
        }

        private void LoadUsers()
        {
            DataTable db_Users = Database.GetData.Users();

            bs_Users = new BindingSource();
            bs_Users.DataSource = db_Users;
            dgv_Users.DataSource = bs_Users;
        }
    }
}
