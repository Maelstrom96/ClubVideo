namespace ClubVideo
{
    partial class CategoryCU
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
            this.lb_Name_Fr = new System.Windows.Forms.Label();
            this.tb_Name_Fr = new System.Windows.Forms.TextBox();
            this.bt_OK = new System.Windows.Forms.Button();
            this.lb_Name_En = new System.Windows.Forms.Label();
            this.tb_Name_En = new System.Windows.Forms.TextBox();
            this.lb_Description_Fr = new System.Windows.Forms.Label();
            this.lb_Description_En = new System.Windows.Forms.Label();
            this.lb_Price = new System.Windows.Forms.Label();
            this.tb_Price = new System.Windows.Forms.TextBox();
            this.tb_Description_En = new System.Windows.Forms.TextBox();
            this.tb_Description_Fr = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lb_Name_Fr
            // 
            this.lb_Name_Fr.Location = new System.Drawing.Point(4, 28);
            this.lb_Name_Fr.Name = "lb_Name_Fr";
            this.lb_Name_Fr.Size = new System.Drawing.Size(110, 17);
            this.lb_Name_Fr.TabIndex = 0;
            this.lb_Name_Fr.Text = "name_fr :";
            this.lb_Name_Fr.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tb_Name_Fr
            // 
            this.tb_Name_Fr.Location = new System.Drawing.Point(120, 25);
            this.tb_Name_Fr.Name = "tb_Name_Fr";
            this.tb_Name_Fr.Size = new System.Drawing.Size(181, 20);
            this.tb_Name_Fr.TabIndex = 1;
            // 
            // bt_OK
            // 
            this.bt_OK.Location = new System.Drawing.Point(239, 324);
            this.bt_OK.Name = "bt_OK";
            this.bt_OK.Size = new System.Drawing.Size(75, 23);
            this.bt_OK.TabIndex = 2;
            this.bt_OK.Text = "ok";
            this.bt_OK.UseVisualStyleBackColor = true;
            // 
            // lb_Name_En
            // 
            this.lb_Name_En.Location = new System.Drawing.Point(4, 54);
            this.lb_Name_En.Name = "lb_Name_En";
            this.lb_Name_En.Size = new System.Drawing.Size(110, 17);
            this.lb_Name_En.TabIndex = 0;
            this.lb_Name_En.Text = "name_en :";
            this.lb_Name_En.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tb_Name_En
            // 
            this.tb_Name_En.Location = new System.Drawing.Point(120, 51);
            this.tb_Name_En.Name = "tb_Name_En";
            this.tb_Name_En.Size = new System.Drawing.Size(181, 20);
            this.tb_Name_En.TabIndex = 1;
            // 
            // lb_Description_Fr
            // 
            this.lb_Description_Fr.Location = new System.Drawing.Point(4, 97);
            this.lb_Description_Fr.Name = "lb_Description_Fr";
            this.lb_Description_Fr.Size = new System.Drawing.Size(110, 17);
            this.lb_Description_Fr.TabIndex = 0;
            this.lb_Description_Fr.Text = "decription_fr :";
            this.lb_Description_Fr.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lb_Description_En
            // 
            this.lb_Description_En.Location = new System.Drawing.Point(4, 187);
            this.lb_Description_En.Name = "lb_Description_En";
            this.lb_Description_En.Size = new System.Drawing.Size(110, 17);
            this.lb_Description_En.TabIndex = 0;
            this.lb_Description_En.Text = "decription_en :";
            this.lb_Description_En.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lb_Price
            // 
            this.lb_Price.Location = new System.Drawing.Point(123, 286);
            this.lb_Price.Name = "lb_Price";
            this.lb_Price.Size = new System.Drawing.Size(110, 17);
            this.lb_Price.TabIndex = 0;
            this.lb_Price.Text = "price :";
            this.lb_Price.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tb_Price
            // 
            this.tb_Price.Location = new System.Drawing.Point(239, 283);
            this.tb_Price.Name = "tb_Price";
            this.tb_Price.Size = new System.Drawing.Size(62, 20);
            this.tb_Price.TabIndex = 1;
            // 
            // tb_Description_En
            // 
            this.tb_Description_En.Location = new System.Drawing.Point(120, 184);
            this.tb_Description_En.Multiline = true;
            this.tb_Description_En.Name = "tb_Description_En";
            this.tb_Description_En.Size = new System.Drawing.Size(181, 78);
            this.tb_Description_En.TabIndex = 1;
            // 
            // tb_Description_Fr
            // 
            this.tb_Description_Fr.Location = new System.Drawing.Point(120, 94);
            this.tb_Description_Fr.Multiline = true;
            this.tb_Description_Fr.Name = "tb_Description_Fr";
            this.tb_Description_Fr.Size = new System.Drawing.Size(181, 78);
            this.tb_Description_Fr.TabIndex = 1;
            // 
            // CategoryCU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 352);
            this.Controls.Add(this.bt_OK);
            this.Controls.Add(this.tb_Price);
            this.Controls.Add(this.lb_Price);
            this.Controls.Add(this.tb_Description_Fr);
            this.Controls.Add(this.tb_Description_En);
            this.Controls.Add(this.lb_Description_En);
            this.Controls.Add(this.lb_Description_Fr);
            this.Controls.Add(this.tb_Name_En);
            this.Controls.Add(this.lb_Name_En);
            this.Controls.Add(this.tb_Name_Fr);
            this.Controls.Add(this.lb_Name_Fr);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CategoryCU";
            this.Text = "CategoryCU";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Name_Fr;
        private System.Windows.Forms.TextBox tb_Name_Fr;
        private System.Windows.Forms.Button bt_OK;
        private System.Windows.Forms.Label lb_Name_En;
        private System.Windows.Forms.TextBox tb_Name_En;
        private System.Windows.Forms.Label lb_Description_Fr;
        private System.Windows.Forms.Label lb_Description_En;
        private System.Windows.Forms.Label lb_Price;
        private System.Windows.Forms.TextBox tb_Price;
        private System.Windows.Forms.TextBox tb_Description_En;
        private System.Windows.Forms.TextBox tb_Description_Fr;
    }
}