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
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_Members = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_MoviesSearch = new System.Windows.Forms.TextBox();
            this.btn_Return = new System.Windows.Forms.Button();
            this.cb_NbJours = new System.Windows.Forms.ComboBox();
            this.btn_Location = new System.Windows.Forms.Button();
            this.dgv_Copies = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
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
            this.dgv_Movies.Size = new System.Drawing.Size(556, 150);
            this.dgv_Movies.TabIndex = 0;
            this.dgv_Movies.DoubleClick += new System.EventHandler(this.dgv_Movies_DoubleClick);
            // 
            // txb_NameSearch
            // 
            this.txb_NameSearch.Location = new System.Drawing.Point(101, 17);
            this.txb_NameSearch.Name = "txb_NameSearch";
            this.txb_NameSearch.Size = new System.Drawing.Size(100, 20);
            this.txb_NameSearch.TabIndex = 1;
            this.txb_NameSearch.TextChanged += new System.EventHandler(this.txb_NameSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Customer Name";
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
            this.dgv_Members.Size = new System.Drawing.Size(556, 83);
            this.dgv_Members.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Film a louer";
            // 
            // txb_MoviesSearch
            // 
            this.txb_MoviesSearch.Location = new System.Drawing.Point(101, 125);
            this.txb_MoviesSearch.Name = "txb_MoviesSearch";
            this.txb_MoviesSearch.Size = new System.Drawing.Size(100, 20);
            this.txb_MoviesSearch.TabIndex = 6;
            this.txb_MoviesSearch.TextChanged += new System.EventHandler(this.txb_MoviesSearch_TextChanged);
            // 
            // btn_Return
            // 
            this.btn_Return.Location = new System.Drawing.Point(12, 561);
            this.btn_Return.Name = "btn_Return";
            this.btn_Return.Size = new System.Drawing.Size(123, 23);
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
            this.btn_Location.Location = new System.Drawing.Point(417, 561);
            this.btn_Location.Name = "btn_Location";
            this.btn_Location.Size = new System.Drawing.Size(151, 23);
            this.btn_Location.TabIndex = 9;
            this.btn_Location.Text = "Location";
            this.btn_Location.UseVisualStyleBackColor = true;
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
            this.dgv_Copies.Size = new System.Drawing.Size(556, 150);
            this.dgv_Copies.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(379, 508);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Nombre de jours :";
            // 
            // POS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 600);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgv_Copies);
            this.Controls.Add(this.btn_Location);
            this.Controls.Add(this.cb_NbJours);
            this.Controls.Add(this.btn_Return);
            this.Controls.Add(this.txb_MoviesSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgv_Members);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txb_NameSearch);
            this.Controls.Add(this.dgv_Movies);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(599, 639);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(599, 639);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_Members;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txb_MoviesSearch;
        private System.Windows.Forms.Button btn_Return;
        private System.Windows.Forms.ComboBox cb_NbJours;
        private System.Windows.Forms.Button btn_Location;
        private System.Windows.Forms.DataGridView dgv_Copies;
        private System.Windows.Forms.Label label3;
    }
}