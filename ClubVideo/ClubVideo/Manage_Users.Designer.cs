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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_Users = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lb_SearchUser = new System.Windows.Forms.Label();
            this.bt_AddUser = new System.Windows.Forms.Button();
            this.bt_EditUser = new System.Windows.Forms.Button();
            this.bt_DeleteUsers = new System.Windows.Forms.Button();
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
            this.dgv_Users.Location = new System.Drawing.Point(12, 59);
            this.dgv_Users.Name = "dgv_Users";
            this.dgv_Users.ReadOnly = true;
            this.dgv_Users.RowHeadersVisible = false;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dgv_Users.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Users.RowTemplate.Height = 24;
            this.dgv_Users.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Users.Size = new System.Drawing.Size(810, 482);
            this.dgv_Users.TabIndex = 0;
            this.dgv_Users.SelectionChanged += new System.EventHandler(this.dgv_Users_SelectionChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(99, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(272, 22);
            this.textBox1.TabIndex = 1;
            // 
            // lb_SearchUser
            // 
            this.lb_SearchUser.AutoSize = true;
            this.lb_SearchUser.Location = new System.Drawing.Point(32, 30);
            this.lb_SearchUser.Name = "lb_SearchUser";
            this.lb_SearchUser.Size = new System.Drawing.Size(61, 17);
            this.lb_SearchUser.TabIndex = 2;
            this.lb_SearchUser.Text = "Search :";
            // 
            // bt_AddUser
            // 
            this.bt_AddUser.BackgroundImage = global::ClubVideo.Properties.Resources.Add_User;
            this.bt_AddUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_AddUser.FlatAppearance.BorderSize = 0;
            this.bt_AddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_AddUser.Location = new System.Drawing.Point(828, 75);
            this.bt_AddUser.Name = "bt_AddUser";
            this.bt_AddUser.Size = new System.Drawing.Size(86, 82);
            this.bt_AddUser.TabIndex = 3;
            this.bt_AddUser.UseVisualStyleBackColor = true;
            this.bt_AddUser.Click += new System.EventHandler(this.bt_AddUser_Click);
            // 
            // bt_EditUser
            // 
            this.bt_EditUser.BackgroundImage = global::ClubVideo.Properties.Resources.Edit_User;
            this.bt_EditUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_EditUser.FlatAppearance.BorderSize = 0;
            this.bt_EditUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_EditUser.Location = new System.Drawing.Point(828, 190);
            this.bt_EditUser.Name = "bt_EditUser";
            this.bt_EditUser.Size = new System.Drawing.Size(86, 82);
            this.bt_EditUser.TabIndex = 3;
            this.bt_EditUser.UseVisualStyleBackColor = true;
            this.bt_EditUser.Click += new System.EventHandler(this.bt_EditUser_Click);
            // 
            // bt_DeleteUsers
            // 
            this.bt_DeleteUsers.BackgroundImage = global::ClubVideo.Properties.Resources.Delete_User;
            this.bt_DeleteUsers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_DeleteUsers.FlatAppearance.BorderSize = 0;
            this.bt_DeleteUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_DeleteUsers.Location = new System.Drawing.Point(828, 310);
            this.bt_DeleteUsers.Name = "bt_DeleteUsers";
            this.bt_DeleteUsers.Size = new System.Drawing.Size(86, 82);
            this.bt_DeleteUsers.TabIndex = 3;
            this.bt_DeleteUsers.UseVisualStyleBackColor = true;
            // 
            // Manage_Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 553);
            this.Controls.Add(this.bt_DeleteUsers);
            this.Controls.Add(this.bt_EditUser);
            this.Controls.Add(this.bt_AddUser);
            this.Controls.Add(this.lb_SearchUser);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dgv_Users);
            this.Name = "Manage_Users";
            this.Text = "Manage_Users";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Users)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Users;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lb_SearchUser;
        private System.Windows.Forms.Button bt_AddUser;
        private System.Windows.Forms.Button bt_EditUser;
        private System.Windows.Forms.Button bt_DeleteUsers;
    }
}