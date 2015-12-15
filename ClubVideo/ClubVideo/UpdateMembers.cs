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

        public UpdateMembers(BindingSource source, string header, bool modif)
        {
            InitializeComponent();
            Text = header;
            _bs = source;
            if (!modif)
            {
                btn_Next.Visible = true;
                btn_Previous.Visible = true;
                btn_Add.Visible = false;
                foreach (var tb in this.Controls.OfType<TextBox>()) tb.ReadOnly = true;
            }
            if (modif)
            {
                btn_Modify.Visible = true;
                btn_Add.Visible = false;
            }
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
            try
            {
                MemberObject oMember = new MemberObject();
                oMember.Name = txb_Name.Text.ToString();
                oMember.LastName = txb_LastName.Text.ToString();
                oMember.Address = txb_Adress.Text.ToString();
                oMember.PostalCode = txb_PostalCode.Text.ToString();
                oMember.City = txb_City.Text.ToString();
                oMember.Province = txb_Province.Text.ToString();
                oMember.TelNumber = int.Parse(txb_Telephone.Text.ToString());
                Database_Connector.Insert.Member(oMember);
                MessageBox.Show("Ajout fait!");
                this.Close();
                
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
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

        private void btn_Modify_Click(object sender, EventArgs e)
        {
            try
            {
                MemberObject oMember = new MemberObject();
                oMember.Name = txb_Name.Text.ToString();
                oMember.LastName = txb_LastName.Text.ToString();
                oMember.Address = txb_Adress.Text.ToString();
                oMember.PostalCode = txb_PostalCode.Text.ToString();
                oMember.City = txb_City.Text.ToString();
                oMember.Province = txb_Province.Text.ToString();
                oMember.TelNumber = int.Parse(txb_Telephone.Text.ToString());
                Database_Connector.Insert.Member(oMember);
                MessageBox.Show("Modification fait!");
                this.Close();

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
