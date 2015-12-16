namespace ClubVideo
{
    partial class InsertMovie
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lb_TitreEN = new System.Windows.Forms.Label();
            this.lb_DescEN = new System.Windows.Forms.Label();
            this.lb_DescFR = new System.Windows.Forms.Label();
            this.lb_Rating = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_Time = new System.Windows.Forms.Label();
            this.lb_TitreFR = new System.Windows.Forms.Label();
            this.lb_TxtEN = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lb_Date = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_Director = new System.Windows.Forms.Label();
            this.btn_Next = new System.Windows.Forms.Button();
            this.btn_Previous = new System.Windows.Forms.Button();
            this.btn_Modify = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(18, 18);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 241);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lb_TitreEN
            // 
            this.lb_TitreEN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_TitreEN.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lb_TitreEN.Font = new System.Drawing.Font("Franklin Gothic Medium", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TitreEN.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lb_TitreEN.Location = new System.Drawing.Point(188, 18);
            this.lb_TitreEN.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_TitreEN.Name = "lb_TitreEN";
            this.lb_TitreEN.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lb_TitreEN.Size = new System.Drawing.Size(293, 26);
            this.lb_TitreEN.TabIndex = 1;
            this.lb_TitreEN.Text = "titre";
            this.lb_TitreEN.UseMnemonic = false;
            this.lb_TitreEN.Click += new System.EventHandler(this.EditLabel_OnClick);
            // 
            // lb_DescEN
            // 
            this.lb_DescEN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_DescEN.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lb_DescEN.Font = new System.Drawing.Font("Franklin Gothic Medium", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_DescEN.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lb_DescEN.Location = new System.Drawing.Point(18, 288);
            this.lb_DescEN.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_DescEN.Name = "lb_DescEN";
            this.lb_DescEN.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lb_DescEN.Size = new System.Drawing.Size(463, 128);
            this.lb_DescEN.TabIndex = 1;
            this.lb_DescEN.Text = "Description EN";
            this.lb_DescEN.UseMnemonic = false;
            this.lb_DescEN.Click += new System.EventHandler(this.EditLabel_OnClick);
            // 
            // lb_DescFR
            // 
            this.lb_DescFR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_DescFR.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lb_DescFR.Font = new System.Drawing.Font("Franklin Gothic Medium", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_DescFR.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lb_DescFR.Location = new System.Drawing.Point(18, 448);
            this.lb_DescFR.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_DescFR.Name = "lb_DescFR";
            this.lb_DescFR.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lb_DescFR.Size = new System.Drawing.Size(463, 128);
            this.lb_DescFR.TabIndex = 1;
            this.lb_DescFR.Text = "Description FR";
            this.lb_DescFR.UseMnemonic = false;
            this.lb_DescFR.Click += new System.EventHandler(this.EditLabel_OnClick);
            // 
            // lb_Rating
            // 
            this.lb_Rating.Location = new System.Drawing.Point(188, 81);
            this.lb_Rating.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Rating.Name = "lb_Rating";
            this.lb_Rating.Size = new System.Drawing.Size(33, 14);
            this.lb_Rating.TabIndex = 2;
            this.lb_Rating.Text = "R";
            this.lb_Rating.Click += new System.EventHandler(this.EditLabel_OnClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(226, 79);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "|";
            // 
            // lb_Time
            // 
            this.lb_Time.Location = new System.Drawing.Point(240, 81);
            this.lb_Time.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Time.Name = "lb_Time";
            this.lb_Time.Size = new System.Drawing.Size(59, 14);
            this.lb_Time.TabIndex = 2;
            this.lb_Time.Text = "R";
            this.lb_Time.Click += new System.EventHandler(this.EditLabel_OnClick);
            // 
            // lb_TitreFR
            // 
            this.lb_TitreFR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_TitreFR.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lb_TitreFR.Font = new System.Drawing.Font("Franklin Gothic Medium", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TitreFR.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lb_TitreFR.Location = new System.Drawing.Point(188, 47);
            this.lb_TitreFR.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_TitreFR.Name = "lb_TitreFR";
            this.lb_TitreFR.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lb_TitreFR.Size = new System.Drawing.Size(293, 26);
            this.lb_TitreFR.TabIndex = 1;
            this.lb_TitreFR.Text = "titre";
            this.lb_TitreFR.UseMnemonic = false;
            this.lb_TitreFR.Click += new System.EventHandler(this.EditLabel_OnClick);
            // 
            // lb_TxtEN
            // 
            this.lb_TxtEN.AutoSize = true;
            this.lb_TxtEN.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TxtEN.Location = new System.Drawing.Point(172, 33);
            this.lb_TxtEN.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_TxtEN.Name = "lb_TxtEN";
            this.lb_TxtEN.Size = new System.Drawing.Size(16, 9);
            this.lb_TxtEN.TabIndex = 4;
            this.lb_TxtEN.Text = "EN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(172, 63);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 9);
            this.label3.TabIndex = 4;
            this.label3.Text = "FR";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 437);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 9);
            this.label4.TabIndex = 4;
            this.label4.Text = "FR";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 277);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 9);
            this.label5.TabIndex = 4;
            this.label5.Text = "EN";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(-134, 681);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 9);
            this.label6.TabIndex = 4;
            this.label6.Text = "FR";
            // 
            // lb_Date
            // 
            this.lb_Date.Location = new System.Drawing.Point(313, 81);
            this.lb_Date.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Date.Name = "lb_Date";
            this.lb_Date.Size = new System.Drawing.Size(59, 14);
            this.lb_Date.TabIndex = 2;
            this.lb_Date.Text = "R";
            this.lb_Date.Click += new System.EventHandler(this.EditLabel_OnClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(298, 79);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(11, 17);
            this.label7.TabIndex = 3;
            this.label7.Text = "|";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(180, 141);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Director :";
            // 
            // lb_Director
            // 
            this.lb_Director.AutoSize = true;
            this.lb_Director.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Director.Location = new System.Drawing.Point(245, 141);
            this.lb_Director.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Director.Name = "lb_Director";
            this.lb_Director.Size = new System.Drawing.Size(18, 17);
            this.lb_Director.TabIndex = 5;
            this.lb_Director.Text = "D";
            this.lb_Director.Click += new System.EventHandler(this.EditLabel_OnClick);
            // 
            // btn_Next
            // 
            this.btn_Next.Location = new System.Drawing.Point(370, 219);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(75, 23);
            this.btn_Next.TabIndex = 6;
            this.btn_Next.Text = "Suivant";
            this.btn_Next.UseVisualStyleBackColor = true;
            this.btn_Next.Visible = false;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // btn_Previous
            // 
            this.btn_Previous.Location = new System.Drawing.Point(370, 262);
            this.btn_Previous.Name = "btn_Previous";
            this.btn_Previous.Size = new System.Drawing.Size(75, 23);
            this.btn_Previous.TabIndex = 7;
            this.btn_Previous.Text = "Precedent";
            this.btn_Previous.UseVisualStyleBackColor = true;
            this.btn_Previous.Visible = false;
            this.btn_Previous.Click += new System.EventHandler(this.btn_Previous_Click);
            // 
            // btn_Modify
            // 
            this.btn_Modify.Location = new System.Drawing.Point(188, 263);
            this.btn_Modify.Name = "btn_Modify";
            this.btn_Modify.Size = new System.Drawing.Size(75, 23);
            this.btn_Modify.TabIndex = 8;
            this.btn_Modify.Text = "Modifier";
            this.btn_Modify.UseVisualStyleBackColor = true;
            this.btn_Modify.Visible = false;
            this.btn_Modify.Click += new System.EventHandler(this.btn_Modify_Click);
            // 
            // InsertMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 583);
            this.Controls.Add(this.btn_Modify);
            this.Controls.Add(this.btn_Previous);
            this.Controls.Add(this.btn_Next);
            this.Controls.Add(this.lb_Director);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lb_TxtEN);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_Date);
            this.Controls.Add(this.lb_Time);
            this.Controls.Add(this.lb_Rating);
            this.Controls.Add(this.lb_DescFR);
            this.Controls.Add(this.lb_DescEN);
            this.Controls.Add(this.lb_TitreFR);
            this.Controls.Add(this.lb_TitreEN);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InsertMovie";
            this.Text = "InsertMovie";
            this.Load += new System.EventHandler(this.InsertMovie_Load);
            this.Click += new System.EventHandler(this.InsertMovie_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lb_TitreEN;
        private System.Windows.Forms.Label lb_DescEN;
        private System.Windows.Forms.Label lb_DescFR;
        private System.Windows.Forms.Label lb_Rating;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_Time;
        private System.Windows.Forms.Label lb_TitreFR;
        private System.Windows.Forms.Label lb_TxtEN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lb_Date;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_Director;
        private System.Windows.Forms.Button btn_Next;
        private System.Windows.Forms.Button btn_Previous;
        private System.Windows.Forms.Button btn_Modify;
    }
}