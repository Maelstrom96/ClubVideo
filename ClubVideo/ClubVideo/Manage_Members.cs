using Oracle.DataAccess.Client;
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
    public partial class Manage_Members : Form
    {
        private BindingSource source;
        private DataTable ds;
        private bool Modification_Mode;

        public Manage_Members(bool Modification = false)
        {
            InitializeComponent();
            Modification_Mode = Modification;

            Database.Update.Members();
            LoadMembers();
            LoadLanguage();
            LoadPermissions();
            SetButtonsVisibility();
            Main.UpdateFonts(this);
            Main.RefreshColors(this);
        }

        private void SetButtonsVisibility()
        {
            if (!Modification_Mode)
            {
                bt_AddUser.Hide();
                bt_DeleteUsers.Hide();
                bt_EditUser.Hide();
                
            }
        }

        private void LoadPermissions()
        {
            Button[] bt_Perms = { bt_AddUser, bt_DeleteUsers, bt_EditUser };

            foreach (Button button in bt_Perms)
            {
                string PermString = Name.ToString() + '.' + button.Name.ToString();

                int index = PermString.IndexOf("btn_");
                string cleanPerm = (index < 0)
                    ? PermString
                    : PermString.Remove(index, 4);

                button.Enabled = Main.user.Permissions.HasPermission(cleanPerm);
                button.Visible = button.Enabled;
            }
        }

        private void LoadMembers()
        {
            ds = Database.GetData.Members();

            source = new BindingSource();
            source.DataSource = ds;
            dgv_SearchResults.DataSource = source;
        }

        private void LoadLanguage()
        {
            // Header text
            if (Modification_Mode) Text = Main.resManager.GetString("Manage_Members_Header_Modif", Main.culInfo);
            else Text = Main.resManager.GetString("Manage_Members_Header", Main.culInfo);

            // tooltips
            toolTip.SetToolTip(bt_AddUser, Main.resManager.GetString("Manage_Members_Add_Tip", Main.culInfo));
            toolTip.SetToolTip(bt_EditUser, Main.resManager.GetString("Manage_Members_Modify_Tip", Main.culInfo));
            toolTip.SetToolTip(bt_DeleteUsers, Main.resManager.GetString("Manage_Members_Delete_Tip", Main.culInfo));
            toolTip.SetToolTip(tb_Search, Main.resManager.GetString("Manage_Members_Search_Tip", Main.culInfo));
            toolTip.SetToolTip(lb_Search, Main.resManager.GetString("Manage_Members_Search_Tip", Main.culInfo));

            // DGV Columns headers
            foreach(DataGridViewColumn column in dgv_SearchResults.Columns)
            {
                column.HeaderText = Main.resManager.GetString("Manage_Members_" + column.Name, Main.culInfo);
            }

            // lb_Search text
            lb_Search.Text = Main.resManager.GetString("Manage_Members_Search", Main.culInfo);

            // Set tb_Search position relative to lb_Search
            //int height_Diff = (tb_Search.Height - lb_Search.Height) / 2;
            //SizeF width = lb_Search.CreateGraphics().MeasureString(lb_Search.Text, lb_Search.Font);
            //tb_Search.Location = new Point(lb_Search.Location.X + (int)width.Width, lb_Search.Location.Y - height_Diff);
        }

        private void Search()
        {
            source.Filter = "CONVERT(ID, 'System.String') like '" + tb_Search.Text + "%'" +
                "or NAME like '" + tb_Search.Text + "%'" +
                "or LAST_NAME like '" + tb_Search.Text + "%'" +
                "or ADDRESS like '%" + tb_Search.Text + "%'" +
                "or POSTALCODE like '%" + tb_Search.Text + "%'" +
                "or CONVERT(TELEPHONENUMBER, 'System.String') like '%" + tb_Search.Text + "%'"+
                "or PROVINCE like '%" + tb_Search.Text + "%'";

        }

        private void dgv_SearchResults_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dgv_SearchResults.SelectedRows.Count == 1)
            {
                UpdateMembers members = new UpdateMembers(source, "Detail Membre", false);
                members.Show();
            }
        }

        private void tb_Search_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            UpdateMembers members = new UpdateMembers();
            members.ShowDialog();
            LoadMembers();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                Database_Connector.Delete.Member(int.Parse(dgv_SearchResults.SelectedRows[0].Cells[0].Value.ToString()));
                LoadMembers();
            }
            catch(OracleException sqle) 
            {
                switch (sqle.Number)
                {
                    case 02292:
                        MessageBox.Show("CANNOT_DELETE_CHILD_FOUND");
                        break;
                    default: MessageBox.Show(sqle.Message.ToString());
                        break;          
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgv_SearchResults_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_SearchResults.SelectedRows.Count == 1 && Modification_Mode && bt_DeleteUsers.Enabled) bt_DeleteUsers.Visible = true;
            else bt_DeleteUsers.Visible = false;
        }

        private void btn_Modify_Click(object sender, EventArgs e)
        {
            UpdateMembers members = new UpdateMembers(source, "Detail Membre", true);
            members.ShowDialog();
            LoadMembers();
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
