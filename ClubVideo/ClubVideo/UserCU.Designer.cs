namespace ClubVideo
{
    partial class UserCU
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
            this.lb_Username = new System.Windows.Forms.Label();
            this.tb_Username = new System.Windows.Forms.TextBox();
            this.lb_Name = new System.Windows.Forms.Label();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.lb_LastName = new System.Windows.Forms.Label();
            this.tb_LastName = new System.Windows.Forms.TextBox();
            this.lb_Password = new System.Windows.Forms.Label();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.lb_ConfPassword = new System.Windows.Forms.Label();
            this.tb_ConfPassword = new System.Windows.Forms.TextBox();
            this.lb_Line = new System.Windows.Forms.Label();
            this.lb_ResetPassword = new System.Windows.Forms.Label();
            this.bt_Finish = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_Username
            // 
            this.lb_Username.Location = new System.Drawing.Point(-3, 29);
            this.lb_Username.Name = "lb_Username";
            this.lb_Username.Size = new System.Drawing.Size(136, 19);
            this.lb_Username.TabIndex = 0;
            this.lb_Username.Text = "username :";
            this.lb_Username.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tb_Username
            // 
            this.tb_Username.Location = new System.Drawing.Point(139, 26);
            this.tb_Username.Name = "tb_Username";
            this.tb_Username.Size = new System.Drawing.Size(238, 22);
            this.tb_Username.TabIndex = 1;
            this.tb_Username.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Textbox_KeyDown);
            // 
            // lb_Name
            // 
            this.lb_Name.Location = new System.Drawing.Point(0, 72);
            this.lb_Name.Name = "lb_Name";
            this.lb_Name.Size = new System.Drawing.Size(133, 19);
            this.lb_Name.TabIndex = 0;
            this.lb_Name.Text = "name :";
            this.lb_Name.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tb_Name
            // 
            this.tb_Name.Location = new System.Drawing.Point(139, 69);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(238, 22);
            this.tb_Name.TabIndex = 2;
            this.tb_Name.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Textbox_KeyDown);
            // 
            // lb_LastName
            // 
            this.lb_LastName.Location = new System.Drawing.Point(0, 100);
            this.lb_LastName.Name = "lb_LastName";
            this.lb_LastName.Size = new System.Drawing.Size(133, 19);
            this.lb_LastName.TabIndex = 0;
            this.lb_LastName.Text = "last Name :";
            this.lb_LastName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tb_LastName
            // 
            this.tb_LastName.Location = new System.Drawing.Point(139, 97);
            this.tb_LastName.Name = "tb_LastName";
            this.tb_LastName.Size = new System.Drawing.Size(238, 22);
            this.tb_LastName.TabIndex = 3;
            this.tb_LastName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Textbox_KeyDown);
            // 
            // lb_Password
            // 
            this.lb_Password.Location = new System.Drawing.Point(3, 193);
            this.lb_Password.Name = "lb_Password";
            this.lb_Password.Size = new System.Drawing.Size(133, 19);
            this.lb_Password.TabIndex = 0;
            this.lb_Password.Text = "password :";
            this.lb_Password.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tb_Password
            // 
            this.tb_Password.Location = new System.Drawing.Point(139, 190);
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.PasswordChar = '●';
            this.tb_Password.Size = new System.Drawing.Size(238, 22);
            this.tb_Password.TabIndex = 4;
            this.tb_Password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Textbox_KeyDown);
            // 
            // lb_ConfPassword
            // 
            this.lb_ConfPassword.Location = new System.Drawing.Point(0, 221);
            this.lb_ConfPassword.Name = "lb_ConfPassword";
            this.lb_ConfPassword.Size = new System.Drawing.Size(136, 19);
            this.lb_ConfPassword.TabIndex = 0;
            this.lb_ConfPassword.Text = "confirm Password :";
            this.lb_ConfPassword.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tb_ConfPassword
            // 
            this.tb_ConfPassword.Location = new System.Drawing.Point(139, 218);
            this.tb_ConfPassword.Name = "tb_ConfPassword";
            this.tb_ConfPassword.PasswordChar = '●';
            this.tb_ConfPassword.Size = new System.Drawing.Size(238, 22);
            this.tb_ConfPassword.TabIndex = 5;
            this.tb_ConfPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Textbox_KeyDown);
            // 
            // lb_Line
            // 
            this.lb_Line.AutoSize = true;
            this.lb_Line.Location = new System.Drawing.Point(7, 135);
            this.lb_Line.Name = "lb_Line";
            this.lb_Line.Size = new System.Drawing.Size(384, 17);
            this.lb_Line.TabIndex = 2;
            this.lb_Line.Text = "_______________________________________________";
            // 
            // lb_ResetPassword
            // 
            this.lb_ResetPassword.Location = new System.Drawing.Point(12, 152);
            this.lb_ResetPassword.Name = "lb_ResetPassword";
            this.lb_ResetPassword.Size = new System.Drawing.Size(379, 23);
            this.lb_ResetPassword.TabIndex = 5;
            this.lb_ResetPassword.Text = "reset Password";
            this.lb_ResetPassword.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lb_ResetPassword.Visible = false;
            // 
            // bt_Finish
            // 
            this.bt_Finish.BackgroundImage = global::ClubVideo.Properties.Resources.AddUser;
            this.bt_Finish.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_Finish.FlatAppearance.BorderSize = 0;
            this.bt_Finish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Finish.Location = new System.Drawing.Point(303, 288);
            this.bt_Finish.Name = "bt_Finish";
            this.bt_Finish.Size = new System.Drawing.Size(86, 82);
            this.bt_Finish.TabIndex = 4;
            this.bt_Finish.TabStop = false;
            this.bt_Finish.UseVisualStyleBackColor = true;
            this.bt_Finish.Click += new System.EventHandler(this.bt_Finish_Click);
            // 
            // UserCU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 383);
            this.Controls.Add(this.lb_ResetPassword);
            this.Controls.Add(this.bt_Finish);
            this.Controls.Add(this.lb_Line);
            this.Controls.Add(this.tb_ConfPassword);
            this.Controls.Add(this.lb_ConfPassword);
            this.Controls.Add(this.tb_Password);
            this.Controls.Add(this.lb_Password);
            this.Controls.Add(this.tb_LastName);
            this.Controls.Add(this.lb_LastName);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.lb_Name);
            this.Controls.Add(this.tb_Username);
            this.Controls.Add(this.lb_Username);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserCU";
            this.Text = "Add_User";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Username;
        private System.Windows.Forms.TextBox tb_Username;
        private System.Windows.Forms.Label lb_Name;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.Label lb_LastName;
        private System.Windows.Forms.TextBox tb_LastName;
        private System.Windows.Forms.Label lb_Password;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.Label lb_ConfPassword;
        private System.Windows.Forms.TextBox tb_ConfPassword;
        private System.Windows.Forms.Label lb_Line;
        private System.Windows.Forms.Button bt_Finish;
        private System.Windows.Forms.Label lb_ResetPassword;
    }
}