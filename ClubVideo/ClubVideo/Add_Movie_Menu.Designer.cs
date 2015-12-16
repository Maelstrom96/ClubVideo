namespace ClubVideo
{
    partial class Add_Movie_Menu
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
            this.rb_IMDB = new System.Windows.Forms.RadioButton();
            this.rb_Manual = new System.Windows.Forms.RadioButton();
            this.bt_Cancel = new System.Windows.Forms.Button();
            this.bt_OK = new System.Windows.Forms.Button();
            this.lb_Url = new System.Windows.Forms.Label();
            this.tb_Url = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // rb_IMDB
            // 
            this.rb_IMDB.AutoSize = true;
            this.rb_IMDB.Location = new System.Drawing.Point(27, 26);
            this.rb_IMDB.Name = "rb_IMDB";
            this.rb_IMDB.Size = new System.Drawing.Size(84, 17);
            this.rb_IMDB.TabIndex = 0;
            this.rb_IMDB.TabStop = true;
            this.rb_IMDB.Text = "IMDB Import";
            this.rb_IMDB.UseVisualStyleBackColor = true;
            this.rb_IMDB.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rb_Manual
            // 
            this.rb_Manual.AutoSize = true;
            this.rb_Manual.Location = new System.Drawing.Point(27, 61);
            this.rb_Manual.Name = "rb_Manual";
            this.rb_Manual.Size = new System.Drawing.Size(92, 17);
            this.rb_Manual.TabIndex = 1;
            this.rb_Manual.TabStop = true;
            this.rb_Manual.Text = "Manual Import";
            this.rb_Manual.UseVisualStyleBackColor = true;
            // 
            // bt_Cancel
            // 
            this.bt_Cancel.Location = new System.Drawing.Point(36, 105);
            this.bt_Cancel.Name = "bt_Cancel";
            this.bt_Cancel.Size = new System.Drawing.Size(96, 32);
            this.bt_Cancel.TabIndex = 2;
            this.bt_Cancel.Text = "cancel";
            this.bt_Cancel.UseVisualStyleBackColor = true;
            this.bt_Cancel.Click += new System.EventHandler(this.bt_Cancel_Click);
            // 
            // bt_OK
            // 
            this.bt_OK.Location = new System.Drawing.Point(150, 105);
            this.bt_OK.Name = "bt_OK";
            this.bt_OK.Size = new System.Drawing.Size(96, 32);
            this.bt_OK.TabIndex = 2;
            this.bt_OK.Text = "ok";
            this.bt_OK.UseVisualStyleBackColor = true;
            this.bt_OK.Click += new System.EventHandler(this.bt_OK_Click);
            // 
            // lb_Url
            // 
            this.lb_Url.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lb_Url.Location = new System.Drawing.Point(-14, 48);
            this.lb_Url.Name = "lb_Url";
            this.lb_Url.Size = new System.Drawing.Size(54, 23);
            this.lb_Url.TabIndex = 3;
            this.lb_Url.Text = "url";
            this.lb_Url.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lb_Url.Visible = false;
            // 
            // tb_Url
            // 
            this.tb_Url.Location = new System.Drawing.Point(46, 50);
            this.tb_Url.Name = "tb_Url";
            this.tb_Url.Size = new System.Drawing.Size(213, 20);
            this.tb_Url.TabIndex = 4;
            this.tb_Url.Visible = false;
            // 
            // Add_Movie_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 153);
            this.Controls.Add(this.tb_Url);
            this.Controls.Add(this.lb_Url);
            this.Controls.Add(this.bt_OK);
            this.Controls.Add(this.bt_Cancel);
            this.Controls.Add(this.rb_Manual);
            this.Controls.Add(this.rb_IMDB);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Add_Movie_Menu";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Add_Movie_Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rb_IMDB;
        private System.Windows.Forms.RadioButton rb_Manual;
        private System.Windows.Forms.Button bt_Cancel;
        private System.Windows.Forms.Button bt_OK;
        private System.Windows.Forms.Label lb_Url;
        private System.Windows.Forms.TextBox tb_Url;
    }
}