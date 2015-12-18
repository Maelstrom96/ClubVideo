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
            Main.UpdateFonts(this);
            Main.RefreshColors(this);
            bt_GroupsEdit.Enabled = false;
            UpdateHeight();
            LoadPermissions();
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

            Text = Main.resManager.GetString("Manage_Users_Header", Main.culInfo);
            lb_SearchUser.Text = Main.resManager.GetString("Manage_Users_Search", Main.culInfo);
        }

        private void UpdateHeight()
        {
            int dgvHeight = (dgv_Users.ColumnHeadersVisible ? dgv_Users.ColumnHeadersHeight : 0) +
              dgv_Users.Rows.OfType<DataGridViewRow>().Where(r => r.Visible).Sum(r => r.Height);

            //dgv_Users.Height = dgvHeight + 3;

            this.Height = 39 + dgv_Users.Location.Y + dgvHeight < 600 ? 39 + dgv_Users.Location.Y + dgvHeight : 600;
        }

        private void LoadUsers()
        {
            DataTable db_Users = Database.GetData.Users();

            bs_Users = new BindingSource();
            bs_Users.DataSource = db_Users;
            dgv_Users.DataSource = bs_Users;
            dgv_Users.Columns[3].Width = (int)(dgv_Users.Columns[0].Width * 1.5);
            dgv_Users.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void LoadPermissions()
        {
            Button[] bt_Perms = { bt_AddUser, bt_DeleteUsers, bt_EditUser, bt_GroupsEdit, bt_PermsEdit };

            foreach (Button button in bt_Perms)
            {
                string PermString = Name.ToString() + '.' + button.Name.ToString();

                int index = PermString.IndexOf("bt_");
                string cleanPerm = (index < 0)
                    ? PermString
                    : PermString.Remove(index, 3);

                button.Enabled = Main.user.Permissions.HasPermission(cleanPerm);
                button.Visible = button.Enabled;
            }
        }

        private void bt_AddUser_Click(object sender, EventArgs e)
        {
            UserCU AddUser_Form = new UserCU();
            AddUser_Form.ShowDialog();

            LoadUsers();
            UpdateHeight();
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
            UpdateHeight();
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

        private void bt_PermsEdit_Click(object sender, EventArgs e)
        {
            try
            {
                int userid = int.Parse(dgv_Users.SelectedRows[0].Cells[0].Value.ToString());

                if (userid == Main.user.ID) throw new Exception("You can't change your own permissions!");

                List<string> perms = Database.GetData.List("Permissions", "Permission");
                List<string> userPerms = Database_Connector.Select.UserPermissions(userid);

                SidebySideSelection sbs_Form = new SidebySideSelection(perms, userPerms, "Users Permissions Edit");
                DialogResult dr = sbs_Form.ShowDialog();

                if (dr == DialogResult.OK)
                {
                    if (sbs_Form.AddedList.Count > 0)
                        Database_Connector.Insert.UserPermissions(userid, sbs_Form.AddedList);
                    if (sbs_Form.DeletedList.Count > 0)
                        Database_Connector.Delete.UserPermissions(userid, sbs_Form.DeletedList);
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
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
