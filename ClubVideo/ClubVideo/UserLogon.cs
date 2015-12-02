using System;
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
    public partial class UserLogon : Form
    {
        public UserLogon()
        {
            DialogResult = DialogResult.Abort;

            InitializeComponent();

            InitText();
        }

        private void InitText()
        {
            // tb_Username
            tb_Username.Text = Main.resManager.GetString("UserLogon_Username", Main.culInfo);
            tb_Username.ForeColor = SystemColors.ControlLight;

            // tb_Password
            tb_Password.Text = Main.resManager.GetString("UserLogon_Password", Main.culInfo);
            tb_Password.ForeColor = SystemColors.ControlLight;

            // bt_Login
            bt_Login.Text = Main.resManager.GetString("UserLogon_LoginButton", Main.culInfo);

            // Header
            Text = Main.resManager.GetString("UserLogon_Header", Main.culInfo);
        }

        public void tb_Password_RemoveText(object sender, EventArgs e)
        {
            tb_Password.Text = "";
            tb_Password.ForeColor = Color.Black;
            tb_Password.PasswordChar = '●';
        }

        public void tb_Password_AddText(object sender, EventArgs e)
        {
            if (tb_Password.Text == "")
            {
                tb_Password.Text = Main.resManager.GetString("UserLogon_Password", Main.culInfo);
                tb_Password.ForeColor = SystemColors.ControlLight;
                tb_Password.PasswordChar = '\0';
            }

        }

        public void tb_Username_RemoveText(object sender, EventArgs e)
        {
            tb_Username.Text = "";
            tb_Username.ForeColor = Color.Black;
        }

        public void tb_Username_AddText(object sender, EventArgs e)
        {
            if (tb_Username.Text == "")
            {
                tb_Username.Text = Main.resManager.GetString("UserLogon_Username", Main.culInfo);
                tb_Username.ForeColor = SystemColors.ControlLight;
            }

        }

        private void Login_Click(object sender, EventArgs e)
        {
            Main.user = new User();
            if (Main.user.Login(tb_Username.Text, tb_Password.Text))
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            else MessageBox.Show(Main.resManager.GetString("UserLogon_BadLogin", Main.culInfo));
        }

        private void textbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login_Click(this, new EventArgs());
            }
        }
    }
}
