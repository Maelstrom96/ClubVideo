﻿using System;
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

            foreach (Control c in this.Controls)
            {
                if (c is Button)
                {
                    ((Button)c).FlatAppearance.MouseDownBackColor = BLUE;
                    ((Button)c).FlatAppearance.MouseOverBackColor = BLUE;
                }
            }
        }

        private void LoadLanguage(string form)
        {
            if (form == "lang")
            {
                Controls["LBL_LanguageSelection"].Text = Main.resManager.GetString("User_Settings_Lang_Selection", Main.culInfo);
            }
            else if (form == "password")
            {
                Controls["B_confirm"].Text = Main.resManager.GetString("User_Settings_Pass_Button", Main.culInfo);
                Controls["LBL_currentPassword"].Text = Main.resManager.GetString("User_Settings_Pass_CurrentPass", Main.culInfo);
                Controls["LBL_newPassword"].Text = Main.resManager.GetString("User_Settings_Pass_NewPass", Main.culInfo);
                Controls["LBL_confirmPassword"].Text = Main.resManager.GetString("User_Settings_Pass_ConfirmPass", Main.culInfo);
            }
            else if (form == "fonts")
            {

            }
        }
        private void SaveSettings()
        {
            try
            {
                MessageBox.Show(Main.resManager.GetString("User_Settings_Save_Success", Main.culInfo));
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        // Couleur primaire du form
        private Color BLUE = Color.FromArgb(34, 105, 159);

        // Button Events
        private bool bClicked = false;
        private void Button_Enter(object send, EventArgs e)
        {
            if (!bClicked)
            {
                Button sender = (Button)send;
                sender.BackColor = BLUE;
                sender.FlatAppearance.MouseOverBackColor = BLUE;
                sender.BackgroundImage = GetImage(sender.Name.Substring(2) + "_hover");

                AddLabel(sender);
            }
        }
        private void Button_Leave(object send, EventArgs e)
        {
            if (!bClicked)
            {
                Button sender = (Button)send;
                sender.BackColor = Color.White;
                sender.BackgroundImage = GetImage(sender.Name.Substring(2));

                Controls.Remove(Controls["LBL" + sender.Name.Substring(1)]);
            }
        }
        private void Button_Click(object send, EventArgs e)
        {
            Button sender = (Button)send;
            if (!bClicked)
                CreateSubForm(sender);
            else
                DeleteSubForm(sender);

            bClicked = !bClicked;
        }
        
        // Actions sur les sous-forms
        private void CreateSubForm(Button sender)
        {
            Controls["LBL" + sender.Name.Substring(1)].Visible = false;
            sender.BackColor = BLUE;
            sender.BackgroundImage = GetImage(sender.Name.Substring(2) + "_small");
            sender.Width = 101;

            if (sender.Location.X < this.Width / 2)
                sender.Location = new Point(0, 0);
            else
                sender.Location = new Point(this.Width - (sender.Width + 16), 0);

            AddPanel(sender);
            if (sender.Name == "B_lang")
                Form_Lang();
            else if (sender.Name == "B_password")
                Form_Password(sender);
            else
                Form_Fonts(sender);
         }
        private void DeleteSubForm(Button sender)
        {
            Controls["LBL" + sender.Name.Substring(1)].Visible = true;
            Controls["PNL_SettingsForm"].Dispose();
            Controls["PB_triangle"].Dispose();
            sender.BackColor = Color.White;
            sender.BackgroundImage = GetImage(sender.Name.Substring(2) + "_hover");
            sender.Width = 200;
            int pX = sender.Name == "B_lang" ? 0 : sender.Name == "B_password" ? 200 : 400;
            sender.Location = new Point(pX, sender.Location.Y);

            if (sender.Name == "B_lang")
                Form_Lang();
            else if (sender.Name == "B_password")
                Form_Password(sender);
            else
                Form_Fonts(sender);
        }

        // Construction/Destruction des différents sous-forms (A FAIRE: SÉPARER LES CONSTRUCTION/DESTRUCTION)
        private void Form_Lang()
        {
            if (!bClicked)
            {
                Lang_AddRadioButton("fr");
                Lang_AddRadioButton("en");
                Lang_AddLabel();

                LoadLanguage("lang");
            }
            else
            {
                Controls["RB_fr"].Dispose();
                Controls["RB_en"].Dispose();
                Controls["LBL_LanguageSelection"].Dispose();
            }
        }
        private void Form_Password(Button sender)
        {
            if (!bClicked)
            {
                Pass_AddTextBox(sender);
                Pass_AddButon(sender);

                LoadLanguage("password");
            }
            else
            {
                Controls["TB_currentPassword"].Dispose();
                Controls["TB_newPassword"].Dispose();
                Controls["TB_confirmPassword"].Dispose();
                Controls["LBL_currentPassword"].Dispose();
                Controls["LBL_newPassword"].Dispose();
                Controls["LBL_confirmPassword"].Dispose();
                Controls["B_confirm"].Dispose();
            }
        }
        private void Form_Fonts(Button sender)
        {
            if (!bClicked)
            {

                LoadLanguage("fonts");
            }
            else
            {

            }
        }


        // Fenêtre Settings LANGAGE
        private void Lang_AddLabel()
        {
            Label LBL = Lang_CreateLabel();
            Controls.Add(LBL);
            LBL.BringToFront();
            Controls["PB_triangle"].BringToFront();
        }
        private Label Lang_CreateLabel()
        {
            Label LBL = new Label();
            LBL.Name = "LBL_LanguageSelection";
            LBL.Text = "Select your prefered language";
            LBL.Font = new Font("Arial", 12, FontStyle.Bold);
            LBL.TextAlign = ContentAlignment.MiddleCenter;
            LBL.ForeColor = BLUE;
            LBL.BackColor = Color.White;
            LBL.Width = this.Width - B_lang.Width;

            int pX = B_lang.Width;
            LBL.Location = new Point(pX, 40);

            return LBL;
        }

        private void Lang_AddRadioButton(string lang)
        {
            RadioButton RB = Lang_CreateRadioButton(lang);
            Controls.Add(RB);
            RB.BringToFront();
        }
        private RadioButton Lang_CreateRadioButton(string lang)
        {
            RadioButton RB = new RadioButton();
            RB.Name = "RB_" + lang.ToLower();
            RB.Text = lang.ToUpper();
            RB.Font = new Font("Arial", 24, FontStyle.Bold);
            RB.TextAlign = ContentAlignment.MiddleCenter;
            RB.Size = new Size(85, 85);
            RB.Appearance = Appearance.Button;
            RB.FlatStyle = FlatStyle.Flat;

            RB.FlatAppearance.CheckedBackColor = BLUE;
            RB.BackColor = Color.White;
            if (lang.ToLower() == Main.culInfo.Name.Substring(0, 2))
            {
                RB.Checked = true;
                RB.ForeColor = Color.White;
                RB.FlatAppearance.MouseOverBackColor = BLUE;
            }
            else
            {
                RB.ForeColor = BLUE;
                RB.FlatAppearance.MouseOverBackColor = DefaultBackColor;
            }

            RB.Cursor = Cursors.Hand;
            RB.FlatAppearance.BorderSize = 0;
            RB.Click += Lang_RadioButton_Click;

            int offset = lang == "fr" ? -RB.Width / 2 : RB.Width / 2;
            int pX = this.Width / 2 + offset;
            int pY = this.Height / 2 - RB.Height / 2;
            RB.Location = new Point(pX, pY);

            return RB;
        }
        private void Lang_RadioButton_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is RadioButton)
                {
                    RadioButton RB = (RadioButton)c;
                    RB.ForeColor = BLUE;

                    if (RB.Checked)
                    {
                        RB.ForeColor = Color.White;
                        RB.FlatAppearance.MouseOverBackColor = BLUE;
                    }
                    else
                    {
                        RB.ForeColor = BLUE;
                        RB.FlatAppearance.MouseOverBackColor = DefaultBackColor;
                    }
                }
            }

            UpdateLanguage((RadioButton)sender);
        }

        private void UpdateLanguage(RadioButton sender)
        {
            Database_Connector.Update.LanguageSetting(sender.Text.ToLower());
            Main.culInfo = CultureInfo.CreateSpecificCulture(sender.Text.ToLower());
            LoadLanguage("lang");
            SaveSettings();
        }


        // Fenêtre Settings PASSWORD
        private void Pass_AddLabel()
        {

        }
        private void Pass_AddTextBox(Button sender)
        {
            int pX = sender.Width + Controls["PB_triangle"].Width + 45;

            TextBox TB = Pass_CreateTextBox("currentPassword", pX, 35, true);
            Label LBL = Pass_CreateLabel("currentPassword", pX - 4, TB.Location.Y - 22);
            Controls.Add(LBL);
            LBL.BringToFront();
            Controls.Add(TB);
            TB.BringToFront();

            TB = Pass_CreateTextBox("newPassword", pX, TB.Location.Y + 63, false);
            LBL = Pass_CreateLabel("newPassword", pX - 4, TB.Location.Y - 22);
            Controls.Add(LBL);
            LBL.BringToFront();
            Controls.Add(TB);
            TB.BringToFront();

            pX = TB.Location.X + TB.Width + 19;
            TB = Pass_CreateTextBox("confirmPassword", pX, TB.Location.Y, false);
            LBL = Pass_CreateLabel("confirmPassword", pX - 4, TB.Location.Y - 22);
            Controls.Add(LBL);
            LBL.BringToFront();
            Controls.Add(TB);
            TB.BringToFront();
        }
        private void Pass_AddButon(Button sender)
        {
            Button B = Pass_CreateButton(sender, "Confirm");
            Controls.Add(B);
            B.BringToFront();
        }

        private Label Pass_CreateLabel(string name, int X, int Y)
        {
            Color darkBlue = Color.FromArgb(10,61,101);
            Label LBL = new Label();
            LBL.Name = "LBL_" + name;
            LBL.Text = name == "currentPassword" ? "Your current password" : name == "newPassword" ? "New Password" : "Confirm Password";
            LBL.Font = new Font("Arial", 14);
            LBL.BackColor = Color.White;
            LBL.ForeColor = darkBlue;
            LBL.Location = new Point(X, Y);
            LBL.AutoSize = true;

            return LBL;
        }
        private TextBox Pass_CreateTextBox(string name, int X, int Y, bool isLong)
        {
            TextBox TB = new TextBox();
            TB.Name = "TB_" + name;
            TB.Width = isLong ? 397 : 189;
            TB.Font = new Font("Arial", 17);
            TB.Location = new Point(X, Y);
            TB.PasswordChar = '●';
            TB.BackColor = Color.White;
            TB.ForeColor = Color.Black;
            TB.BorderStyle = BorderStyle.FixedSingle; Pen p = new Pen(Color.Red);

            return TB;
        }
        private Button Pass_CreateButton(Button sender, string name)
        {
            Button B = new Button();
            B.Name = "B_" + name.ToLower();
            B.TextAlign = ContentAlignment.MiddleCenter;
            B.Font = new Font("Arial", 14);
            B.Width = 192;
            B.Height = 42;
            B.BackColor = BLUE;
            B.ForeColor = Color.White;
            B.FlatStyle = FlatStyle.Flat;
            B.FlatAppearance.BorderSize = 0;
            B.Cursor = Cursors.Hand;
            B.Click += B_confirm_Click;

            int pX = (this.Width - sender.Width) / 2;
            int pY = Controls["TB_newPassword"].Location.Y + Controls["TB_newPassword"].Height + 12;
            B.Location = new Point(pX, pY);

            return B;
        }

        void B_confirm_Click(object sender, EventArgs e)
        {
            try
            {
                VerifyPasswords();
                Database_Connector.Update.UserPassword(Main.user.ID, Controls["TB_confirmPassword"].Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void VerifyPasswords()
        {
            if (Database_Connector.GetUserIdByUsernameAndPassword(Main.user.Username, Controls["TB_currentPassword"].Text) == 0)
            {
                Controls["TB_currentPassword"].Text = "";
                Controls["TB_newPassword"].Text = "";
                Controls["TB_confirmPassword"].Text = "";
                throw new Exception("PASSWORD_INVALID");
            }
            else if (Controls["TB_newPassword"].Text == String.Empty || Controls["TB_confirmPassword"].Text == String.Empty)
                throw new Exception("PASSWORD_EMPTY");
            else if (Controls["TB_currentPassword"].Text == Controls["TB_newPassword"].Text)
            {
                Controls["TB_newPassword"].Text = "";
                Controls["TB_confirmPassword"].Text = "";
                throw new Exception("PASSWORD_SAME");
            }
            else if (Controls["TB_newPassword"].Text != Controls["TB_confirmPassword"].Text)
            {
                Controls["TB_confirmPassword"].Text = "";
                throw new Exception("PASSWORD_NOT_MATCHING");
            }
        }


        // Fenêtre Settings FONTS



        // Fenêtre Settings Général
        private void AddTriangle(Button sender)
        {
            PictureBox PB = new PictureBox();
            PB.Name = "PB_triangle";
            PB.Image = GetImage("triangle");
            PB.Size = new Size(12, 31);
            PB.BackColor = Color.White;
            PB.SizeMode = PictureBoxSizeMode.Zoom;

            int pX;
            if (sender.Location.X < this.Width / 2)
                pX = sender.Width;
            else
            {
                pX = this.Width - sender.Width - PB.Width - 16;
                PB.Image.RotateFlip(RotateFlipType.Rotate180FlipNone);
            }
            PB.Location = new Point(pX, 35);

            Controls.Add(PB);
            PB.BringToFront();
        }
        private void AddLabel(Button sender)
        {
            Label LBL = CreateLabel(sender);
            Controls.Add(LBL);
            LBL.BringToFront();
        }
        private void AddPanel(Button sender)
        {
            Panel PNL = CreatePanel(sender);
            Controls.Add(PNL);
            PNL.BringToFront();

            AddTriangle(sender);
        }

        private Panel CreatePanel(Button sender)
        {
            Panel PNL = new Panel();
            PNL.Name = "PNL_SettingsForm";
            PNL.Height = this.Height;
            PNL.BackColor = Color.White;
            int pX;
            if (sender.Location.X < this.Width / 2)
            {
                pX = sender.Width;
                PNL.Width = this.Width - sender.Width;
            }
            else
            {
                pX = 0;
                PNL.Width = this.Width - sender.Width - 16;
            }
            PNL.Location = new Point(pX, 0);
            return PNL;
        }
        private Label CreateLabel(Button sender)
        {
            Label LBL = new Label();
            LBL.Name = "LBL" + sender.Name.Substring(1);

            if (sender.Name == "B_lang")
                LBL.Text = Main.resManager.GetString("User_Settings_Hover_Lang", Main.culInfo);
            else if (sender.Name == "B_fonts")
                LBL.Text = Main.resManager.GetString("User_Settings_Hover_Fonts", Main.culInfo);
            else
                LBL.Text = Main.resManager.GetString("User_Settings_Hover_Password", Main.culInfo);

            LBL.Font = new Font("Arial", 11, FontStyle.Bold);
            LBL.TextAlign = ContentAlignment.MiddleCenter;
            LBL.BackColor = BLUE;
            LBL.ForeColor = Color.White;

            LBL.Height = 28;
            LBL.Width = sender.Width;
            int pX = sender.Location.X;
            int pY = sender.Location.Y + sender.Height - LBL.Height;
            LBL.Location = new Point(pX, pY);

            return LBL;
        }

        private Image GetImage(string imgName)
        {
            object img = Properties.Resources.ResourceManager.GetObject(imgName);
            return (Image)img;
        }
    }
}
