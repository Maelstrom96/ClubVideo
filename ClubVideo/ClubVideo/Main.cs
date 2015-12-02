using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubVideo
{
    public class Main
    {
        public static bool Exit { get; set; }
        public static ResourceManager resManager { get; set; }
        public static CultureInfo culInfo { get; set; }
        public static User user { get; set; }

        public Main()
        {
            LoadSettings();
            LoadDataBase();
            Database.FillDataSet();
        }

        public void Run()
        {
            Exit = false;
            while (!Exit)
            {
                // Connexion
                if (UserLogin() != DialogResult.OK) Exit = true;
                else
                {
                    // Show Main Menu
                    Main_Menu main_menuForm = new Main_Menu();
                    main_menuForm.ShowDialog();


                }
            }
        }

        private DialogResult UserLogin()
        {
            UserLogon formLogon = new UserLogon();
            return formLogon.ShowDialog();
        }

        private void LoadSettings()
        {
            resManager = new ResourceManager("ClubVideo.Resources.Res", typeof(Main).Assembly);
            culInfo = CultureInfo.CreateSpecificCulture(Properties.Settings.Default.Language);
        }

        private void LoadDataBase()
        {
            try
            {
                Database_Connector.OpenConnection();
                Database.FillDataSet();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
