using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubVideo
{
    public partial class User_Settings : Form
    {
        public User_Settings()
        {
            InitializeComponent();

            LoadLanguage();
            LoadLanguageComboBox();
        }

        private void LoadLanguage()
        {
            lb_ChangeLanguageSetting.Text = Main.resManager.GetString("User_Settings_ChangeLanguage", Main.culInfo);
            lb_ChangePassword.Text = Main.resManager.GetString("User_Settings_ChangePassword", Main.culInfo);
            lb_Password.Text = Main.resManager.GetString("User_Settings_Password", Main.culInfo);
            lb_ConfPassword.Text = Main.resManager.GetString("User_Settings_ConfPassword", Main.culInfo);
            Text = Main.resManager.GetString("User_Settings_Header", Main.culInfo);
        }

        private void LoadLanguageComboBox()
        {
            List<String> Languages = Properties.Settings.Default.Languages.Cast<string>().ToList();

            foreach (string language in Languages)
            {
                cb_LanguageSetting.Items.Add(language);
            }
            cb_LanguageSetting.Text = Properties.Settings.Default.Language;
        }

        private void SaveSettings()
        {
            try
            {
                Database_Connector.Update.LanguageSetting(cb_LanguageSetting.Text);

                MessageBox.Show(Main.resManager.GetString("User_Settings_Save_Success", Main.culInfo));
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            Close();
        }

        private void lb_ChangeLanguageSetting_TextChanged(object sender, EventArgs e)
        {
            SizeF width = lb_ChangeLanguageSetting.CreateGraphics().MeasureString(lb_ChangeLanguageSetting.Text, lb_ChangeLanguageSetting.Font);
            cb_LanguageSetting.Location = new Point(lb_ChangeLanguageSetting.Location.X + (int)width.Width + 15, cb_LanguageSetting.Location.Y);
        }

        private void cb_LanguageSetting_SelectedIndexChanged(object sender, EventArgs e)
        {
            Main.culInfo = CultureInfo.CreateSpecificCulture(cb_LanguageSetting.Text);
            LoadLanguage();
        }

        private void bt_Save_Click(object sender, EventArgs e)
        {
            SaveSettings();
        }
    }
}
