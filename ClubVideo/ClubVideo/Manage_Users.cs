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
    public partial class Manage_Users : Form
    {
        private BindingSource bs_Users;

        public Manage_Users()
        {
            InitializeComponent();

            LoadUsers();
            LoadLanguage();
        }

        private void LoadLanguage()
        {
            // ID DGV
            dgv_Users.Columns[0].HeaderText = Main.resManager.GetString("Manage_Users_ID", Main.culInfo);
            // Username DGV
            dgv_Users.Columns[1].HeaderText = Main.resManager.GetString("Manage_Users_Username", Main.culInfo);
            // Name DGV
            dgv_Users.Columns[2].HeaderText = Main.resManager.GetString("Manage_Users_Name", Main.culInfo);
            // Last Name SGV
            dgv_Users.Columns[3].HeaderText = Main.resManager.GetString("Manage_Users_LastName", Main.culInfo);
        }

        private void LoadUsers()
        {
            DataTable db_Users = Database.GetData.Users();

            bs_Users = new BindingSource();
            bs_Users.DataSource = db_Users;
            dgv_Users.DataSource = bs_Users;
        }

        private void bt_AddUser_Click(object sender, EventArgs e)
        {
            UserCU AddUser_Form = new UserCU();
            AddUser_Form.ShowDialog();

            LoadUsers();
        }

        private void bt_EditUser_Click(object sender, EventArgs e)
        {
            if (dgv_Users.SelectedRows.Count == 1)
            {
                int id = int.Parse(dgv_Users.SelectedRows[0].Cells[0].Value.ToString());
                string username = dgv_Users.SelectedRows[0].Cells[1].Value.ToString();
                string name = dgv_Users.SelectedRows[0].Cells[2].Value.ToString();
                string lastName = dgv_Users.SelectedRows[0].Cells[3].Value.ToString();

                UserCU ModifyUser_Form = new UserCU(id, username, name, lastName);
                ModifyUser_Form.ShowDialog();

                LoadUsers();
            }
        }

        private void dgv_Users_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_Users.SelectedRows.Count > 1) bt_EditUser.Enabled = false;
            else bt_EditUser.Enabled = true;
        }

        private void bt_DeleteUsers_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in dgv_Users.SelectedRows)
            {
                if (row.Cells[0].Value.ToString() != Main.user.ID.ToString())
                    Database_Connector.Delete.User(int.Parse(row.Cells[0].Value.ToString()));
                else
                    MessageBox.Show("You can't delete yourself!"); // LANGUAGE SUPPORT TODO
            }
            LoadUsers();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            bs_Users.Filter = "CONVERT(ID, 'System.String') like '" + 
                tb_Search.Text + "%' or USERNAME like '" + tb_Search.Text + "%' or NAME like '" +
                tb_Search.Text + "%' or LASTNAME like '" + tb_Search.Text + "%'";
        }


    }
}
