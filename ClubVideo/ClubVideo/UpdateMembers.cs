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
    public partial class UpdateMembers : Form
    {
        BindingSource _bs;
        public UpdateMembers()
        {
            InitializeComponent();
        }

        public UpdateMembers(BindingSource source, string header)
        {
            InitializeComponent();
            Text = header;
            _bs = source;

            btn_Next.Visible = true;
            btn_Previous.Visible = true;
            btn_Add.Visible = false;

            foreach (var tb in this.Controls.OfType<TextBox>()) tb.ReadOnly = true;
            txb_Name.DataBindings.Add("text", _bs, "NAME");
            txb_LastName.DataBindings.Add("text", _bs, "LAST_NAME");
            txb_Adress.DataBindings.Add("text", _bs, "ADDRESS");
            txb_PostalCode.DataBindings.Add("text", _bs, "POSTALCODE");
            txb_City.DataBindings.Add("text", _bs, "CITY");
            txb_Province.DataBindings.Add("text", _bs, "PROVINCE");
            txb_Telephone.DataBindings.Add("text", _bs, "TELEPHONENUMBER").ToString();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            this.BindingContext[_bs].Position += 1;
        }

        private void btn_Previous_Click(object sender, EventArgs e)
        {
            this.BindingContext[_bs].Position -= 1;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
