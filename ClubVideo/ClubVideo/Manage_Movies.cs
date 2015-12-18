using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
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
        private bool Modification_Mode;
        

        public Manage_Movies(bool Modification = false)
        {
            InitializeComponent();
            Database.Update.Movies();

            Modification_Mode = Modification;

            LoadMovies();
            LoadLanguage();
            if (Modification_Mode)
            {
                bt_AddMovie.Visible = true;
                bt_DeleteMovie.Visible = true;
                bt_EditMovie.Visible = true;
                btn_AddCopies.Visible = true;
                txb_CopiesToAdd.Visible = true;
            }
            Main.UpdateFonts(this);
            Main.RefreshColors(this);
        }

        private void LoadMovies()
        {
            ds = Database.GetData.Movies();
            source = new BindingSource();
            source.DataSource = ds;
            dgv_SearchResults.DataSource = source;
            dgv_SearchResults.Columns[9].Visible = false;
        }

        private void LoadLanguage()
        {
            // Header text
            if (Modification_Mode) Text = Main.resManager.GetString("Manage_Movies_Header_Modif", Main.culInfo);
            else Text = Main.resManager.GetString("Manage_Movies_Header", Main.culInfo);

            // DGV Column text
            foreach (DataGridViewColumn column in dgv_SearchResults.Columns)
                column.HeaderText = Main.resManager.GetString("Manage_Movies_" + column.Name, Main.culInfo);

            // lb_Search text
            lb_Search.Text = Main.resManager.GetString("Manage_Movies_Search", Main.culInfo);
        }

        private void LoadPermissions()
        {
            Button[] bt_Perms = { bt_AddMovie, bt_DeleteMovie, bt_EditMovie };

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

        private void Search()
        {
            source.Filter = "CONVERT(ID, 'System.String') like '" + tb_Search.Text + "%'" +
                            "or NAME_EN like '" + tb_Search.Text + "%'" +
                            "or NAME_FR like '" + tb_Search.Text + "%'" +
                            "or CONVERT(RELEASEDATE, 'System.String') like '%" + tb_Search.Text + "%'";
        }

        private MovieObject GetMovieFromSelectedRow()
        {
            foreach (DataGridViewRow row in dgv_SearchResults.SelectedRows)
            {
                MovieObject movie = new MovieObject();

                string date = row.Cells[6].Value.ToString();
                date = date.Substring(0, 10);

                movie.ID = int.Parse(row.Cells[0].Value.ToString());
                movie.Nom_en = row.Cells[1].Value.ToString();
                movie.Nom_fr = row.Cells[2].Value.ToString();
                movie.Description_en = row.Cells[3].Value.ToString();
                movie.Description_fr = row.Cells[4].Value.ToString();
                movie.Director = row.Cells[5].Value.ToString();
                movie.Date = DateTime.ParseExact(date, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                movie.Rated = row.Cells[7].Value.ToString();
                movie.Runtime = int.Parse(row.Cells[8].Value.ToString());

                var data = (Byte[])(row.Cells[9].Value);
                var stream = new MemoryStream(data);
                movie.Poster = Image.FromStream(stream);

                movie.Category = CategoryObject.GetCategoryID(row.Cells[11].Value.ToString());

                return movie;
            }

            return new MovieObject();
        }

        private void dgv_SearchResults_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(dgv_SearchResults.SelectedRows.Count  == 1)
            {
                InsertMovie movie = new InsertMovie(source, "Detail Film");
                movie.ShowDialog();
            }
        }

        private void tb_Search_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void btn_Modify_Click(object sender, EventArgs e)
        {
            InsertMovie movies = new InsertMovie(GetMovieFromSelectedRow(), "Modification de film");
            movies.ShowDialog();
            LoadMovies();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            Add_Movie_Menu Amm = new Add_Movie_Menu();
            DialogResult dr = Amm.ShowDialog();

            switch (dr)
            {
                case DialogResult.OK :
                    Database.Update.Movies();
                    LoadMovies();
                    break;
                default:
                    break;
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                Database_Connector.Delete.Movie(int.Parse(dgv_SearchResults.SelectedRows[0].Cells[0].Value.ToString()));
                LoadMovies();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_AddCopies_Click(object sender, EventArgs e)
        {
            if (txb_CopiesToAdd.Text != "")
            {
                for (int i = 0; i < int.Parse(txb_CopiesToAdd.Text.ToString()); ++i)
                {
                    Database_Connector.Insert.Copies(int.Parse(dgv_SearchResults.SelectedRows[0].Cells[0].Value.ToString()));
                }
                LoadMovies();
            }
        }

        private void bt_MouseEnter(object send, EventArgs e)
        {
            Button sender = (Button)send;
            sender.Image = Main.Img_ToWhite(sender.Name.Substring(3));
            sender.FlatAppearance.MouseOverBackColor = Main.GetColor();
            sender.ForeColor = Color.White;
        }

        private void bt_MouseLeave(object send, EventArgs e)
        {
            Button sender = (Button)send;
            sender.Image = Main.Img_ToColor(sender.Name.Substring(3), false);
            sender.FlatAppearance.MouseOverBackColor = Color.White;
            sender.ForeColor = Main.GetColor();
        }
    }
}
