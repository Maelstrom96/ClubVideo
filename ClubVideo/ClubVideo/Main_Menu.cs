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
        ResourceManager resManager;    
        CultureInfo culInfo;
        User user;

        public Main_Menu()
        {
            InitializeComponent();

            LoadSettings();
            LoadSettingsDB();
            LoadLanguage();
        }

        private void LoadSettingsDB()
        {
            culInfo = CultureInfo.CreateSpecificCulture("fr"); 
        }

        private void LoadSettings()
        {
            resManager = new ResourceManager("ClubVideo.Resources.Res", typeof(Main_Menu).Assembly);
        }

        private void LoadLanguage()
        {
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
                Close();
            }
        }
    }
}
