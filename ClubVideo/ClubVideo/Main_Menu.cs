using ClubVideo.Properties;
using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubVideo
{
    public partial class Main_Menu : Form
    {
        public enum Submenu {Administration, Logout, Quit, NULL};
        static Submenu menu = Submenu.NULL;
        public static Submenu Menu { get { return menu; } set { menu = value; } }

        public Main_Menu()
        {
            InitializeComponent();

            //TEMP TEST
            //Database_Connector.AddUser("Test", "test");
            //SidebySideSelection ss = new SidebySideSelection(Database.GetData.ListPermissions(), new List<string>(), "Test");
            //ss.ShowDialog();
            //MovieObject movie = Database_Connector.GetFromIMDB("tt2975590");
            //InsertMovie AddMovieForm = new InsertMovie(Database_Connector.GetFromIMDB("tt2975590"));
            //AddMovieForm.ShowDialog();

            LoadLanguage();
        }

        private void LoadLanguage()
        {
            bt_Exit.Text = Main.resManager.GetString("Button_Menu_Exit", Main.culInfo);
            bt_Logout.Text = Main.resManager.GetString("Button_Menu_Logout", Main.culInfo);
            bt_Settings.Text = Main.resManager.GetString("Button_Menu_Settings", Main.culInfo);
            bt_SearchMembers.Text = Main.resManager.GetString("Button_Menu_SearchMembers", Main.culInfo);
            bt_SearchMovies.Text = Main.resManager.GetString("Button_Menu_SearchMovies", Main.culInfo);
            bt_POS.Text = Main.resManager.GetString("Button_Menu_POS", Main.culInfo);
            bt_Administration.Text = Main.resManager.GetString("Button_Menu_Administration", Main.culInfo);
        }

        private void SwitchLanguage(string LanguageCode)
        {

        }

        /// <summary>
        /// Prevent user from resizing the form.
        /// </summary>
        /// <param name="message"></param>
        protected override void WndProc(ref Message message)
        {
            const int WM_NCHITTEST = 0x0084;

            if (message.Msg == WM_NCHITTEST)
                return;

            base.WndProc(ref message);
        }

        private void bt_Exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(Main.resManager.GetString("Confirm_Exit_Main_Menu", Main.culInfo), Main.resManager.GetString("Header_Exit_Main_Menu", Main.culInfo), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Main.Exit = true;
                menu = Submenu.Quit;
                Close();
            }
        }

        private void bt_Logout_Click(object sender, EventArgs e)
        {
            menu = Submenu.Logout;
            Close();
        }

        private void Main_Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Database_Connector.CloseConnection();
        }

        private void Button_Permissions(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            string PermString = this.Name.ToString() + '.' + bt.Name.ToString();

            int index = PermString.IndexOf("bt_");
            string cleanPerm = (index < 0)
                ? PermString
                : PermString.Remove(index, 3);

            bt.Enabled = Main.user.Permissions.HasPermission(cleanPerm);
        }

        private void bt_Settings_Click(object sender, EventArgs e)
        {
            User_Settings usettingsForm = new User_Settings();
            usettingsForm.ShowDialog();
            LoadLanguage();
        }

        private void bt_Administration_Click(object sender, EventArgs e)
        {
            Menu = Submenu.Administration;
            Close();
        }

        private void bt_SearchMovies_Click(object sender, EventArgs e)
        {
            Manage_Movies movies = new Manage_Movies();
            movies.ShowDialog();
        }
    }
}
