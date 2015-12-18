namespace ClubVideo
{
    partial class LocationLists
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
            this.dgv_Locations = new System.Windows.Forms.DataGridView();
            this.btn_Quit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Locations)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Locations
            // 
            this.dgv_Locations.AllowUserToAddRows = false;
            this.dgv_Locations.AllowUserToDeleteRows = false;
            this.dgv_Locations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Locations.Location = new System.Drawing.Point(2, 1);
            this.dgv_Locations.Name = "dgv_Locations";
            this.dgv_Locations.ReadOnly = true;
            this.dgv_Locations.Size = new System.Drawing.Size(259, 492);
            this.dgv_Locations.TabIndex = 0;
            // 
            // btn_Quit
            // 
            this.btn_Quit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Quit.Location = new System.Drawing.Point(176, 499);
            this.btn_Quit.Name = "btn_Quit";
            this.btn_Quit.Size = new System.Drawing.Size(75, 23);
            this.btn_Quit.TabIndex = 1;
            this.btn_Quit.Text = "Quitter";
            this.btn_Quit.UseVisualStyleBackColor = true;
            // 
            // LocationLists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(263, 529);
            this.Controls.Add(this.btn_Quit);
            this.Controls.Add(this.dgv_Locations);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(279, 568);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(279, 568);
            this.Name = "LocationLists";
            this.Text = "LocationLists";
            this.Load += new System.EventHandler(this.LocationLists_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Locations)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Locations;
        private System.Windows.Forms.Button btn_Quit;
    }
}