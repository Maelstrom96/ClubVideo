﻿using System;
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
            Main.RefreshColors(this);
            Main.UpdateFonts(this);
        }

        private void bt_Back_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LoadLanguage()
        {
            bt_Back.Text = Main.resManager.GetString("Button_Admin_Menu_Back", Main.culInfo);
            bt_ManageUsers.Text = Main.resManager.GetString("Button_Admin_Menu_ManageUsers", Main.culInfo);
            bt_Settings.Text = Main.resManager.GetString("Button_Admin_Menu_Settings", Main.culInfo);
            bt_ManageCategories.Text = Main.resManager.GetString("Button_Admin_Menu_ManageCategories", Main.culInfo);
            bt_ManageGroups.Text = Main.resManager.GetString("Button_Admin_Menu_ManageGroups", Main.culInfo);
            bt_ManageMembers.Text = Main.resManager.GetString("Button_Admin_Menu_ManageMembers", Main.culInfo);
            bt_ManageMovies.Text = Main.resManager.GetString("Button_Admin_Menu_ManageMovies", Main.culInfo);
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

        private void bt_MouseEnter(object send, EventArgs e)
        {
            Button sender = (Button)send;
            sender.Image = Main.Img_ToWhite(sender.Name.Substring(3));
            sender.FlatAppearance.MouseOverBackColor = Main.GetColor();
            sender.ForeColor = Color.White;
        }

        private void bt_MouseLeave(object send, EventArgs e)
        {
            Button sender = (Button)send;
            sender.Image = Main.Img_ToColor(sender.Name.Substring(3), false);
            sender.FlatAppearance.MouseOverBackColor = Color.White;
            sender.ForeColor = Main.GetColor();
        }
    }
}
