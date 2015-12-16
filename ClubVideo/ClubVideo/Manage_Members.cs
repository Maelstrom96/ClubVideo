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
        }

        private void SetButtonsVisibility()
        {
            if (!Modification_Mode)
            {
                btn_Add.Hide();
                btn_Delete.Hide();
                btn_Modify.Hide();
            }
        }

        private void LoadPermissions()
        {
            Button[] bt_Perms = { btn_Add, btn_Delete, btn_Modify };

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
            toolTip.SetToolTip(btn_Add, Main.resManager.GetString("Manage_Members_Add_Tip", Main.culInfo));
            toolTip.SetToolTip(btn_Modify, Main.resManager.GetString("Manage_Members_Modify_Tip", Main.culInfo));
            toolTip.SetToolTip(btn_Delete, Main.resManager.GetString("Manage_Members_Delete_Tip", Main.culInfo));
            toolTip.SetToolTip(tb_Search, Main.resManager.GetString("Manage_Members_Search_Tip", Main.culInfo));

            // DGV Columns headers
            foreach(DataGridViewColumn column in dgv_SearchResults.Columns)
            {
                column.HeaderText = Main.resManager.GetString("Manage_Members_" + column.Name, Main.culInfo);
            }

            // lb_Search text
            lb_Search.Text = Main.resManager.GetString("Manage_Members_Search", Main.culInfo);

            // Set tb_Search position relative to lb_Search
            int height_Diff = (tb_Search.Height - lb_Search.Height) / 2;
            SizeF width = lb_Search.CreateGraphics().MeasureString(lb_Search.Text, lb_Search.Font);
            tb_Search.Location = new Point(lb_Search.Location.X + (int)width.Width, lb_Search.Location.Y - height_Diff);
        }

        private void Search()
        {
            source.Filter = "CONVERT(ID, 'System.String') like '" + tb_Search.Text + "%'" +
                "or NAME like '" + tb_Search.Text + "%'" +
                "or LAST_NAME like '" + tb_Search.Text + "%'" +
                "or ADDRESS like '%" + tb_Search.Text + "%'" +
                "or POSTALCODE like '%" + tb_Search.Text + "%'" +
                "or CONVERT(TELEPHONENUMBER, 'System.String') like '%" + tb_Search.Text + "%'";

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
            Database_Connector.Delete.Member(int.Parse(dgv_SearchResults.SelectedRows[0].Cells[0].Value.ToString()));
            LoadMembers();
        }

        private void dgv_SearchResults_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_SearchResults.SelectedRows.Count == 1 && Modification_Mode && btn_Delete.Enabled) btn_Delete.Visible = true;
            else btn_Delete.Visible = false;
        }

        private void btn_Modify_Click(object sender, EventArgs e)
        {
            UpdateMembers members = new UpdateMembers(source, "Detail Membre", true);
            members.ShowDialog();
            LoadMembers();
        }
    }
}
