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
        public static ResourceManager resManager;    
        public static CultureInfo culInfo;
        public static User user { get; set; }

        public Main_Menu()
        {
            InitializeComponent();

            LoadSettings();
            LoadSettingsDB();
            LoadDataBase();

            //TEMP
            //Database_Connector.AddUser("Test", "test");

            if (UserLogin() != DialogResult.OK) Close();

            LoadLanguage();
        }

        private DialogResult UserLogin()
        {
            UserLogon formLogon = new UserLogon();
            return formLogon.ShowDialog();
        }

        private void LoadDataBase()
        {
            try
            {
                Database_Connector.OpenConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }


        private void LoadSettingsDB()
        {
            culInfo = CultureInfo.CreateSpecificCulture(Properties.Settings.Default.Language);
        }

        private void LoadSettings()
        {
            resManager = new ResourceManager("ClubVideo.Resources.Res", typeof(Main_Menu).Assembly);
        }

        private void LoadLanguage()
        {
            culInfo = CultureInfo.CreateSpecificCulture(Properties.Settings.Default.Language);

            bt_Exit.Text = resManager.GetString("Button_Menu_Exit", culInfo);
            bt_Logout.Text = resManager.GetString("Button_Menu_Logout", culInfo);
            bt_Settings.Text = resManager.GetString("Button_Menu_Settings", culInfo);
            bt_ManageMembers.Text = resManager.GetString("Button_Menu_ManageMembers", culInfo);
            bt_ManageMovies.Text = resManager.GetString("Button_Menu_ManageMovies", culInfo);
            bt_POS.Text = resManager.GetString("Button_Menu_POS", culInfo);
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
            if (MessageBox.Show(resManager.GetString("Confirm_Exit_Main_Menu",culInfo), resManager.GetString("Header_Exit_Main_Menu", culInfo), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Program.Exit = true;
                Close();
            }
        }

        private void bt_Logout_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Main_Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Database_Connector.CloseConnection();
            Settings.Default.Reset();
        }

        private void Button_Permissions(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            string PermString = this.Name.ToString() + '.' + bt.Name.ToString();

            bt.Enabled = user.Permissions.HasPermission(PermString);
        }
    }
}
