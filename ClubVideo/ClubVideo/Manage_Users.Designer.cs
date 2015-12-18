namespace ClubVideo
{
    partial class Manage_Users
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_Users = new System.Windows.Forms.DataGridView();
            this.tb_Search = new System.Windows.Forms.TextBox();
            this.lb_SearchUser = new System.Windows.Forms.Label();
            this.bt_DeleteUsers = new System.Windows.Forms.Button();
            this.bt_PermsEdit = new System.Windows.Forms.Button();
            this.bt_EditUser = new System.Windows.Forms.Button();
            this.bt_AddUser = new System.Windows.Forms.Button();
            this.bt_GroupsEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Users)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Users
            // 
            this.dgv_Users.AllowUserToAddRows = false;
            this.dgv_Users.AllowUserToDeleteRows = false;
            this.dgv_Users.AllowUserToOrderColumns = true;
            this.dgv_Users.AllowUserToResizeRows = false;
            this.dgv_Users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Users.Location = new System.Drawing.Point(0, 60);
            this.dgv_Users.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_Users.Name = "dgv_Users";
            this.dgv_Users.ReadOnly = true;
            this.dgv_Users.RowHeadersVisible = false;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgv_Users.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Users.RowTemplate.Height = 24;
            this.dgv_Users.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Users.Size = new System.Drawing.Size(562, 502);
            this.dgv_Users.TabIndex = 0;
            this.dgv_Users.SelectionChanged += new System.EventHandler(this.dgv_Users_SelectionChanged);
            // 
            // tb_Search
            // 
            this.tb_Search.Location = new System.Drawing.Point(353, 36);
            this.tb_Search.Margin = new System.Windows.Forms.Padding(2);
            this.tb_Search.Name = "tb_Search";
            this.tb_Search.Size = new System.Drawing.Size(205, 20);
            this.tb_Search.TabIndex = 1;
            this.tb_Search.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lb_SearchUser
            // 
            this.lb_SearchUser.Location = new System.Drawing.Point(284, 39);
            this.lb_SearchUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_SearchUser.Name = "lb_SearchUser";
            this.lb_SearchUser.Size = new System.Drawing.Size(65, 13);
            this.lb_SearchUser.TabIndex = 2;
            this.lb_SearchUser.Text = "Search :";
            this.lb_SearchUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bt_DeleteUsers
            // 
            this.bt_DeleteUsers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_DeleteUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_DeleteUsers.FlatAppearance.BorderSize = 0;
            this.bt_DeleteUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_DeleteUsers.Image = global::ClubVideo.Properties.Resources.DeleteUsers;
            this.bt_DeleteUsers.Location = new System.Drawing.Point(222, 2);
            this.bt_DeleteUsers.Margin = new System.Windows.Forms.Padding(2);
            this.bt_DeleteUsers.Name = "bt_DeleteUsers";
            this.bt_DeleteUsers.Size = new System.Drawing.Size(55, 55);
            this.bt_DeleteUsers.TabIndex = 3;
            this.bt_DeleteUsers.UseVisualStyleBackColor = true;
            this.bt_DeleteUsers.Click += new System.EventHandler(this.bt_DeleteUsers_Click);
            this.bt_DeleteUsers.MouseEnter += new System.EventHandler(this.bt_MouseEnter);
            this.bt_DeleteUsers.MouseLeave += new System.EventHandler(this.bt_MouseLeave);
            // 
            // bt_PermsEdit
            // 
            this.bt_PermsEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_PermsEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_PermsEdit.FlatAppearance.BorderSize = 0;
            this.bt_PermsEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_PermsEdit.Image = global::ClubVideo.Properties.Resources.PermsEdit;
            this.bt_PermsEdit.Location = new System.Drawing.Point(112, 2);
            this.bt_PermsEdit.Margin = new System.Windows.Forms.Padding(2);
            this.bt_PermsEdit.Name = "bt_PermsEdit";
            this.bt_PermsEdit.Size = new System.Drawing.Size(55, 55);
            this.bt_PermsEdit.TabIndex = 3;
            this.bt_PermsEdit.UseVisualStyleBackColor = true;
            this.bt_PermsEdit.Click += new System.EventHandler(this.bt_PermsEdit_Click);
            this.bt_PermsEdit.MouseEnter += new System.EventHandler(this.bt_MouseEnter);
            this.bt_PermsEdit.MouseLeave += new System.EventHandler(this.bt_MouseLeave);
            // 
            // bt_EditUser
            // 
            this.bt_EditUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_EditUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_EditUser.FlatAppearance.BorderSize = 0;
            this.bt_EditUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_EditUser.Image = global::ClubVideo.Properties.Resources.EditUser;
            this.bt_EditUser.Location = new System.Drawing.Point(57, 2);
            this.bt_EditUser.Margin = new System.Windows.Forms.Padding(2);
            this.bt_EditUser.Name = "bt_EditUser";
            this.bt_EditUser.Size = new System.Drawing.Size(55, 55);
            this.bt_EditUser.TabIndex = 3;
            this.bt_EditUser.UseVisualStyleBackColor = true;
            this.bt_EditUser.Click += new System.EventHandler(this.bt_EditUser_Click);
            this.bt_EditUser.MouseEnter += new System.EventHandler(this.bt_MouseEnter);
            this.bt_EditUser.MouseLeave += new System.EventHandler(this.bt_MouseLeave);
            // 
            // bt_AddUser
            // 
            this.bt_AddUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_AddUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_AddUser.FlatAppearance.BorderSize = 0;
            this.bt_AddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_AddUser.Image = global::ClubVideo.Properties.Resources.AddUser;
            this.bt_AddUser.Location = new System.Drawing.Point(2, 2);
            this.bt_AddUser.Margin = new System.Windows.Forms.Padding(2);
            this.bt_AddUser.Name = "bt_AddUser";
            this.bt_AddUser.Size = new System.Drawing.Size(55, 55);
            this.bt_AddUser.TabIndex = 3;
            this.bt_AddUser.UseVisualStyleBackColor = true;
            this.bt_AddUser.Click += new System.EventHandler(this.bt_AddUser_Click);
            this.bt_AddUser.MouseEnter += new System.EventHandler(this.bt_MouseEnter);
            this.bt_AddUser.MouseLeave += new System.EventHandler(this.bt_MouseLeave);
            // 
            // bt_GroupsEdit
            // 
            this.bt_GroupsEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_GroupsEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_GroupsEdit.FlatAppearance.BorderSize = 0;
            this.bt_GroupsEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_GroupsEdit.Image = global::ClubVideo.Properties.Resources.GroupsEdit;
            this.bt_GroupsEdit.Location = new System.Drawing.Point(167, 2);
            this.bt_GroupsEdit.Margin = new System.Windows.Forms.Padding(2);
            this.bt_GroupsEdit.Name = "bt_GroupsEdit";
            this.bt_GroupsEdit.Size = new System.Drawing.Size(55, 55);
            this.bt_GroupsEdit.TabIndex = 3;
            this.bt_GroupsEdit.UseVisualStyleBackColor = true;
            this.bt_GroupsEdit.Click += new System.EventHandler(this.bt_EditUser_Click);
            this.bt_GroupsEdit.MouseEnter += new System.EventHandler(this.bt_MouseEnter);
            this.bt_GroupsEdit.MouseLeave += new System.EventHandler(this.bt_MouseLeave);
            // 
            // Manage_Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(562, 449);
            this.Controls.Add(this.bt_DeleteUsers);
            this.Controls.Add(this.bt_GroupsEdit);
            this.Controls.Add(this.bt_PermsEdit);
            this.Controls.Add(this.bt_EditUser);
            this.Controls.Add(this.bt_AddUser);
            this.Controls.Add(this.lb_SearchUser);
            this.Controls.Add(this.tb_Search);
            this.Controls.Add(this.dgv_Users);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(578, 488);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(578, 193);
            this.Name = "Manage_Users";
            this.Text = "Manage_Users";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Users)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Users;
        private System.Windows.Forms.TextBox tb_Search;
        private System.Windows.Forms.Label lb_SearchUser;
        private System.Windows.Forms.Button bt_AddUser;
        private System.Windows.Forms.Button bt_EditUser;
        private System.Windows.Forms.Button bt_DeleteUsers;
        private System.Windows.Forms.Button bt_PermsEdit;
        private System.Windows.Forms.Button bt_GroupsEdit;
    }
}