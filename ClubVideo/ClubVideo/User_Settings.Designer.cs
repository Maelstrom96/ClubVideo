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
            this.bt_Save = new System.Windows.Forms.Button();
            this.lb_ChangeLanguageSetting = new System.Windows.Forms.Label();
            this.cb_LanguageSetting = new System.Windows.Forms.ComboBox();
            this.tb_ConfPassword = new System.Windows.Forms.TextBox();
            this.lb_ConfPassword = new System.Windows.Forms.Label();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.lb_Password = new System.Windows.Forms.Label();
            this.lb_ChangePassword = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bt_Save
            // 
            this.bt_Save.BackgroundImage = global::ClubVideo.Properties.Resources.Save;
            this.bt_Save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_Save.FlatAppearance.BorderSize = 0;
            this.bt_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Save.Location = new System.Drawing.Point(231, 371);
            this.bt_Save.Name = "bt_Save";
            this.bt_Save.Size = new System.Drawing.Size(72, 58);
            this.bt_Save.TabIndex = 0;
            this.bt_Save.UseVisualStyleBackColor = true;
            this.bt_Save.Click += new System.EventHandler(this.bt_Save_Click);
            // 
            // lb_ChangeLanguageSetting
            // 
            this.lb_ChangeLanguageSetting.AutoSize = true;
            this.lb_ChangeLanguageSetting.Location = new System.Drawing.Point(22, 29);
            this.lb_ChangeLanguageSetting.Name = "lb_ChangeLanguageSetting";
            this.lb_ChangeLanguageSetting.Size = new System.Drawing.Size(72, 17);
            this.lb_ChangeLanguageSetting.TabIndex = 1;
            this.lb_ChangeLanguageSetting.Text = "Language";
            this.lb_ChangeLanguageSetting.TextChanged += new System.EventHandler(this.lb_ChangeLanguageSetting_TextChanged);
            // 
            // cb_LanguageSetting
            // 
            this.cb_LanguageSetting.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_LanguageSetting.FormattingEnabled = true;
            this.cb_LanguageSetting.Location = new System.Drawing.Point(100, 26);
            this.cb_LanguageSetting.Name = "cb_LanguageSetting";
            this.cb_LanguageSetting.Size = new System.Drawing.Size(48, 24);
            this.cb_LanguageSetting.Sorted = true;
            this.cb_LanguageSetting.TabIndex = 2;
            this.cb_LanguageSetting.SelectedIndexChanged += new System.EventHandler(this.cb_LanguageSetting_SelectedIndexChanged);
            // 
            // tb_ConfPassword
            // 
            this.tb_ConfPassword.Location = new System.Drawing.Point(144, 330);
            this.tb_ConfPassword.Name = "tb_ConfPassword";
            this.tb_ConfPassword.PasswordChar = '●';
            this.tb_ConfPassword.Size = new System.Drawing.Size(159, 22);
            this.tb_ConfPassword.TabIndex = 9;
            // 
            // lb_ConfPassword
            // 
            this.lb_ConfPassword.Location = new System.Drawing.Point(5, 333);
            this.lb_ConfPassword.Name = "lb_ConfPassword";
            this.lb_ConfPassword.Size = new System.Drawing.Size(133, 19);
            this.lb_ConfPassword.TabIndex = 6;
            this.lb_ConfPassword.Text = "confirm Password :";
            this.lb_ConfPassword.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tb_Password
            // 
            this.tb_Password.Location = new System.Drawing.Point(144, 302);
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.PasswordChar = '●';
            this.tb_Password.Size = new System.Drawing.Size(159, 22);
            this.tb_Password.TabIndex = 8;
            // 
            // lb_Password
            // 
            this.lb_Password.Location = new System.Drawing.Point(8, 305);
            this.lb_Password.Name = "lb_Password";
            this.lb_Password.Size = new System.Drawing.Size(130, 19);
            this.lb_Password.TabIndex = 7;
            this.lb_Password.Text = "password :";
            this.lb_Password.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lb_ChangePassword
            // 
            this.lb_ChangePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ChangePassword.Location = new System.Drawing.Point(0, 265);
            this.lb_ChangePassword.Name = "lb_ChangePassword";
            this.lb_ChangePassword.Size = new System.Drawing.Size(314, 23);
            this.lb_ChangePassword.TabIndex = 10;
            this.lb_ChangePassword.Text = "Change Password";
            this.lb_ChangePassword.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // User_Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 441);
            this.Controls.Add(this.lb_ChangePassword);
            this.Controls.Add(this.tb_ConfPassword);
            this.Controls.Add(this.lb_ConfPassword);
            this.Controls.Add(this.tb_Password);
            this.Controls.Add(this.lb_Password);
            this.Controls.Add(this.cb_LanguageSetting);
            this.Controls.Add(this.lb_ChangeLanguageSetting);
            this.Controls.Add(this.bt_Save);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "User_Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User_Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_Save;
        private System.Windows.Forms.Label lb_ChangeLanguageSetting;
        private System.Windows.Forms.ComboBox cb_LanguageSetting;
        private System.Windows.Forms.TextBox tb_ConfPassword;
        private System.Windows.Forms.Label lb_ConfPassword;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.Label lb_Password;
        private System.Windows.Forms.Label lb_ChangePassword;
    }
}