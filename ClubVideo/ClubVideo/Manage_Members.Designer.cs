namespace ClubVideo
{
    partial class Manage_Members
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
            this.components = new System.ComponentModel.Container();
            this.lb_Search = new System.Windows.Forms.Label();
            this.tb_Search = new System.Windows.Forms.TextBox();
            this.dgv_SearchResults = new System.Windows.Forms.DataGridView();
            this.bt_DeleteUsers = new System.Windows.Forms.Button();
            this.bt_EditUser = new System.Windows.Forms.Button();
            this.bt_AddUser = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SearchResults)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_Search
            // 
            this.lb_Search.Location = new System.Drawing.Point(445, 35);
            this.lb_Search.Name = "lb_Search";
            this.lb_Search.Size = new System.Drawing.Size(86, 15);
            this.lb_Search.TabIndex = 0;
            this.lb_Search.Text = "Search :";
            this.lb_Search.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tb_Search
            // 
            this.tb_Search.Location = new System.Drawing.Point(533, 33);
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
            this.dgv_SearchResults.Location = new System.Drawing.Point(0, 57);
            this.dgv_SearchResults.Name = "dgv_SearchResults";
            this.dgv_SearchResults.ReadOnly = true;
            this.dgv_SearchResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_SearchResults.Size = new System.Drawing.Size(716, 395);
            this.dgv_SearchResults.TabIndex = 2;
            this.dgv_SearchResults.SelectionChanged += new System.EventHandler(this.dgv_SearchResults_SelectionChanged);
            this.dgv_SearchResults.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgv_SearchResults_MouseDoubleClick);
            // 
            // bt_DeleteUsers
            // 
            this.bt_DeleteUsers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bt_DeleteUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_DeleteUsers.FlatAppearance.BorderSize = 0;
            this.bt_DeleteUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_DeleteUsers.Image = global::ClubVideo.Properties.Resources.DeleteUsers;
            this.bt_DeleteUsers.Location = new System.Drawing.Point(117, 2);
            this.bt_DeleteUsers.Margin = new System.Windows.Forms.Padding(2);
            this.bt_DeleteUsers.Name = "bt_DeleteUsers";
            this.bt_DeleteUsers.Size = new System.Drawing.Size(55, 55);
            this.bt_DeleteUsers.TabIndex = 6;
            this.bt_DeleteUsers.UseVisualStyleBackColor = true;
            this.bt_DeleteUsers.Click += new System.EventHandler(this.btn_Delete_Click);
            this.bt_DeleteUsers.MouseEnter += new System.EventHandler(this.bt_MouseEnter);
            this.bt_DeleteUsers.MouseLeave += new System.EventHandler(this.bt_MouseLeave);
            // 
            // bt_EditUser
            // 
            this.bt_EditUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bt_EditUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_EditUser.FlatAppearance.BorderSize = 0;
            this.bt_EditUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_EditUser.Image = global::ClubVideo.Properties.Resources.EditUser;
            this.bt_EditUser.Location = new System.Drawing.Point(59, 2);
            this.bt_EditUser.Margin = new System.Windows.Forms.Padding(2);
            this.bt_EditUser.Name = "bt_EditUser";
            this.bt_EditUser.Size = new System.Drawing.Size(55, 55);
            this.bt_EditUser.TabIndex = 6;
            this.bt_EditUser.UseVisualStyleBackColor = true;
            this.bt_EditUser.Click += new System.EventHandler(this.btn_Modify_Click);
            this.bt_EditUser.MouseEnter += new System.EventHandler(this.bt_MouseEnter);
            this.bt_EditUser.MouseLeave += new System.EventHandler(this.bt_MouseLeave);
            // 
            // bt_AddUser
            // 
            this.bt_AddUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bt_AddUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_AddUser.FlatAppearance.BorderSize = 0;
            this.bt_AddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_AddUser.Image = global::ClubVideo.Properties.Resources.AddUser;
            this.bt_AddUser.Location = new System.Drawing.Point(0, 2);
            this.bt_AddUser.Margin = new System.Windows.Forms.Padding(2);
            this.bt_AddUser.Name = "bt_AddUser";
            this.bt_AddUser.Size = new System.Drawing.Size(55, 55);
            this.bt_AddUser.TabIndex = 6;
            this.bt_AddUser.UseVisualStyleBackColor = true;
            this.bt_AddUser.Click += new System.EventHandler(this.btn_Add_Click);
            this.bt_AddUser.MouseEnter += new System.EventHandler(this.bt_MouseEnter);
            this.bt_AddUser.MouseLeave += new System.EventHandler(this.bt_MouseLeave);
            // 
            // Manage_Members
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 451);
            this.Controls.Add(this.bt_AddUser);
            this.Controls.Add(this.bt_EditUser);
            this.Controls.Add(this.bt_DeleteUsers);
            this.Controls.Add(this.dgv_SearchResults);
            this.Controls.Add(this.tb_Search);
            this.Controls.Add(this.lb_Search);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(732, 490);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(732, 490);
            this.Name = "Manage_Members";
            this.Text = "Manage_Members";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SearchResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Search;
        private System.Windows.Forms.TextBox tb_Search;
        private System.Windows.Forms.DataGridView dgv_SearchResults;
        private System.Windows.Forms.Button bt_DeleteUsers;
        private System.Windows.Forms.Button bt_EditUser;
        private System.Windows.Forms.Button bt_AddUser;
        private System.Windows.Forms.ToolTip toolTip;
    }
}