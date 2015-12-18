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
    public partial class ReturnLocation : Form
    {
        public ReturnLocation()
        {
            InitializeComponent();
        }

        private void ReturnLocation_Load(object sender, EventArgs e)
        {
            List<string> returnsList = Database.GetData.List("Rentals", "id");
            cb_Returns.Items.Clear();

            foreach (string returns in returnsList)
                cb_Returns.Items.Add(returns);
        }

        private void btn_Return_Click(object sender, EventArgs e)
        {
            try
            {
                Database_Connector.Update.Rentals(int.Parse(cb_Returns.Text));
                MessageBox.Show("Retour effectué!");
                Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
