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
            this.bt_ManageMovies = new System.Windows.Forms.Button();
            this.bt_Administration = new System.Windows.Forms.Button();
            this.bt_ManageMembers = new System.Windows.Forms.Button();
            this.bt_Logout = new System.Windows.Forms.Button();
            this.bt_Exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ClubVideo.Properties.Resources.Line1;
            this.pictureBox1.Location = new System.Drawing.Point(893, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 134);
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
            this.bt_Settings.Location = new System.Drawing.Point(763, -2);
            this.bt_Settings.Name = "bt_Settings";
            this.bt_Settings.Size = new System.Drawing.Size(134, 134);
            this.bt_Settings.TabIndex = 0;
            this.bt_Settings.Text = "settings";
            this.bt_Settings.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bt_Settings.UseVisualStyleBackColor = true;
            this.bt_Settings.TextChanged += new System.EventHandler(this.Button_Permissions);
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
            this.bt_POS.Name = "bt_POS";
            this.bt_POS.Size = new System.Drawing.Size(134, 134);
            this.bt_POS.TabIndex = 0;
            this.bt_POS.Text = "pos";
            this.bt_POS.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bt_POS.UseVisualStyleBackColor = true;
            this.bt_POS.TextChanged += new System.EventHandler(this.Button_Permissions);
            // 
            // bt_ManageMovies
            // 
            this.bt_ManageMovies.AutoSize = true;
            this.bt_ManageMovies.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bt_ManageMovies.FlatAppearance.BorderSize = 0;
            this.bt_ManageMovies.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_ManageMovies.Image = global::ClubVideo.Properties.Resources.ManageMovies;
            this.bt_ManageMovies.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bt_ManageMovies.Location = new System.Drawing.Point(343, -2);
            this.bt_ManageMovies.Name = "bt_ManageMovies";
            this.bt_ManageMovies.Size = new System.Drawing.Size(134, 134);
            this.bt_ManageMovies.TabIndex = 0;
            this.bt_ManageMovies.Text = "manage Movies";
            this.bt_ManageMovies.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bt_ManageMovies.UseVisualStyleBackColor = true;
            this.bt_ManageMovies.TextChanged += new System.EventHandler(this.Button_Permissions);
            // 
            // bt_Administration
            // 
            this.bt_Administration.AutoSize = true;
            this.bt_Administration.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bt_Administration.FlatAppearance.BorderSize = 0;
            this.bt_Administration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Administration.Image = global::ClubVideo.Properties.Resources.Administration;
            this.bt_Administration.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bt_Administration.Location = new System.Drawing.Point(623, -2);
            this.bt_Administration.Name = "bt_Administration";
            this.bt_Administration.Size = new System.Drawing.Size(134, 134);
            this.bt_Administration.TabIndex = 0;
            this.bt_Administration.Text = "administration";
            this.bt_Administration.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bt_Administration.UseVisualStyleBackColor = true;
            this.bt_Administration.TextChanged += new System.EventHandler(this.Button_Permissions);
            // 
            // bt_ManageMembers
            // 
            this.bt_ManageMembers.AutoSize = true;
            this.bt_ManageMembers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bt_ManageMembers.FlatAppearance.BorderSize = 0;
            this.bt_ManageMembers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_ManageMembers.Image = global::ClubVideo.Properties.Resources.ManageMembers;
            this.bt_ManageMembers.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bt_ManageMembers.Location = new System.Drawing.Point(483, -2);
            this.bt_ManageMembers.Name = "bt_ManageMembers";
            this.bt_ManageMembers.Size = new System.Drawing.Size(134, 134);
            this.bt_ManageMembers.TabIndex = 0;
            this.bt_ManageMembers.Text = "manage Members";
            this.bt_ManageMembers.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bt_ManageMembers.UseVisualStyleBackColor = true;
            this.bt_ManageMembers.TextChanged += new System.EventHandler(this.Button_Permissions);
            // 
            // bt_Logout
            // 
            this.bt_Logout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bt_Logout.FlatAppearance.BorderSize = 0;
            this.bt_Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Logout.Image = global::ClubVideo.Properties.Resources.Logout;
            this.bt_Logout.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bt_Logout.Location = new System.Drawing.Point(931, -2);
            this.bt_Logout.Name = "bt_Logout";
            this.bt_Logout.Size = new System.Drawing.Size(134, 134);
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
            this.bt_Exit.Location = new System.Drawing.Point(1065, -2);
            this.bt_Exit.Name = "bt_Exit";
            this.bt_Exit.Size = new System.Drawing.Size(134, 134);
            this.bt_Exit.TabIndex = 0;
            this.bt_Exit.Text = "exit";
            this.bt_Exit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bt_Exit.UseVisualStyleBackColor = true;
            this.bt_Exit.TextChanged += new System.EventHandler(this.Button_Permissions);
            this.bt_Exit.Click += new System.EventHandler(this.bt_Exit_Click);
            // 
            // Main_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 132);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bt_Settings);
            this.Controls.Add(this.bt_POS);
            this.Controls.Add(this.bt_ManageMovies);
            this.Controls.Add(this.bt_Administration);
            this.Controls.Add(this.bt_ManageMembers);
            this.Controls.Add(this.bt_Logout);
            this.Controls.Add(this.bt_Exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_Menu_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_Exit;
        private System.Windows.Forms.Button bt_Logout;
        private System.Windows.Forms.Button bt_ManageMembers;
        private System.Windows.Forms.Button bt_Settings;
        private System.Windows.Forms.Button bt_POS;
        private System.Windows.Forms.Button bt_ManageMovies;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bt_Administration;
    }
}

