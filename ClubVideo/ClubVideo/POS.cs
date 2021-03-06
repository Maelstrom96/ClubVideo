﻿using System;
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
    public partial class POS : Form
    {
        private BindingSource _bsMembers = new BindingSource();
        private DataTable dt;
        private BindingSource _bsMovies = new BindingSource();
        private BindingSource _bsCopies = new BindingSource();

        public POS()
        {
            InitializeComponent();
            cb_NbJours.SelectedIndex = 0;
            UpdateDB();
            LoadLanguage();
        }

        private void UpdateDB()
        {
            Database.Update.Movies();
            Database.Update.Copies();

            _bsMovies.DataSource = Database.GetData.Movies();
            _bsCopies.DataSource = Database.GetData.Copies();
        }

        private void txb_NameSearch_TextChanged(object sender, EventArgs e)
        {
            if (txb_NameSearch.Text != "")
            {
                dt = Database.GetData.Members();
                _bsMembers.DataSource = dt;
                dgv_Members.DataSource = _bsMembers;
            }
            else
                dgv_Members.DataSource = null;

            SearchMembers();
        }

        private void SearchMembers()
        {
            _bsMembers.Filter = "NAME like '" + txb_NameSearch.Text + "%'" +
                                "or LAST_NAME like '" + txb_NameSearch.Text + "%'";
        }

        private void SearchMovies()
        {
            _bsMovies.Filter = "CONVERT(ID, 'System.String') like '" + txb_MoviesSearch.Text + "%'" +
                               "or NAME_EN like '" + txb_MoviesSearch.Text + "%'" +
                               "or NAME_FR like '" + txb_MoviesSearch.Text + "%'";
        }

        private void txb_MoviesSearch_TextChanged(object sender, EventArgs e)
        {
            if (txb_MoviesSearch.Text != "")
            {
                dt = Database.GetData.Movies();
                _bsMovies.DataSource = dt;
                dgv_Movies.DataSource = _bsMovies;
                DeleteUnwantedRows();
            }
            else
            {
                dgv_Movies.DataSource = null;
                dgv_Copies.DataSource = null;
            }
            SearchMovies();
        }

        private void LoadLanguage()
        {
            Text = Main.resManager.GetString("POS_Header", Main.culInfo);

            lb_Film_Copies.Text = Main.resManager.GetString("POS_Film_Copies", Main.culInfo);
            lb_Search_Members.Text = Main.resManager.GetString("POS_Search_Members", Main.culInfo);
            lb_Search_Movies.Text = Main.resManager.GetString("POS_Search_Movies", Main.culInfo);
            lb_Nb_Days.Text = Main.resManager.GetString("POS_Nb_Days", Main.culInfo); 

            btn_Location.Text = Main.resManager.GetString("POS_Rent", Main.culInfo);
            btn_LocationList.Text = Main.resManager.GetString("POS_RentList", Main.culInfo);
        }

        private void dgv_Movies_DoubleClick(object sender, EventArgs e)
        {
            if (dgv_Movies.SelectedRows.Count == 1)
            {
                _bsCopies.Filter = "movie_id = '" + dgv_Movies.SelectedRows[0].Cells[0].Value + "'";
                dgv_Copies.DataSource = _bsCopies;
            }
        }

        private void DeleteUnwantedRows()
        {
            dgv_Movies.Columns[3].Visible = false;
            dgv_Movies.Columns[4].Visible = false;
            dgv_Movies.Columns[7].Visible = false;
            dgv_Movies.Columns[8].Visible = false;
            dgv_Movies.Columns[9].Visible = false;
        }

        private void btn_Return_Click(object sender, EventArgs e)
        {
            ReturnLocation oReturn = new ReturnLocation();
            oReturn.ShowDialog();
        }

        private void btn_LocationList_Click(object sender, EventArgs e)
        {
            LocationLists location = new LocationLists();
            location.ShowDialog();
        }

        private void btn_Location_Click(object sender, EventArgs e)
        {
            try
            {
                int memberID = int.Parse(dgv_Members.SelectedRows[0].Cells[0].Value.ToString());
                int copieID = int.Parse(dgv_Copies.SelectedRows[0].Cells[0].Value.ToString());
                int locationTime = int.Parse(cb_NbJours.SelectedItem.ToString());
                Database_Connector.Insert.Locations(memberID, copieID, locationTime);
                MessageBox.Show("Location faite!");
                UpdateDB();
            }
            catch(Exception ex){ MessageBox.Show(ex.Message); }
        }
    }
}
