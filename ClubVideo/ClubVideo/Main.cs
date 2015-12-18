using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace ClubVideo
{
    public class Main
    {
        private static CultureInfo info_;

        public static bool Exit { get; set; }
        public static ResourceManager resManager { get; set; }
        public static CultureInfo culInfo {
            get { return info_; }
            set { info_ = value; } 
        }
        public static User user { get; set; }
        
        public static Color BLUE = Color.FromArgb(34, 105, 159);
        public static Color previousColor = BLUE;

        public Main()
        {
            LoadSettings();
            LoadDataBase();
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
                    Main_Menu.Menu = Main_Menu.Submenu.NULL;

                    info_ = CultureInfo.CreateSpecificCulture(Properties.Settings.Default.Language);

                    while (Main_Menu.Menu != Main_Menu.Submenu.Quit && Main_Menu.Menu != Main_Menu.Submenu.Logout)
                    {
                        // Show Main Menu
                        Main_Menu main_menuForm = new Main_Menu();
                        main_menuForm.ShowDialog();

                        switch (Main_Menu.Menu)
                        {
                            case Main_Menu.Submenu.Administration:
                                // Show Admin Menu
                                Admin_Menu admin_menuForm = new Admin_Menu();
                                admin_menuForm.ShowDialog();
                                Main_Menu.Menu = Main_Menu.Submenu.NULL;
                                break;
                            default:
                                break;
                        }
                    }
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

        public static Color GetColor()
        {
            return ColorTranslator.FromHtml(Properties.Settings.Default.UI_Color);
        }
        public static string GetFont()
        {
            return Properties.Settings.Default.UI_Font;
        }

        public static void RefreshForms()
        {
            foreach (Form form in Application.OpenForms)
                form.Refresh();
        }

        public static Image GetImage(string imgName)
        {
            object img = Properties.Resources.ResourceManager.GetObject(imgName);
            return (Image)img;
        }

        public static void UpdateFonts(Form form)
        {
            foreach (Control c in form.Controls)
            {
                if (c is TextBox || c is DataGridView)
                {
                    c.Font = new Font(Properties.Settings.Default.Fonts[0], c.Font.Size);
                    c.ForeColor = Color.Black;
                }
                else
                {
                    c.Font = new Font(Main.GetFont(), c.Font.Size);
                    if (c.Name != "bt_Exit" && c.Name != "bt_Back" && c.Name != "bt_Logout")
                        c.ForeColor = Main.GetColor();
                }
            }
            form.Update();
            form.Refresh();
        }

        // OPÉRATIONS SUR LES IMAGES
        public static Image Img_ToWhite(string imgName)
        {
            Bitmap img = new Bitmap(Main.GetImage(imgName));

            for (int i = 0; i < img.Width; i++)
            {
                for (int j = 0; j < img.Height; j++)
                {
                    Color pixel = img.GetPixel(i, j);
                    if ((pixel.R > Main.GetColor().R * 0.9 || pixel.G > Main.GetColor().G * 0.9 || pixel.B > Main.GetColor().B * 0.9))
                    {
                        pixel = Color.FromArgb(pixel.A, Color.White.R, Color.White.G, Color.White.B);
                        img.SetPixel(i, j, pixel);
                    }
                }
            }
            return img;
        }

        public static Image Img_ToColor(string imgName, bool start)
        {
            Bitmap img = new Bitmap(Main.GetImage(imgName));
            if (imgName[0] != '_')
            {
                for (int i = 0; i < img.Width; i++)
                {
                    for (int j = 0; j < img.Height; j++)
                    {
                        Color pixel = img.GetPixel(i, j);

                        if ((start && (pixel.R > Main.BLUE.R * 0.9 || pixel.G > Main.BLUE.G * 0.9 || pixel.B > Main.BLUE.B * 0.9))
                            || (pixel.R > Main.previousColor.R * 0.9 || pixel.G > Main.previousColor.G * 0.9 || pixel.B > Main.previousColor.B * 0.9))
                        {
                            Color newColor = Main.GetColor();
                            pixel = Color.FromArgb(pixel.A, newColor.R, newColor.G, newColor.B);
                            img.SetPixel(i, j, pixel);
                        }
                    }
                }
                Main.previousColor = Main.GetColor();
            }

            return img;
        }

        public static void RefreshColors(Form form)
        {
            foreach (Control c in form.Controls)
            {
                if (c is Button)
                {
                    Button sender = (Button)c;
                    if (sender.Name != "bt_Exit" && sender.Name != "bt_Logout" && sender.Name != "bt_Back" && sender.Name != "btn_AddCopies")
                    {
                        sender.FlatAppearance.MouseDownBackColor = Main.GetColor();
                        sender.Image = Main.Img_ToColor(c.Name.Substring(3), true);
                    }
                    else if (sender.Name == "bt_Logout")
                        sender.ForeColor = Color.Black;
                    else if (sender.Name == "bt_Exit")
                        sender.FlatAppearance.MouseDownBackColor = Color.FromArgb(137, 34, 34);
                }
            }
        }
    }
}
