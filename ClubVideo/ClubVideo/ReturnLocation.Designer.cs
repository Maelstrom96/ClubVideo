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
            this.txb_Return = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Return = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txb_Return
            // 
            this.txb_Return.Location = new System.Drawing.Point(97, 16);
            this.txb_Return.Name = "txb_Return";
            this.txb_Return.Size = new System.Drawing.Size(100, 20);
            this.txb_Return.TabIndex = 0;
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
            // ReturnLocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 88);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Return);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txb_Return);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(245, 127);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(245, 127);
            this.Name = "ReturnLocation";
            this.Text = "ReturnLocation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txb_Return;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Return;
        private System.Windows.Forms.Button btn_Cancel;
    }
}