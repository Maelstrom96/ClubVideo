using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
        BindingSource _bs;

        public InsertMovie(MovieObject movie_, string Header, bool _edit = true)
        {
            InitializeComponent();

            if (movie_ == null) movie = new MovieObject();
            else movie = movie_;

            edit = _edit;
            Text = Header;

            LoadText();
            LoadLanguage();
            LoadCategories();

            this.Height += 30;
            btn_Modify.Location = new Point(lb_DescFR.Location.X + 350, lb_DescFR.Location.Y + 130);
            btn_Modify.Visible = true;

            SetLabelCursor(System.Windows.Forms.Cursors.IBeam);

            dtp.Format = DateTimePickerFormat.Custom;
            dtp.CustomFormat = "dd/MM/yyyy";

            // Text Hide
            lb_Category_Value.Hide();
            lb_Date.Hide();
        }

        // Constructeur lors de la visualisation DGV
        public InsertMovie(BindingSource bs, string Header)
        {
            InitializeComponent();
            LoadLanguage();

            _bs = bs;
            Text = Header;

            lb_TitreEN.DataBindings.Add("text", bs, "NAME_EN");
            lb_TitreFR.DataBindings.Add("text", bs, "NAME_FR");
            lb_DescEN.DataBindings.Add("text", bs, "DESCRIPTION_EN");
            lb_DescFR.DataBindings.Add("text", bs, "DESCRIPTION_FR");
            lb_Rating.DataBindings.Add("text", bs, "RATING");
            //dtp.DataBindings.Add("Value", bs, "RELEASEDATE", true);
            lb_Date.DataBindings.Add("text", bs, "RELEASEDATE", true);
            lb_Time.DataBindings.Add("text", bs, "RUNTIME");
            lb_Director.DataBindings.Add("text", bs, "DIRECTORS");
            pictureBox1.DataBindings.Add("image", bs, "IMAGE", true);

            CultureInfo tmp = CultureInfo.CreateSpecificCulture("fr");
            // FR
            if (Main.culInfo.Equals(tmp))
                lb_Category_Value.DataBindings.Add("text", _bs, "CATEGORY_FR");
            // EN
            else
                lb_Category_Value.DataBindings.Add("text", _bs, "CATEGORY_EN");

            btn_Next.Location = new Point(lb_DescFR.Location.X + 250, lb_DescFR.Location.Y + 130);
            btn_Previous.Location = new Point(lb_DescFR.Location.X + 175, lb_DescFR.Location.Y + 130);
            btn_Next.Visible = true;
            btn_Previous.Visible = true;

            SetLabelCursor(System.Windows.Forms.Cursors.Default);

            // Hide
            dtp.Hide();
            cb_Categories.Hide();
        }

        private void LoadLanguage()
        {
            lb_Category.Text = Main.resManager.GetString("Manage_Movies_Category", Main.culInfo);
        }

        private void SetLabelCursor(System.Windows.Forms.Cursor cursormode)
        {
            lb_TitreEN.Cursor = cursormode;
            lb_TitreFR.Cursor = cursormode;
            lb_Rating.Cursor = cursormode;
            lb_Time.Cursor = cursormode;
            lb_DescFR.Cursor = cursormode;
            lb_Director.Cursor = cursormode;
        }

        private void LoadText()
        {
            try
            {
                pictureBox1.Image = movie.Poster;
                lb_TitreEN.Text = movie.Nom_en;
                lb_TitreFR.Text = movie.Nom_fr;
                lb_DescEN.Text = movie.Description_en;
                lb_DescFR.Text = movie.Description_fr;
                lb_Rating.Text = movie.Rated;
                lb_Time.Text = movie.Runtime.ToString();
                lb_Director.Text = movie.Director;
                dtp.Text = movie.Date.ToString("dd/MM/yyyy");
                cb_Categories.Text = CategoryObject.GetCategoryName(movie.Category);
            }
            catch(Exception)
            {

            }
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
            finalMovie.Runtime = int.Parse(lb_Time.Text);
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
                TBTemp.Size = new Size(lb.Size.Width + 10, lb.Size.Height + 5);
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

        private void LoadCategories()
        {
            List<string> CategoriesList = Database.GetData.List("Categories", Main.resManager.GetString("Add_Movie_Menu_Category_Column", Main.culInfo));

            cb_Categories.Items.Clear();

            foreach (string category in CategoriesList)
            {
                cb_Categories.Items.Add(category);
            }
        }

        private void InsertMovie_Click(object sender, EventArgs e)
        {
            Focus();
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            this.BindingContext[_bs].Position += 1;
        }

        private void btn_Previous_Click(object sender, EventArgs e)
        {
            this.BindingContext[_bs].Position -= 1;
        }

        private void btn_Modify_Click(object sender, EventArgs e)
        {
            try
            {
                MovieObject oMovie = new MovieObject();
                oMovie.Category = CategoryObject.GetCategoryID(cb_Categories.Text);
                oMovie.ID = movie.ID;
                oMovie.Nom_en = lb_TitreEN.Text.ToString();
                oMovie.Nom_fr = lb_TitreFR.Text.ToString();
                oMovie.Description_fr = lb_DescFR.Text.ToString();
                oMovie.Description_en = lb_DescEN.Text.ToString();
                //oMovie.Date = DateTime.ParseExact(date, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                oMovie.Date = DateTime.ParseExact(dtp.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                oMovie.Rated = lb_Rating.Text.ToString();
                oMovie.Runtime = int.Parse(lb_Time.Text.ToString());
                oMovie.Director = lb_Director.Text.ToString();
                oMovie.Poster= pictureBox1.Image;
                Database_Connector.Update.Movie(oMovie);
                MessageBox.Show("Modification fait!");

                this.Close();

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
