namespace ClubVideo
{
    partial class POS
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgv_Movies = new System.Windows.Forms.DataGridView();
            this.txb_NameSearch = new System.Windows.Forms.TextBox();
            this.lb_Search_Members = new System.Windows.Forms.Label();
            this.dgv_Members = new System.Windows.Forms.DataGridView();
            this.lb_Search_Movies = new System.Windows.Forms.Label();
            this.txb_MoviesSearch = new System.Windows.Forms.TextBox();
            this.btn_Return = new System.Windows.Forms.Button();
            this.cb_NbJours = new System.Windows.Forms.ComboBox();
            this.btn_Location = new System.Windows.Forms.Button();
            this.dgv_Copies = new System.Windows.Forms.DataGridView();
            this.lb_Nb_Days = new System.Windows.Forms.Label();
            this.btn_LocationList = new System.Windows.Forms.Button();
            this.lb_Film_Copies = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Movies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Members)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Copies)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Movies
            // 
            this.dgv_Movies.AllowUserToAddRows = false;
            this.dgv_Movies.AllowUserToDeleteRows = false;
            this.dgv_Movies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Movies.Location = new System.Drawing.Point(12, 154);
            this.dgv_Movies.Name = "dgv_Movies";
            this.dgv_Movies.ReadOnly = true;
            this.dgv_Movies.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Movies.Size = new System.Drawing.Size(660, 150);
            this.dgv_Movies.TabIndex = 0;
            this.dgv_Movies.DoubleClick += new System.EventHandler(this.dgv_Movies_DoubleClick);
            // 
            // txb_NameSearch
            // 
            this.txb_NameSearch.Location = new System.Drawing.Point(144, 16);
            this.txb_NameSearch.Name = "txb_NameSearch";
            this.txb_NameSearch.Size = new System.Drawing.Size(100, 20);
            this.txb_NameSearch.TabIndex = 1;
            this.txb_NameSearch.TextChanged += new System.EventHandler(this.txb_NameSearch_TextChanged);
            // 
            // lb_Search_Members
            // 
            this.lb_Search_Members.Location = new System.Drawing.Point(16, 19);
            this.lb_Search_Members.Name = "lb_Search_Members";
            this.lb_Search_Members.Size = new System.Drawing.Size(122, 13);
            this.lb_Search_Members.TabIndex = 2;
            this.lb_Search_Members.Text = "Customer Name";
            this.lb_Search_Members.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dgv_Members
            // 
            this.dgv_Members.AllowUserToAddRows = false;
            this.dgv_Members.AllowUserToDeleteRows = false;
            this.dgv_Members.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Members.Location = new System.Drawing.Point(12, 39);
            this.dgv_Members.Name = "dgv_Members";
            this.dgv_Members.ReadOnly = true;
            this.dgv_Members.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Members.Size = new System.Drawing.Size(660, 83);
            this.dgv_Members.TabIndex = 3;
            // 
            // lb_Search_Movies
            // 
            this.lb_Search_Movies.Location = new System.Drawing.Point(19, 134);
            this.lb_Search_Movies.Name = "lb_Search_Movies";
            this.lb_Search_Movies.Size = new System.Drawing.Size(119, 13);
            this.lb_Search_Movies.TabIndex = 5;
            this.lb_Search_Movies.Text = "Film a louer";
            this.lb_Search_Movies.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txb_MoviesSearch
            // 
            this.txb_MoviesSearch.Location = new System.Drawing.Point(144, 131);
            this.txb_MoviesSearch.Name = "txb_MoviesSearch";
            this.txb_MoviesSearch.Size = new System.Drawing.Size(100, 20);
            this.txb_MoviesSearch.TabIndex = 6;
            this.txb_MoviesSearch.TextChanged += new System.EventHandler(this.txb_MoviesSearch_TextChanged);
            // 
            // btn_Return
            // 
            this.btn_Return.Location = new System.Drawing.Point(12, 561);
            this.btn_Return.Name = "btn_Return";
            this.btn_Return.Size = new System.Drawing.Size(83, 23);
            this.btn_Return.TabIndex = 7;
            this.btn_Return.Text = "Retour ...";
            this.btn_Return.UseVisualStyleBackColor = true;
            this.btn_Return.Click += new System.EventHandler(this.btn_Return_Click);
            // 
            // cb_NbJours
            // 
            this.cb_NbJours.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_NbJours.FormattingEnabled = true;
            this.cb_NbJours.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.cb_NbJours.Location = new System.Drawing.Point(475, 505);
            this.cb_NbJours.Name = "cb_NbJours";
            this.cb_NbJours.Size = new System.Drawing.Size(93, 21);
            this.cb_NbJours.TabIndex = 8;
            // 
            // btn_Location
            // 
            this.btn_Location.Location = new System.Drawing.Point(521, 561);
            this.btn_Location.Name = "btn_Location";
            this.btn_Location.Size = new System.Drawing.Size(151, 23);
            this.btn_Location.TabIndex = 9;
            this.btn_Location.Text = "Location";
            this.btn_Location.UseVisualStyleBackColor = true;
            this.btn_Location.Click += new System.EventHandler(this.btn_Location_Click);
            // 
            // dgv_Copies
            // 
            this.dgv_Copies.AllowUserToAddRows = false;
            this.dgv_Copies.AllowUserToDeleteRows = false;
            this.dgv_Copies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Copies.Location = new System.Drawing.Point(12, 338);
            this.dgv_Copies.Name = "dgv_Copies";
            this.dgv_Copies.ReadOnly = true;
            this.dgv_Copies.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Copies.Size = new System.Drawing.Size(660, 150);
            this.dgv_Copies.TabIndex = 10;
            // 
            // lb_Nb_Days
            // 
            this.lb_Nb_Days.Location = new System.Drawing.Point(324, 508);
            this.lb_Nb_Days.Name = "lb_Nb_Days";
            this.lb_Nb_Days.Size = new System.Drawing.Size(145, 13);
            this.lb_Nb_Days.TabIndex = 11;
            this.lb_Nb_Days.Text = "Nombre de jours :";
            this.lb_Nb_Days.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btn_LocationList
            // 
            this.btn_LocationList.Location = new System.Drawing.Point(101, 561);
            this.btn_LocationList.Name = "btn_LocationList";
            this.btn_LocationList.Size = new System.Drawing.Size(128, 23);
            this.btn_LocationList.TabIndex = 12;
            this.btn_LocationList.Text = "Liste des locations ...";
            this.btn_LocationList.UseVisualStyleBackColor = true;
            this.btn_LocationList.Click += new System.EventHandler(this.btn_LocationList_Click);
            // 
            // lb_Film_Copies
            // 
            this.lb_Film_Copies.AutoSize = true;
            this.lb_Film_Copies.Location = new System.Drawing.Point(12, 322);
            this.lb_Film_Copies.Name = "lb_Film_Copies";
            this.lb_Film_Copies.Size = new System.Drawing.Size(75, 13);
            this.lb_Film_Copies.TabIndex = 13;
            this.lb_Film_Copies.Text = "Copies du film:";
            // 
            // POS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 600);
            this.Controls.Add(this.lb_Film_Copies);
            this.Controls.Add(this.btn_LocationList);
            this.Controls.Add(this.lb_Nb_Days);
            this.Controls.Add(this.dgv_Copies);
            this.Controls.Add(this.btn_Location);
            this.Controls.Add(this.cb_NbJours);
            this.Controls.Add(this.btn_Return);
            this.Controls.Add(this.txb_MoviesSearch);
            this.Controls.Add(this.lb_Search_Movies);
            this.Controls.Add(this.dgv_Members);
            this.Controls.Add(this.lb_Search_Members);
            this.Controls.Add(this.txb_NameSearch);
            this.Controls.Add(this.dgv_Movies);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(700, 639);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(700, 639);
            this.Name = "POS";
            this.Text = "POS";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Movies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Members)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Copies)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Movies;
        private System.Windows.Forms.TextBox txb_NameSearch;
        private System.Windows.Forms.Label lb_Search_Members;
        private System.Windows.Forms.DataGridView dgv_Members;
        private System.Windows.Forms.Label lb_Search_Movies;
        private System.Windows.Forms.TextBox txb_MoviesSearch;
        private System.Windows.Forms.Button btn_Return;
        private System.Windows.Forms.ComboBox cb_NbJours;
        private System.Windows.Forms.Button btn_Location;
        private System.Windows.Forms.DataGridView dgv_Copies;
        private System.Windows.Forms.Label lb_Nb_Days;
        private System.Windows.Forms.Button btn_LocationList;
        private System.Windows.Forms.Label lb_Film_Copies;
    }
}