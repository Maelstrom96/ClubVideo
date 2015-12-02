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
            if (UserLogin() != DialogResult.OK)
            {
                Program.Exit = true;
            }
            else
            {
                Application.Run(new Main_Menu());
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
