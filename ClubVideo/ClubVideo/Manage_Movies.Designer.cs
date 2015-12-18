namespace ClubVideo
{
    partial class Manage_Movies
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
            this.lb_Search = new System.Windows.Forms.Label();
            this.tb_Search = new System.Windows.Forms.TextBox();
            this.dgv_SearchResults = new System.Windows.Forms.DataGridView();
            this.btn_AddCopies = new System.Windows.Forms.Button();
            this.txb_CopiesToAdd = new System.Windows.Forms.TextBox();
            this.bt_AddMovie = new System.Windows.Forms.Button();
            this.bt_EditMovie = new System.Windows.Forms.Button();
            this.bt_DeleteMovie = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SearchResults)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_Search
            // 
            this.lb_Search.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.lb_Search.Location = new System.Drawing.Point(460, 39);
            this.lb_Search.Name = "lb_Search";
            this.lb_Search.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lb_Search.Size = new System.Drawing.Size(70, 17);
            this.lb_Search.TabIndex = 0;
            this.lb_Search.Text = "Search :";
            this.lb_Search.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tb_Search
            // 
            this.tb_Search.Location = new System.Drawing.Point(533, 36);
            this.tb_Search.Name = "tb_Search";
            this.tb_Search.Size = new System.Drawing.Size(171, 20);
            this.tb_Search.TabIndex = 1;
            this.tb_Search.TextChanged += new System.EventHandler(this.tb_Search_TextChanged);
            // 
            // dgv_SearchResults
            // 
            this.dgv_SearchResults.AccessibleName = "";
            this.dgv_SearchResults.AllowUserToAddRows = false;
            this.dgv_SearchResults.AllowUserToDeleteRows = false;
            this.dgv_SearchResults.AllowUserToOrderColumns = true;
            this.dgv_SearchResults.AllowUserToResizeRows = false;
            this.dgv_SearchResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_SearchResults.Location = new System.Drawing.Point(0, 62);
            this.dgv_SearchResults.Name = "dgv_SearchResults";
            this.dgv_SearchResults.ReadOnly = true;
            this.dgv_SearchResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_SearchResults.Size = new System.Drawing.Size(716, 389);
            this.dgv_SearchResults.TabIndex = 2;
            this.dgv_SearchResults.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgv_SearchResults_MouseDoubleClick);
            // 
            // btn_AddCopies
            // 
            this.btn_AddCopies.Location = new System.Drawing.Point(221, 34);
            this.btn_AddCopies.Name = "btn_AddCopies";
            this.btn_AddCopies.Size = new System.Drawing.Size(127, 23);
            this.btn_AddCopies.TabIndex = 10;
            this.btn_AddCopies.Text = "AjouterCopies";
            this.btn_AddCopies.UseVisualStyleBackColor = true;
            this.btn_AddCopies.Visible = false;
            this.btn_AddCopies.Click += new System.EventHandler(this.btn_AddCopies_Click);
            // 
            // txb_CopiesToAdd
            // 
            this.txb_CopiesToAdd.Location = new System.Drawing.Point(354, 36);
            this.txb_CopiesToAdd.Name = "txb_CopiesToAdd";
            this.txb_CopiesToAdd.Size = new System.Drawing.Size(100, 20);
            this.txb_CopiesToAdd.TabIndex = 11;
            this.txb_CopiesToAdd.Visible = false;
            // 
            // bt_AddMovie
            // 
            this.bt_AddMovie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bt_AddMovie.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_AddMovie.FlatAppearance.BorderSize = 0;
            this.bt_AddMovie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_AddMovie.Image = global::ClubVideo.Properties.Resources.AddMovie;
            this.bt_AddMovie.Location = new System.Drawing.Point(3, 3);
            this.bt_AddMovie.Margin = new System.Windows.Forms.Padding(2);
            this.bt_AddMovie.Name = "bt_AddMovie";
            this.bt_AddMovie.Size = new System.Drawing.Size(55, 55);
            this.bt_AddMovie.TabIndex = 7;
            this.bt_AddMovie.UseVisualStyleBackColor = true;
            this.bt_AddMovie.Visible = false;
            this.bt_AddMovie.Click += new System.EventHandler(this.btn_Add_Click);
            this.bt_AddMovie.MouseEnter += new System.EventHandler(this.bt_MouseEnter);
            this.bt_AddMovie.MouseLeave += new System.EventHandler(this.bt_MouseLeave);
            // 
            // bt_EditMovie
            // 
            this.bt_EditMovie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bt_EditMovie.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_EditMovie.FlatAppearance.BorderSize = 0;
            this.bt_EditMovie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_EditMovie.Image = global::ClubVideo.Properties.Resources.EditMovie;
            this.bt_EditMovie.Location = new System.Drawing.Point(61, -1);
            this.bt_EditMovie.Margin = new System.Windows.Forms.Padding(2);
            this.bt_EditMovie.Name = "bt_EditMovie";
            this.bt_EditMovie.Size = new System.Drawing.Size(55, 59);
            this.bt_EditMovie.TabIndex = 8;
            this.bt_EditMovie.UseVisualStyleBackColor = true;
            this.bt_EditMovie.Visible = false;
            this.bt_EditMovie.Click += new System.EventHandler(this.btn_Modify_Click);
            this.bt_EditMovie.MouseEnter += new System.EventHandler(this.bt_MouseEnter);
            this.bt_EditMovie.MouseLeave += new System.EventHandler(this.bt_MouseLeave);
            // 
            // bt_DeleteMovie
            // 
            this.bt_DeleteMovie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bt_DeleteMovie.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_DeleteMovie.FlatAppearance.BorderSize = 0;
            this.bt_DeleteMovie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_DeleteMovie.Image = global::ClubVideo.Properties.Resources.DeleteMovie;
            this.bt_DeleteMovie.Location = new System.Drawing.Point(119, 3);
            this.bt_DeleteMovie.Margin = new System.Windows.Forms.Padding(2);
            this.bt_DeleteMovie.Name = "bt_DeleteMovie";
            this.bt_DeleteMovie.Size = new System.Drawing.Size(55, 55);
            this.bt_DeleteMovie.TabIndex = 9;
            this.bt_DeleteMovie.UseVisualStyleBackColor = true;
            this.bt_DeleteMovie.Visible = false;
            this.bt_DeleteMovie.Click += new System.EventHandler(this.btn_Delete_Click);
            this.bt_DeleteMovie.MouseEnter += new System.EventHandler(this.bt_MouseEnter);
            this.bt_DeleteMovie.MouseLeave += new System.EventHandler(this.bt_MouseLeave);
            // 
            // Manage_Movies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 451);
            this.Controls.Add(this.txb_CopiesToAdd);
            this.Controls.Add(this.btn_AddCopies);
            this.Controls.Add(this.bt_AddMovie);
            this.Controls.Add(this.bt_EditMovie);
            this.Controls.Add(this.bt_DeleteMovie);
            this.Controls.Add(this.dgv_SearchResults);
            this.Controls.Add(this.tb_Search);
            this.Controls.Add(this.lb_Search);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(732, 490);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(732, 490);
            this.Name = "Manage_Movies";
            this.Text = "Manage_Movies";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SearchResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Search;
        private System.Windows.Forms.TextBox tb_Search;
        private System.Windows.Forms.DataGridView dgv_SearchResults;
        private System.Windows.Forms.Button bt_AddMovie;
        private System.Windows.Forms.Button bt_EditMovie;
        private System.Windows.Forms.Button bt_DeleteMovie;
        private System.Windows.Forms.Button btn_AddCopies;
        private System.Windows.Forms.TextBox txb_CopiesToAdd;
    }
}