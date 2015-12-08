namespace ClubVideo
{
    partial class User_Settings
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
            this.B_lang = new System.Windows.Forms.Button();
            this.B_password = new System.Windows.Forms.Button();
            this.B_fonts = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // B_lang
            // 
            this.B_lang.BackColor = System.Drawing.Color.White;
            this.B_lang.BackgroundImage = global::ClubVideo.Properties.Resources.lang;
            this.B_lang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.B_lang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.B_lang.FlatAppearance.BorderSize = 0;
            this.B_lang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_lang.Location = new System.Drawing.Point(0, 0);
            this.B_lang.Name = "B_lang";
            this.B_lang.Size = new System.Drawing.Size(200, 200);
            this.B_lang.TabIndex = 11;
            this.B_lang.UseVisualStyleBackColor = false;
            this.B_lang.Click += new System.EventHandler(this.Button_Click);
            this.B_lang.MouseEnter += new System.EventHandler(this.Button_Enter);
            this.B_lang.MouseLeave += new System.EventHandler(this.Button_Leave);
            // 
            // B_password
            // 
            this.B_password.BackColor = System.Drawing.Color.White;
            this.B_password.BackgroundImage = global::ClubVideo.Properties.Resources.password;
            this.B_password.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.B_password.Cursor = System.Windows.Forms.Cursors.Hand;
            this.B_password.FlatAppearance.BorderSize = 0;
            this.B_password.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_password.Location = new System.Drawing.Point(200, 0);
            this.B_password.Name = "B_password";
            this.B_password.Size = new System.Drawing.Size(200, 200);
            this.B_password.TabIndex = 12;
            this.B_password.UseVisualStyleBackColor = false;
            this.B_password.Click += new System.EventHandler(this.Button_Click);
            this.B_password.MouseEnter += new System.EventHandler(this.Button_Enter);
            this.B_password.MouseLeave += new System.EventHandler(this.Button_Leave);
            // 
            // B_fonts
            // 
            this.B_fonts.BackColor = System.Drawing.Color.White;
            this.B_fonts.BackgroundImage = global::ClubVideo.Properties.Resources.fonts;
            this.B_fonts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.B_fonts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.B_fonts.FlatAppearance.BorderSize = 0;
            this.B_fonts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_fonts.Location = new System.Drawing.Point(400, 0);
            this.B_fonts.Name = "B_fonts";
            this.B_fonts.Size = new System.Drawing.Size(200, 200);
            this.B_fonts.TabIndex = 13;
            this.B_fonts.UseVisualStyleBackColor = false;
            this.B_fonts.Click += new System.EventHandler(this.Button_Click);
            this.B_fonts.MouseEnter += new System.EventHandler(this.Button_Enter);
            this.B_fonts.MouseLeave += new System.EventHandler(this.Button_Leave);
            // 
            // User_Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 199);
            this.Controls.Add(this.B_fonts);
            this.Controls.Add(this.B_password);
            this.Controls.Add(this.B_lang);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "User_Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User_Settings";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button B_lang;
        private System.Windows.Forms.Button B_password;
        private System.Windows.Forms.Button B_fonts;
    }
}