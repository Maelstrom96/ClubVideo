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
    public partial class Admin_Menu : Form
    {
        public Admin_Menu()
        {
            InitializeComponent();

            LoadLanguage();
        }

        private void bt_Back_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LoadLanguage()
        {
            bt_Back.Text = Main.resManager.GetString("Button_Admin_Menu_Back", Main.culInfo);
            bt_ManageUsers.Text = Main.resManager.GetString("Button_Admin_Menu_ManageUsers", Main.culInfo);
        }

        private void bt_ManageUsers_Click(object sender, EventArgs e)
        {
            Manage_Users musers_Form = new Manage_Users();
            musers_Form.ShowDialog();
            Show();
        }

        private void bt_ManageMembers_Click(object sender, EventArgs e)
        {
            Hide();
            Manage_Members members = new Manage_Members(true);
            members.ShowDialog();
            Show();
        }

        private void bt_ManageMovies_Click(object sender, EventArgs e)
        {
            Manage_Movies movies = new Manage_Movies(true);
            Hide();
            movies.ShowDialog();
            Show();
        }

        private void bt_ManageCategories_Click(object sender, EventArgs e)
        {
            Manage_Categories categories = new Manage_Categories();
            Hide();
            categories.ShowDialog();
            Show();
        }

        private void bt_Back_MouseEnter(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.FromArgb(82,82,82);
            ((Button)sender).ForeColor = Color.White;
            ((Button)sender).Image = Main.GetImage(((Button)sender).Name.Substring(3) + "_White");
        }

        private void bt_Back_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.White;
            ((Button)sender).ForeColor = Color.Black;
            ((Button)sender).Image = Main.GetImage(((Button)sender).Name.Substring(3));
        }
    }
}
