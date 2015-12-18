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
                btn_Add.Visible = true;
                btn_Delete.Visible = true;
                btn_Modify.Visible = true;
            }
            Main.UpdateFonts(this);
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
            {
                column.HeaderText = Main.resManager.GetString("Manage_Movies_" + column.Name, Main.culInfo);
            }

            // lb_Search text
            lb_Search.Text = Main.resManager.GetString("Manage_Movies_Search", Main.culInfo);

            // Set tb_Search position relative to lb_Search
            int height_Diff = (tb_Search.Height - lb_Search.Height) / 2;
            SizeF width = lb_Search.CreateGraphics().MeasureString(lb_Search.Text, lb_Search.Font);
            tb_Search.Location = new Point(lb_Search.Location.X + (int)width.Width, lb_Search.Location.Y - height_Diff);
        }

        private void LoadPermissions()
        {
            Button[] bt_Perms = { btn_Add, btn_Delete, btn_Modify };

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
            InsertMovie movies = new InsertMovie(source, "Modification de film", true);
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
            Database_Connector.Delete.Movie(int.Parse(dgv_SearchResults.SelectedRows[0].Cells[0].Value.ToString()));
            LoadMovies();
        }
    }
}
