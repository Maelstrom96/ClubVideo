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
        BindingSource source;
        DataTable ds;
        

        public Manage_Members()
        {
            InitializeComponent();
            Database.Update.Members();
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
                "or ADRESS like '%" + tb_Search.Text + "%'" +
                "or POSTALCODE like '%" + tb_Search.Text + "%'" +
                "or CONVERT(TELEPHONENUMBER, 'System.String') like '%" + tb_Search.Text + "%'";
        }

        private void dgv_SearchResults_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dgv_SearchResults.SelectedRows.Count == 1)
            {
                InsertMovie movie = new InsertMovie(source, "Detail Membre");
                movie.Show();
            }
        }

        private void tb_Search_TextChanged(object sender, EventArgs e)
        {
            Search();
        }
    }
}
