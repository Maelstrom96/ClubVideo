namespace ClubVideo
{
    partial class ReturnLocation
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Return = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.cb_Returns = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID de la copie :";
            // 
            // btn_Return
            // 
            this.btn_Return.Location = new System.Drawing.Point(122, 51);
            this.btn_Return.Name = "btn_Return";
            this.btn_Return.Size = new System.Drawing.Size(75, 23);
            this.btn_Return.TabIndex = 2;
            this.btn_Return.Text = "Retourner";
            this.btn_Return.UseVisualStyleBackColor = true;
            this.btn_Return.Click += new System.EventHandler(this.btn_Return_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.Location = new System.Drawing.Point(32, 51);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 2;
            this.btn_Cancel.Text = "Annuler";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // cb_Returns
            // 
            this.cb_Returns.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Returns.FormattingEnabled = true;
            this.cb_Returns.Location = new System.Drawing.Point(97, 16);
            this.cb_Returns.Name = "cb_Returns";
            this.cb_Returns.Size = new System.Drawing.Size(121, 21);
            this.cb_Returns.TabIndex = 3;
            // 
            // ReturnLocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(229, 88);
            this.Controls.Add(this.cb_Returns);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Return);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(245, 127);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(245, 127);
            this.Name = "ReturnLocation";
            this.Text = "ReturnLocation";
            this.Load += new System.EventHandler(this.ReturnLocation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Return;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.ComboBox cb_Returns;
    }
}