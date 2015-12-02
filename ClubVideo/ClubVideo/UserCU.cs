using ClubVideo.Properties;
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
    public partial class UserCU : Form
    {
        /// <summary>
        /// Enter Adding Mode.
        /// </summary>
        public UserCU()
        {
            InitializeComponent();
            LoadLanguage();

            Text = Main.resManager.GetString("UserCU_Header_Add", Main.culInfo);
        }

        /// <summary>
        /// Enter Modification Mode.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="username"></param>
        /// <param name="name"></param>
        /// <param name="lastName"></param>
        public UserCU(int id, string username, string name, string lastName) : this()
        {
            tb_Username.Text = username;
            tb_Name.Text = name;
            tb_LastName.Text = lastName;
            lb_ResetPassword.Visible = true;
            lb_ResetPassword.Show();

            bt_Finish.BackgroundImage = ClubVideo.Properties.Resources.Edit_User;

            Text = Main.resManager.GetString("UserCU_Header_Modify", Main.culInfo);
        }

        private void LoadLanguage()
        {
            lb_ResetPassword.Text = Main.resManager.GetString("UserCU_ResetPassword", Main.culInfo);
            lb_Username.Text = Main.resManager.GetString("UserCU_Username", Main.culInfo);
            lb_Name.Text = Main.resManager.GetString("UserCU_Name", Main.culInfo);
            lb_LastName.Text = Main.resManager.GetString("UserCU_LastName", Main.culInfo);
            lb_Password.Text = Main.resManager.GetString("UserCU_Password", Main.culInfo);
            lb_ConfPassword.Text = Main.resManager.GetString("UserCU_ConfPassword", Main.culInfo);
        }
    }
}
