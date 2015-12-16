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
    public partial class Add_Movie_Menu : Form
    {
        public Add_Movie_Menu()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            if (rb.Checked)
            {
                MoveItemsForm();

                lb_Url.Show();
                tb_Url.Show();

                tb_Url.Focus();
            }
            else
            {
                MoveItemsForm(false);

                lb_Url.Hide();
                tb_Url.Hide();
            }
        }

        private void MoveItemsForm(bool Down = true)
        {
            int Deplacement = 20; // Define the movement

            if (!Down) Deplacement *= -1;

            // Move
            rb_Manual.Location = new Point(rb_Manual.Location.X, rb_Manual.Location.Y + Deplacement);
            //lb_Url.Location = new Point(lb_Url.Location.X, lb_Url.Location.Y + Deplacement);
            bt_Cancel.Location = new Point(bt_Cancel.Location.X, bt_Cancel.Location.Y + Deplacement);
            bt_OK.Location = new Point(bt_OK.Location.X, bt_OK.Location.Y + Deplacement);

            Height += Deplacement;
        }

        private void ImportFromIMDB()
        {
            string URL = tb_Url.Text;
            string id;
            int IndexIDStart;
            int IndexIDEnd;

            IndexIDStart = URL.IndexOf("/title/") + 7;
            if (IndexIDStart == -1) throw new Exception("IMDB_ID_NOT_FOUND");

            IndexIDEnd = URL.IndexOf("/", IndexIDStart);

            if (IndexIDEnd == -1 && URL.IndexOf("tt") == 0) id = URL;
            else if (IndexIDEnd != -1) id = URL.Substring(IndexIDStart, IndexIDEnd - IndexIDStart);
            else throw new Exception("ID_FORMAT_INVALID");

            Database_Connector.Insert.Movie(Database_Connector.GetFromIMDB(id));
        }

        private void bt_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void bt_OK_Click(object sender, EventArgs e)
        {
            if (rb_IMDB.Checked)
            {
                try
                {
                    ImportFromIMDB();
                    MessageBox.Show("MOVIE_IMPORT_SUCCESS");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {

            }
        }
    }
}
