﻿namespace ClubVideo
{
    partial class Main_Menu
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bt_Settings = new System.Windows.Forms.Button();
            this.bt_POS = new System.Windows.Forms.Button();
            this.bt_SearchMovies = new System.Windows.Forms.Button();
            this.bt_Administration = new System.Windows.Forms.Button();
            this.bt_SearchMembers = new System.Windows.Forms.Button();
            this.bt_Logout = new System.Windows.Forms.Button();
            this.bt_Exit = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ClubVideo.Properties.Resources.Line1;
            this.pictureBox1.Location = new System.Drawing.Point(709, -2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 121);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // bt_Settings
            // 
            this.bt_Settings.AutoSize = true;
            this.bt_Settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bt_Settings.FlatAppearance.BorderSize = 0;
            this.bt_Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Settings.Image = global::ClubVideo.Properties.Resources.Settings;
            this.bt_Settings.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bt_Settings.Location = new System.Drawing.Point(587, -2);
            this.bt_Settings.Margin = new System.Windows.Forms.Padding(2);
            this.bt_Settings.Name = "bt_Settings";
            this.bt_Settings.Size = new System.Drawing.Size(118, 121);
            this.bt_Settings.TabIndex = 0;
            this.bt_Settings.Text = "settings";
            this.bt_Settings.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bt_Settings.UseVisualStyleBackColor = true;
            this.bt_Settings.TextChanged += new System.EventHandler(this.Button_Permissions);
            this.bt_Settings.Click += new System.EventHandler(this.bt_Settings_Click);
            // 
            // bt_POS
            // 
            this.bt_POS.AutoSize = true;
            this.bt_POS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bt_POS.Enabled = false;
            this.bt_POS.FlatAppearance.BorderSize = 0;
            this.bt_POS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_POS.Image = global::ClubVideo.Properties.Resources.POS;
            this.bt_POS.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bt_POS.Location = new System.Drawing.Point(-1, -2);
            this.bt_POS.Margin = new System.Windows.Forms.Padding(2);
            this.bt_POS.Name = "bt_POS";
            this.bt_POS.Size = new System.Drawing.Size(118, 121);
            this.bt_POS.TabIndex = 0;
            this.bt_POS.Text = "pos";
            this.bt_POS.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bt_POS.UseVisualStyleBackColor = true;
            this.bt_POS.TextChanged += new System.EventHandler(this.Button_Permissions);
            // 
            // bt_SearchMovies
            // 
            this.bt_SearchMovies.AutoSize = true;
            this.bt_SearchMovies.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bt_SearchMovies.FlatAppearance.BorderSize = 0;
            this.bt_SearchMovies.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_SearchMovies.Image = global::ClubVideo.Properties.Resources.ManageMovies;
            this.bt_SearchMovies.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bt_SearchMovies.Location = new System.Drawing.Point(164, -2);
            this.bt_SearchMovies.Margin = new System.Windows.Forms.Padding(2);
            this.bt_SearchMovies.Name = "bt_SearchMovies";
            this.bt_SearchMovies.Size = new System.Drawing.Size(118, 121);
            this.bt_SearchMovies.TabIndex = 0;
            this.bt_SearchMovies.Text = "search Movies";
            this.bt_SearchMovies.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bt_SearchMovies.UseVisualStyleBackColor = true;
            this.bt_SearchMovies.TextChanged += new System.EventHandler(this.Button_Permissions);
            this.bt_SearchMovies.Click += new System.EventHandler(this.bt_SearchMovies_Click);
            // 
            // bt_Administration
            // 
            this.bt_Administration.AutoSize = true;
            this.bt_Administration.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bt_Administration.FlatAppearance.BorderSize = 0;
            this.bt_Administration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Administration.Image = global::ClubVideo.Properties.Resources.Administration;
            this.bt_Administration.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bt_Administration.Location = new System.Drawing.Point(465, -2);
            this.bt_Administration.Margin = new System.Windows.Forms.Padding(2);
            this.bt_Administration.Name = "bt_Administration";
            this.bt_Administration.Size = new System.Drawing.Size(118, 121);
            this.bt_Administration.TabIndex = 0;
            this.bt_Administration.Text = "administration";
            this.bt_Administration.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bt_Administration.UseVisualStyleBackColor = true;
            this.bt_Administration.TextChanged += new System.EventHandler(this.Button_Permissions);
            this.bt_Administration.Click += new System.EventHandler(this.bt_Administration_Click);
            // 
            // bt_SearchMembers
            // 
            this.bt_SearchMembers.AutoSize = true;
            this.bt_SearchMembers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bt_SearchMembers.FlatAppearance.BorderSize = 0;
            this.bt_SearchMembers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_SearchMembers.Image = global::ClubVideo.Properties.Resources.Search_Member;
            this.bt_SearchMembers.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bt_SearchMembers.Location = new System.Drawing.Point(286, -2);
            this.bt_SearchMembers.Margin = new System.Windows.Forms.Padding(2);
            this.bt_SearchMembers.Name = "bt_SearchMembers";
            this.bt_SearchMembers.Size = new System.Drawing.Size(118, 121);
            this.bt_SearchMembers.TabIndex = 0;
            this.bt_SearchMembers.Text = "search Members";
            this.bt_SearchMembers.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bt_SearchMembers.UseVisualStyleBackColor = true;
            this.bt_SearchMembers.TextChanged += new System.EventHandler(this.Button_Permissions);
            this.bt_SearchMembers.Click += new System.EventHandler(this.bt_SearchMembers_Click);
            // 
            // bt_Logout
            // 
            this.bt_Logout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bt_Logout.FlatAppearance.BorderSize = 0;
            this.bt_Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Logout.Image = global::ClubVideo.Properties.Resources.Logout;
            this.bt_Logout.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bt_Logout.Location = new System.Drawing.Point(744, -2);
            this.bt_Logout.Margin = new System.Windows.Forms.Padding(2);
            this.bt_Logout.Name = "bt_Logout";
            this.bt_Logout.Size = new System.Drawing.Size(118, 121);
            this.bt_Logout.TabIndex = 0;
            this.bt_Logout.Text = "logout";
            this.bt_Logout.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bt_Logout.UseVisualStyleBackColor = true;
            this.bt_Logout.Click += new System.EventHandler(this.bt_Logout_Click);
            // 
            // bt_Exit
            // 
            this.bt_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bt_Exit.FlatAppearance.BorderSize = 0;
            this.bt_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Exit.Image = global::ClubVideo.Properties.Resources.Exit;
            this.bt_Exit.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.bt_Exit.Location = new System.Drawing.Point(866, -2);
            this.bt_Exit.Margin = new System.Windows.Forms.Padding(2);
            this.bt_Exit.Name = "bt_Exit";
            this.bt_Exit.Size = new System.Drawing.Size(118, 121);
            this.bt_Exit.TabIndex = 0;
            this.bt_Exit.Text = "exit";
            this.bt_Exit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bt_Exit.UseVisualStyleBackColor = true;
            this.bt_Exit.TextChanged += new System.EventHandler(this.Button_Permissions);
            this.bt_Exit.Click += new System.EventHandler(this.bt_Exit_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ClubVideo.Properties.Resources.Line1;
            this.pictureBox2.Location = new System.Drawing.Point(121, -2);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(39, 121);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // Main_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 119);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bt_Settings);
            this.Controls.Add(this.bt_POS);
            this.Controls.Add(this.bt_SearchMovies);
            this.Controls.Add(this.bt_Administration);
            this.Controls.Add(this.bt_SearchMembers);
            this.Controls.Add(this.bt_Logout);
            this.Controls.Add(this.bt_Exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_Menu_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_Exit;
        private System.Windows.Forms.Button bt_Logout;
        private System.Windows.Forms.Button bt_Settings;
        private System.Windows.Forms.Button bt_POS;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bt_Administration;
        private System.Windows.Forms.Button bt_SearchMembers;
        private System.Windows.Forms.Button bt_SearchMovies;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

