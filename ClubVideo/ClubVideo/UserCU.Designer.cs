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
            this.bt_AddUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_Username
            // 
            this.lb_Username.Location = new System.Drawing.Point(-2, 24);
            this.lb_Username.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Username.Name = "lb_Username";
            this.lb_Username.Size = new System.Drawing.Size(102, 15);
            this.lb_Username.TabIndex = 0;
            this.lb_Username.Text = "username :";
            this.lb_Username.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tb_Username
            // 
            this.tb_Username.Location = new System.Drawing.Point(104, 21);
            this.tb_Username.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_Username.Name = "tb_Username";
            this.tb_Username.Size = new System.Drawing.Size(180, 20);
            this.tb_Username.TabIndex = 1;
            this.tb_Username.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Textbox_KeyDown);
            // 
            // lb_Name
            // 
            this.lb_Name.Location = new System.Drawing.Point(0, 58);
            this.lb_Name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Name.Name = "lb_Name";
            this.lb_Name.Size = new System.Drawing.Size(100, 15);
            this.lb_Name.TabIndex = 0;
            this.lb_Name.Text = "name :";
            this.lb_Name.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tb_Name
            // 
            this.tb_Name.Location = new System.Drawing.Point(104, 56);
            this.tb_Name.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(180, 20);
            this.tb_Name.TabIndex = 2;
            this.tb_Name.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Textbox_KeyDown);
            // 
            // lb_LastName
            // 
            this.lb_LastName.Location = new System.Drawing.Point(0, 81);
            this.lb_LastName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_LastName.Name = "lb_LastName";
            this.lb_LastName.Size = new System.Drawing.Size(100, 15);
            this.lb_LastName.TabIndex = 0;
            this.lb_LastName.Text = "last Name :";
            this.lb_LastName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tb_LastName
            // 
            this.tb_LastName.Location = new System.Drawing.Point(104, 79);
            this.tb_LastName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_LastName.Name = "tb_LastName";
            this.tb_LastName.Size = new System.Drawing.Size(180, 20);
            this.tb_LastName.TabIndex = 3;
            this.tb_LastName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Textbox_KeyDown);
            // 
            // lb_Password
            // 
            this.lb_Password.Location = new System.Drawing.Point(2, 163);
            this.lb_Password.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Password.Name = "lb_Password";
            this.lb_Password.Size = new System.Drawing.Size(100, 15);
            this.lb_Password.TabIndex = 0;
            this.lb_Password.Text = "password :";
            this.lb_Password.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tb_Password
            // 
            this.tb_Password.Location = new System.Drawing.Point(104, 160);
            this.tb_Password.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.PasswordChar = '●';
            this.tb_Password.Size = new System.Drawing.Size(180, 20);
            this.tb_Password.TabIndex = 4;
            this.tb_Password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Textbox_KeyDown);
            // 
            // lb_ConfPassword
            // 
            this.lb_ConfPassword.Location = new System.Drawing.Point(0, 186);
            this.lb_ConfPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_ConfPassword.Name = "lb_ConfPassword";
            this.lb_ConfPassword.Size = new System.Drawing.Size(102, 15);
            this.lb_ConfPassword.TabIndex = 0;
            this.lb_ConfPassword.Text = "confirm Password :";
            this.lb_ConfPassword.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tb_ConfPassword
            // 
            this.tb_ConfPassword.Location = new System.Drawing.Point(104, 183);
            this.tb_ConfPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_ConfPassword.Name = "tb_ConfPassword";
            this.tb_ConfPassword.PasswordChar = '●';
            this.tb_ConfPassword.Size = new System.Drawing.Size(180, 20);
            this.tb_ConfPassword.TabIndex = 5;
            this.tb_ConfPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Textbox_KeyDown);
            // 
            // lb_Line
            // 
            this.lb_Line.AutoSize = true;
            this.lb_Line.Location = new System.Drawing.Point(5, 118);
            this.lb_Line.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Line.Name = "lb_Line";
            this.lb_Line.Size = new System.Drawing.Size(289, 13);
            this.lb_Line.TabIndex = 2;
            this.lb_Line.Text = "_______________________________________________";
            // 
            // lb_ResetPassword
            // 
            this.lb_ResetPassword.Location = new System.Drawing.Point(9, 135);
            this.lb_ResetPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_ResetPassword.Name = "lb_ResetPassword";
            this.lb_ResetPassword.Size = new System.Drawing.Size(284, 19);
            this.lb_ResetPassword.TabIndex = 5;
            this.lb_ResetPassword.Text = "reset Password";
            this.lb_ResetPassword.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lb_ResetPassword.Visible = false;
            // 
            // bt_AddUser
            // 
            this.bt_AddUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bt_AddUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_AddUser.FlatAppearance.BorderSize = 0;
            this.bt_AddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_AddUser.Image = global::ClubVideo.Properties.Resources.AddUser;
            this.bt_AddUser.Location = new System.Drawing.Point(0, 244);
            this.bt_AddUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_AddUser.Name = "bt_AddUser";
            this.bt_AddUser.Size = new System.Drawing.Size(302, 67);
            this.bt_AddUser.TabIndex = 4;
            this.bt_AddUser.TabStop = false;
            this.bt_AddUser.UseVisualStyleBackColor = true;
            this.bt_AddUser.Click += new System.EventHandler(this.bt_Finish_Click);
            this.bt_AddUser.MouseEnter += new System.EventHandler(this.bt_Finish_MouseEnter);
            this.bt_AddUser.MouseLeave += new System.EventHandler(this.bt_Finish_MouseLeave);
            // 
            // UserCU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(302, 311);
            this.Controls.Add(this.lb_ResetPassword);
            this.Controls.Add(this.bt_AddUser);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.Button bt_AddUser;
        private System.Windows.Forms.Label lb_ResetPassword;
    }
}