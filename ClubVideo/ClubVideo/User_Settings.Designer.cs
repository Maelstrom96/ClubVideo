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
            this.SuspendLayout();
            // 
            // bt_Save
            // 
            this.bt_Save.BackgroundImage = global::ClubVideo.Properties.Resources.Save;
            this.bt_Save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_Save.FlatAppearance.BorderSize = 0;
            this.bt_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Save.Location = new System.Drawing.Point(204, 352);
            this.bt_Save.Name = "bt_Save";
            this.bt_Save.Size = new System.Drawing.Size(75, 71);
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
            this.cb_LanguageSetting.FormattingEnabled = true;
            this.cb_LanguageSetting.Location = new System.Drawing.Point(100, 26);
            this.cb_LanguageSetting.Name = "cb_LanguageSetting";
            this.cb_LanguageSetting.Size = new System.Drawing.Size(48, 24);
            this.cb_LanguageSetting.Sorted = true;
            this.cb_LanguageSetting.TabIndex = 2;
            this.cb_LanguageSetting.SelectedIndexChanged += new System.EventHandler(this.cb_LanguageSetting_SelectedIndexChanged);
            // 
            // User_Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 435);
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
    }
}