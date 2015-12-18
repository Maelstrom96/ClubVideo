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
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Modify = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_AddCopies = new System.Windows.Forms.Button();
            this.txb_CopiesToAdd = new System.Windows.Forms.TextBox();
            this.btn_DeleteCopies = new System.Windows.Forms.Button();
            this.txb_CopiesToDelete = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SearchResults)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_Search
            // 
            this.lb_Search.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.lb_Search.Location = new System.Drawing.Point(460, 48);
            this.lb_Search.Name = "lb_Search";
            this.lb_Search.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lb_Search.Size = new System.Drawing.Size(70, 17);
            this.lb_Search.TabIndex = 0;
            this.lb_Search.Text = "Search :";
            this.lb_Search.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tb_Search
            // 
            this.tb_Search.Location = new System.Drawing.Point(533, 45);
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
            this.dgv_SearchResults.Location = new System.Drawing.Point(12, 71);
            this.dgv_SearchResults.Name = "dgv_SearchResults";
            this.dgv_SearchResults.ReadOnly = true;
            this.dgv_SearchResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_SearchResults.Size = new System.Drawing.Size(692, 369);
            this.dgv_SearchResults.TabIndex = 2;
            this.dgv_SearchResults.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgv_SearchResults_MouseDoubleClick);
            // 
            // btn_Add
            // 
            this.btn_Add.BackgroundImage = global::ClubVideo.Properties.Resources.member_add;
            this.btn_Add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Add.FlatAppearance.BorderSize = 0;
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add.Location = new System.Drawing.Point(12, 8);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(53, 57);
            this.btn_Add.TabIndex = 7;
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Visible = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Modify
            // 
            this.btn_Modify.BackgroundImage = global::ClubVideo.Properties.Resources.member_edit;
            this.btn_Modify.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Modify.FlatAppearance.BorderSize = 0;
            this.btn_Modify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Modify.Location = new System.Drawing.Point(69, 8);
            this.btn_Modify.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Modify.Name = "btn_Modify";
            this.btn_Modify.Size = new System.Drawing.Size(53, 57);
            this.btn_Modify.TabIndex = 8;
            this.btn_Modify.UseVisualStyleBackColor = true;
            this.btn_Modify.Visible = false;
            this.btn_Modify.Click += new System.EventHandler(this.btn_Modify_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackgroundImage = global::ClubVideo.Properties.Resources.member_delete;
            this.btn_Delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Delete.FlatAppearance.BorderSize = 0;
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Delete.Location = new System.Drawing.Point(126, 8);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(53, 57);
            this.btn_Delete.TabIndex = 9;
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Visible = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_AddCopies
            // 
            this.btn_AddCopies.Location = new System.Drawing.Point(207, 12);
            this.btn_AddCopies.Name = "btn_AddCopies";
            this.btn_AddCopies.Size = new System.Drawing.Size(75, 23);
            this.btn_AddCopies.TabIndex = 10;
            this.btn_AddCopies.Text = "AjouterCopies";
            this.btn_AddCopies.UseVisualStyleBackColor = true;
            this.btn_AddCopies.Visible = false;
            this.btn_AddCopies.Click += new System.EventHandler(this.btn_AddCopies_Click);
            // 
            // txb_CopiesToAdd
            // 
            this.txb_CopiesToAdd.Location = new System.Drawing.Point(288, 12);
            this.txb_CopiesToAdd.Name = "txb_CopiesToAdd";
            this.txb_CopiesToAdd.Size = new System.Drawing.Size(100, 20);
            this.txb_CopiesToAdd.TabIndex = 11;
            this.txb_CopiesToAdd.Visible = false;
            // 
            // btn_DeleteCopies
            // 
            this.btn_DeleteCopies.Location = new System.Drawing.Point(207, 41);
            this.btn_DeleteCopies.Name = "btn_DeleteCopies";
            this.btn_DeleteCopies.Size = new System.Drawing.Size(75, 23);
            this.btn_DeleteCopies.TabIndex = 12;
            this.btn_DeleteCopies.Text = "DeleteCopies";
            this.btn_DeleteCopies.UseVisualStyleBackColor = true;
            this.btn_DeleteCopies.Visible = false;
            this.btn_DeleteCopies.Click += new System.EventHandler(this.btn_DeleteCopies_Click);
            // 
            // txb_CopiesToDelete
            // 
            this.txb_CopiesToDelete.Location = new System.Drawing.Point(288, 45);
            this.txb_CopiesToDelete.Name = "txb_CopiesToDelete";
            this.txb_CopiesToDelete.Size = new System.Drawing.Size(100, 20);
            this.txb_CopiesToDelete.TabIndex = 11;
            this.txb_CopiesToDelete.Visible = false;
            // 
            // Manage_Movies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 451);
            this.Controls.Add(this.btn_DeleteCopies);
            this.Controls.Add(this.txb_CopiesToDelete);
            this.Controls.Add(this.txb_CopiesToAdd);
            this.Controls.Add(this.btn_AddCopies);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_Modify);
            this.Controls.Add(this.btn_Delete);
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
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Modify;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_AddCopies;
        private System.Windows.Forms.TextBox txb_CopiesToAdd;
        private System.Windows.Forms.Button btn_DeleteCopies;
        private System.Windows.Forms.TextBox txb_CopiesToDelete;
    }
}