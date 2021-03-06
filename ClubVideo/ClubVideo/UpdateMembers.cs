﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubVideo
{
    public partial class UpdateMembers : Form
    {
        BindingSource _bs;
        private string _caZipRegEx = @"^([ABCDEFGHIJKLMNOPQRSTUVWXYZ]\d[ABCDEFGHIJKLMNOPQRSTUVWXYZ])\ {0,1}(\d[ABCDEFGHIJKLMNOPQRSTUVWXYZ]\d)$";
        private string[] lineOfContents = File.ReadAllLines("../../Resources/Provinces.txt");

        public UpdateMembers()
        {
            InitializeComponent();
            foreach (var line in lineOfContents)
            {
                string[] tokens = line.Split(',');
                cb_Provinces.Items.Add(tokens[0]);
            }
            Main.UpdateFonts(this);
            LoadLanguage();
        }

        public UpdateMembers(BindingSource source, string header, bool modif)
        {
            InitializeComponent();
            Text = header;
            _bs = source;

            foreach (var line in lineOfContents)
            {
                string[] tokens = line.Split(',');
                cb_Provinces.Items.Add(tokens[0]);
            }
            if (!modif)
            {
                btn_Next.Visible = true;
                btn_Previous.Visible = true;
                btn_Add.Visible = false;
                foreach (var tb in this.Controls.OfType<TextBox>()) tb.ReadOnly = true;
                cb_Provinces.Enabled = false;
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
            cb_Provinces.DataBindings.Add("text", _bs, "PROVINCE");
            txb_Telephone.DataBindings.Add("text", _bs, "TELEPHONENUMBER").ToString();

            LoadLanguage();
        }

        private void LoadLanguage()
        {
            this.Text = Main.resManager.GetString("Update_Members_Header", Main.culInfo);
            lb_Name.Text = Main.resManager.GetString("Update_Members_NAME", Main.culInfo);
            lb_LastName.Text = Main.resManager.GetString("Update_Members_LASTNAME", Main.culInfo);
            lb_PhoneNumber.Text = Main.resManager.GetString("Update_Members_PHONE", Main.culInfo);
            lb_Address.Text = Main.resManager.GetString("Update_Members_ADDRESS", Main.culInfo);
            lb_PostalCode.Text = Main.resManager.GetString("Update_Members_POSTALCODE", Main.culInfo);
            lb_City.Text = Main.resManager.GetString("Update_Members_CITY", Main.culInfo);
            lb_Province.Text = Main.resManager.GetString("Update_Members_PROVINCE", Main.culInfo);

            btn_Add.Text = Main.resManager.GetString("Update_Members_ADD", Main.culInfo);
            btn_Modify.Text = Main.resManager.GetString("Update_Members_MODIFY", Main.culInfo);
            btn_Cancel.Text = Main.resManager.GetString("Update_Members_CANCEL", Main.culInfo);
            btn_Previous.Text = Main.resManager.GetString("Update_Members_PREVIOUS", Main.culInfo);
            btn_Next.Text = Main.resManager.GetString("Update_Members_NEXT", Main.culInfo);
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                MemberObject oMember = new MemberObject();
                oMember.Name = txb_Name.Text.ToString();
                oMember.LastName = txb_LastName.Text.ToString();
                oMember.Address = txb_Adress.Text.ToString();
                oMember.PostalCode = txb_PostalCode.Text.ToString().ToUpper();
                oMember.City = txb_City.Text.ToString();
                oMember.Province = cb_Provinces.Text.ToString();
                oMember.TelNumber = txb_Telephone.Text.ToString();
                if (!IsCanadianZipCode(oMember.PostalCode))
                    throw new Exception("Le code postal est invalide. Le format est A8A8A8");
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
                oMember.ID = int.Parse(((DataRowView)this._bs.Current).Row["ID"].ToString());
                oMember.Name = txb_Name.Text.ToString();
                oMember.LastName = txb_LastName.Text.ToString();
                oMember.Address = txb_Adress.Text.ToString();
                oMember.PostalCode = txb_PostalCode.Text.ToString().ToUpper();
                oMember.City = txb_City.Text.ToString();
                oMember.Province = cb_Provinces.Text.ToString();
                oMember.TelNumber = txb_Telephone.Text.ToString();
                Database_Connector.Update.Member(oMember);
                MessageBox.Show("Modification fait!");
                this.Close();

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void txb_Telephone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                e.Handled = true;
        }

        private bool IsCanadianZipCode(string zipCode)
        {
            bool validZipCode = true;
            if (!Regex.Match(zipCode, _caZipRegEx).Success)
            {
                validZipCode = false;
            }
            return validZipCode;
        }
    }
}
