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
    public partial class Manage_Movies : Form
    {
        BindingSource source;
        DataTable ds;
        

        public Manage_Movies()
        {
            InitializeComponent();
            Database.Update.Movies();
            ds = Database.GetData.Movies();
            source = new BindingSource();
            source.DataSource = ds;
            dgv_SearchResults.DataSource = source;
            dgv_SearchResults.Columns[8].Visible = false;
            
        }

        private void Search()
        {
            source.Filter = "CONVERT(ID, 'System.String') like '" + tb_Search.Text + "%'" +
                "or NAME_EN like '" + tb_Search.Text + "%'" +
                "or NAME_FR like '" + tb_Search.Text + "%'" +
                "or DESCRIPTION_EN like '%" + tb_Search.Text + "%'" +
                "or DESCRIPTION_FR like '%" + tb_Search.Text + "%'" +
                "or CONVERT(RELEASEDATE, 'System.String') like '%" + tb_Search.Text + "%'";
        }

        private void dgv_SearchResults_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(dgv_SearchResults.SelectedRows.Count  == 1)
            {
                InsertMovie movie = new InsertMovie(source, "Detail Film");
                movie.Show();
            }
        }

        private void tb_Search_TextChanged(object sender, EventArgs e)
        {
            Search();
        }
    }
}
