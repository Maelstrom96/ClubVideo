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
    public partial class LocationLists : Form
    {
        private DataTable ds;
        public LocationLists()
        {
            InitializeComponent();
        }

        private void LocationLists_Load(object sender, EventArgs e)
        {
            Database.Update.Locations();
            ds = Database.GetData.Locations();

            BindingSource source = new BindingSource();
            source.DataSource = ds;
            dgv_Locations.DataSource = source;
            dgv_Locations.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
    }
}
