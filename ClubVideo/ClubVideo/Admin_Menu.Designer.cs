namespace ClubVideo
{
    partial class Admin_Menu
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
            this.bt_Settings = new System.Windows.Forms.Button();
            this.bt_ManageCategories = new System.Windows.Forms.Button();
            this.bt_ManageGroups = new System.Windows.Forms.Button();
            this.bt_ManageUsers = new System.Windows.Forms.Button();
            this.bt_ManageMovies = new System.Windows.Forms.Button();
            this.bt_Back = new System.Windows.Forms.Button();
            this.bt_ManageMembers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_Settings
            // 
            this.bt_Settings.AutoSize = true;
            this.bt_Settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bt_Settings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_Settings.Enabled = false;
            this.bt_Settings.FlatAppearance.BorderSize = 0;
            this.bt_Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Settings.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Settings.Image = global::ClubVideo.Properties.Resources.Settings;
            this.bt_Settings.Location = new System.Drawing.Point(725, -1);
            this.bt_Settings.Margin = new System.Windows.Forms.Padding(2);
            this.bt_Settings.Name = "bt_Settings";
            this.bt_Settings.Size = new System.Drawing.Size(120, 161);
            this.bt_Settings.TabIndex = 4;
            this.bt_Settings.Text = "settings";
            this.bt_Settings.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bt_Settings.UseVisualStyleBackColor = true;
            this.bt_Settings.MouseEnter += new System.EventHandler(this.bt_MouseEnter);
            this.bt_Settings.MouseLeave += new System.EventHandler(this.bt_MouseLeave);
            // 
            // bt_ManageCategories
            // 
            this.bt_ManageCategories.AutoSize = true;
            this.bt_ManageCategories.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bt_ManageCategories.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_ManageCategories.FlatAppearance.BorderSize = 0;
            this.bt_ManageCategories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_ManageCategories.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_ManageCategories.Image = global::ClubVideo.Properties.Resources.ManageCategories;
            this.bt_ManageCategories.Location = new System.Drawing.Point(127, -1);
            this.bt_ManageCategories.Margin = new System.Windows.Forms.Padding(2);
            this.bt_ManageCategories.Name = "bt_ManageCategories";
            this.bt_ManageCategories.Size = new System.Drawing.Size(127, 161);
            this.bt_ManageCategories.TabIndex = 1;
            this.bt_ManageCategories.Text = "manage Categories";
            this.bt_ManageCategories.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bt_ManageCategories.UseVisualStyleBackColor = true;
            this.bt_ManageCategories.TextChanged += new System.EventHandler(this.Button_Permissions);
            this.bt_ManageCategories.Click += new System.EventHandler(this.bt_ManageCategories_Click);
            this.bt_ManageCategories.MouseEnter += new System.EventHandler(this.bt_MouseEnter);
            this.bt_ManageCategories.MouseLeave += new System.EventHandler(this.bt_MouseLeave);
            // 
            // bt_ManageGroups
            // 
            this.bt_ManageGroups.AutoSize = true;
            this.bt_ManageGroups.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bt_ManageGroups.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_ManageGroups.Enabled = false;
            this.bt_ManageGroups.FlatAppearance.BorderSize = 0;
            this.bt_ManageGroups.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_ManageGroups.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_ManageGroups.Image = global::ClubVideo.Properties.Resources.ManageGroups;
            this.bt_ManageGroups.Location = new System.Drawing.Point(469, -1);
            this.bt_ManageGroups.Margin = new System.Windows.Forms.Padding(2);
            this.bt_ManageGroups.Name = "bt_ManageGroups";
            this.bt_ManageGroups.Size = new System.Drawing.Size(126, 161);
            this.bt_ManageGroups.TabIndex = 1;
            this.bt_ManageGroups.Text = "manage Groups";
            this.bt_ManageGroups.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bt_ManageGroups.UseVisualStyleBackColor = true;
            this.bt_ManageGroups.MouseEnter += new System.EventHandler(this.bt_MouseEnter);
            this.bt_ManageGroups.MouseLeave += new System.EventHandler(this.bt_MouseLeave);
            // 
            // bt_ManageUsers
            // 
            this.bt_ManageUsers.AutoSize = true;
            this.bt_ManageUsers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bt_ManageUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_ManageUsers.FlatAppearance.BorderSize = 0;
            this.bt_ManageUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_ManageUsers.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_ManageUsers.Image = global::ClubVideo.Properties.Resources.ManageUsers;
            this.bt_ManageUsers.Location = new System.Drawing.Point(597, -1);
            this.bt_ManageUsers.Margin = new System.Windows.Forms.Padding(2);
            this.bt_ManageUsers.Name = "bt_ManageUsers";
            this.bt_ManageUsers.Size = new System.Drawing.Size(126, 161);
            this.bt_ManageUsers.TabIndex = 1;
            this.bt_ManageUsers.Text = "manage Users";
            this.bt_ManageUsers.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bt_ManageUsers.UseVisualStyleBackColor = true;
            this.bt_ManageUsers.TextChanged += new System.EventHandler(this.Button_Permissions);
            this.bt_ManageUsers.Click += new System.EventHandler(this.bt_ManageUsers_Click);
            this.bt_ManageUsers.MouseEnter += new System.EventHandler(this.bt_MouseEnter);
            this.bt_ManageUsers.MouseLeave += new System.EventHandler(this.bt_MouseLeave);
            // 
            // bt_ManageMovies
            // 
            this.bt_ManageMovies.AutoSize = true;
            this.bt_ManageMovies.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bt_ManageMovies.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_ManageMovies.FlatAppearance.BorderSize = 0;
            this.bt_ManageMovies.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_ManageMovies.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_ManageMovies.Image = global::ClubVideo.Properties.Resources.ManageMovies;
            this.bt_ManageMovies.Location = new System.Drawing.Point(-1, -1);
            this.bt_ManageMovies.Margin = new System.Windows.Forms.Padding(2);
            this.bt_ManageMovies.Name = "bt_ManageMovies";
            this.bt_ManageMovies.Size = new System.Drawing.Size(126, 161);
            this.bt_ManageMovies.TabIndex = 1;
            this.bt_ManageMovies.Text = "manage Movies";
            this.bt_ManageMovies.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bt_ManageMovies.UseVisualStyleBackColor = true;
            this.bt_ManageMovies.TextChanged += new System.EventHandler(this.Button_Permissions);
            this.bt_ManageMovies.Click += new System.EventHandler(this.bt_ManageMovies_Click);
            this.bt_ManageMovies.MouseEnter += new System.EventHandler(this.bt_MouseEnter);
            this.bt_ManageMovies.MouseLeave += new System.EventHandler(this.bt_MouseLeave);
            // 
            // bt_Back
            // 
            this.bt_Back.AutoSize = true;
            this.bt_Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bt_Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_Back.FlatAppearance.BorderSize = 0;
            this.bt_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Back.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Back.Image = global::ClubVideo.Properties.Resources.Back;
            this.bt_Back.Location = new System.Drawing.Point(893, -1);
            this.bt_Back.Margin = new System.Windows.Forms.Padding(2);
            this.bt_Back.Name = "bt_Back";
            this.bt_Back.Size = new System.Drawing.Size(126, 161);
            this.bt_Back.TabIndex = 2;
            this.bt_Back.Text = "back";
            this.bt_Back.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bt_Back.UseVisualStyleBackColor = true;
            this.bt_Back.Click += new System.EventHandler(this.bt_Back_Click);
            this.bt_Back.MouseEnter += new System.EventHandler(this.bt_Back_MouseEnter);
            this.bt_Back.MouseLeave += new System.EventHandler(this.bt_Back_MouseLeave);
            // 
            // bt_ManageMembers
            // 
            this.bt_ManageMembers.AutoSize = true;
            this.bt_ManageMembers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bt_ManageMembers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_ManageMembers.FlatAppearance.BorderSize = 0;
            this.bt_ManageMembers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_ManageMembers.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_ManageMembers.Image = global::ClubVideo.Properties.Resources.ManageMembers;
            this.bt_ManageMembers.Location = new System.Drawing.Point(255, -1);
            this.bt_ManageMembers.Margin = new System.Windows.Forms.Padding(2);
            this.bt_ManageMembers.Name = "bt_ManageMembers";
            this.bt_ManageMembers.Size = new System.Drawing.Size(126, 161);
            this.bt_ManageMembers.TabIndex = 2;
            this.bt_ManageMembers.Text = "manage Members";
            this.bt_ManageMembers.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bt_ManageMembers.UseVisualStyleBackColor = true;
            this.bt_ManageMembers.TextChanged += new System.EventHandler(this.Button_Permissions);
            this.bt_ManageMembers.Click += new System.EventHandler(this.bt_ManageMembers_Click);
            this.bt_ManageMembers.MouseEnter += new System.EventHandler(this.bt_MouseEnter);
            this.bt_ManageMembers.MouseLeave += new System.EventHandler(this.bt_MouseLeave);
            // 
            // Admin_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1018, 160);
            this.ControlBox = false;
            this.Controls.Add(this.bt_Settings);
            this.Controls.Add(this.bt_ManageCategories);
            this.Controls.Add(this.bt_ManageGroups);
            this.Controls.Add(this.bt_ManageUsers);
            this.Controls.Add(this.bt_ManageMovies);
            this.Controls.Add(this.bt_Back);
            this.Controls.Add(this.bt_ManageMembers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Admin_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_ManageMovies;
        private System.Windows.Forms.Button bt_ManageMembers;
        private System.Windows.Forms.Button bt_Back;
        private System.Windows.Forms.Button bt_Settings;
        private System.Windows.Forms.Button bt_ManageUsers;
        private System.Windows.Forms.Button bt_ManageGroups;
        private System.Windows.Forms.Button bt_ManageCategories;
    }
}