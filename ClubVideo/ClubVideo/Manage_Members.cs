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
        

        public Manage_Members()
        {
            InitializeComponent();
            Database.Update.Members();
            LoadMembers();
        }

        private void LoadMembers()
        {
            ds = Database.GetData.Members();

            source = new BindingSource();
            source.DataSource = ds;
            dgv_SearchResults.DataSource = source;
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
                UpdateMembers members = new UpdateMembers(source, "Detail Membre");
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
            
        }

        private void dgv_SearchResults_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_SearchResults.SelectedRows.Count == 1) btn_Delete.Visible = true;
            else btn_Delete.Visible = false;
        }
    }
}
