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
            //Database_Connector.Insert.Movie(Database_Connector.GetFromIMDB("tt2975590"));

            //InsertMovie AddMovieForm = new InsertMovie(Database_Connector.GetFromIMDB("tt2975590"));
            //AddMovieForm.ShowDialog();

            LoadLanguage();
            Main.RefreshColors(this);
            Main.UpdateFonts(this);
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
            this.Refresh();
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

        // MOUSE CLICK
        private void bt_Settings_Click(object sender, EventArgs e)
        {
            User_Settings usettingsForm = new User_Settings();
            usettingsForm.ShowDialog();
            LoadLanguage();
            menu = Submenu.NULL;
            Close();
        }
        private void bt_Administration_Click(object sender, EventArgs e)
        {
            Menu = Submenu.Administration;
            Close();
        }
        private void bt_SearchMovies_Click(object sender, EventArgs e)
        {
            Hide();
            Manage_Movies movies = new Manage_Movies();
            movies.ShowDialog();
        }
        private void bt_SearchMembers_Click(object sender, EventArgs e)
        {
            Hide();
            Manage_Members members = new Manage_Members();
            members.ShowDialog();
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

        // MOUSE ENTER
        private void bt_MouseEnter(object send, EventArgs e)
        {
            Button sender = (Button)send;
            sender.Image = Main.Img_ToWhite(sender.Name.Substring(3));
            sender.FlatAppearance.MouseOverBackColor = Main.GetColor();
            sender.ForeColor = Color.White;
        }
        private void bt_Logout_MouseEnter(object sender, EventArgs e)
        {
            ((Button)sender).Image = Main.GetImage("Locked_Blue_small");
            ((Button)sender).FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
        }
        private void bt_Exit_MouseEnter(object sender, EventArgs e)
        {
            ((Button)sender).Image = Properties.Resources.Exit_White;
            ((Button)sender).BackColor = Color.FromArgb(137, 34, 34);
            ((Button)sender).ForeColor = Color.White;
        }


        // MOUSE LEAVE
        private void bt_MouseLeave(object send, EventArgs e)
        {
            Button sender = (Button)send;
            sender.Image = Main.Img_ToColor(sender.Name.Substring(3), false);
            sender.FlatAppearance.MouseOverBackColor = Color.White;
            sender.ForeColor = Main.GetColor();
        }
        private void bt_Logout_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).Image = Main.GetImage("Unlocked_Blue_small");
        }
        private void bt_Exit_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).Image = Properties.Resources.Exit;
            ((Button)sender).BackColor = Color.White;
            ((Button)sender).ForeColor = Color.Black;
        }

        // SÉPARATEURS
        private void Main_Menu_Paint(object sender, PaintEventArgs e)
        {
            CreateSeparators(e);
        }
        private void CreateSeparators(PaintEventArgs e)
        {
            Pen p = new Pen(Color.FromArgb(201,201,201));
            int startPY = (int)(this.Height * 0.2);
            int endPY = (int)(this.Height * 0.8);

            int pX = (int)((bt_SearchMovies.Location.X - bt_POS.Width) / 2 + bt_POS.Width);
            Point start = new Point(pX , startPY);
            Point end = new Point(pX, endPY);
            e.Graphics.DrawLine(p, start, end);

            pX = (int)((bt_Administration.Location.X - (bt_SearchMembers.Location.X + bt_SearchMembers.Width)) / 2 + (bt_SearchMembers.Location.X + bt_SearchMembers.Width));
            start = new Point(pX, startPY);
            end = new Point(pX, endPY);
            e.Graphics.DrawLine(p, start, end);

            pX = (int)((bt_Logout.Location.X - (bt_Settings.Location.X + bt_Settings.Width)) / 2 + (bt_Settings.Location.X + bt_Settings.Width));
            start = new Point(pX, startPY);
            end = new Point(pX, endPY);
            e.Graphics.DrawLine(p, start, end);

            p.Dispose();
        }

        private void bt_POS_Click(object sender, EventArgs e)
        {
            Hide();
            POS pos = new POS();
            pos.ShowDialog();
        }
    }
}
