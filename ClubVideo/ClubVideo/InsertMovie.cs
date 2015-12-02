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
    public partial class InsertMovie : Form
    {
        bool edit;
        MovieObject movie;
        MovieObject finalMovie;

        public InsertMovie(MovieObject movie_)
        {
            if (movie_ == null) movie = new MovieObject();
            else movie = movie_;

            edit = true;

            InitializeComponent();

            LoadText();
        }

        private void LoadText()
        {
            pictureBox1.Image = movie.Poster;
            lb_TitreEN.Text = movie.Nom_en;
            lb_TitreFR.Text = movie.Nom_fr;
            lb_DescEN.Text = movie.Description_en;
            lb_DescFR.Text = movie.Description_fr;
            lb_Rating.Text = movie.Rated;
            lb_Time.Text = movie.Runtime;
            lb_Director.Text = movie.Director;
            lb_Date.Text = movie.Year;
        }

        private void SaveFinalMovie()
        {
            finalMovie = new MovieObject();
            finalMovie.Poster = pictureBox1.Image;
            finalMovie.Nom_en = lb_TitreEN.Text;
            finalMovie.Nom_fr = lb_TitreFR.Text;
            finalMovie.Description_en = lb_DescEN.Text;
            finalMovie.Description_fr = lb_DescFR.Text;
            finalMovie.Rated = lb_Rating.Text;
            finalMovie.Runtime = lb_Time.Text;
            finalMovie.Director = lb_Director.Text;
        }

        private void InsertMovie_Load(object sender, EventArgs e)
        {

        }

        private void EditLabel_OnClick(object sender, EventArgs e)
        {
            if (edit)
            {
                System.Windows.Forms.TextBox TBTemp = new System.Windows.Forms.TextBox();
                Label lb = (Label)sender;
                lb.Hide();

                TBTemp.Location = lb.Location;
                TBTemp.Text = lb.Text;
                TBTemp.Font = lb.Font;
                TBTemp.Size = lb.Size;
                TBTemp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EditTextBox_Finish);
                TBTemp.LostFocus += new System.EventHandler(EditTextBox_LostFocus);
                TBTemp.Multiline = true;
                TBTemp.ScrollBars = ScrollBars.Vertical;

                int index = lb.Name.IndexOf("lb_");
                string cleanName = (index < 0)
                    ? lb.Name
                    : lb.Name.Remove(index, 3);

                TBTemp.Name = cleanName;

                this.Controls.Add(TBTemp);
                TBTemp.Focus();
                TBTemp.Select(TBTemp.Text.Length, 0);
            }
        }

        private void EditTextBox_LostFocus(object sender, EventArgs e)
        {
            EditTextBox_Finish(sender, new KeyEventArgs(Keys.Enter));
        }

        private void EditTextBox_Finish(object sender, KeyEventArgs e)
        {
            if (edit)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    TextBox tb = (TextBox)sender;
                    Label lb = (Label)Controls.Find("lb_" + tb.Name, true).ElementAt(0);
                    lb.Text = tb.Text;
                    lb.Show();
                    Controls.Remove(tb);
                }
            }
        }

        private void InsertMovie_Click(object sender, EventArgs e)
        {
            Focus();
        }
    }
}
