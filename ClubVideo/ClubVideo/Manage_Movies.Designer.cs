namespace ClubVideo
{
    partial class Manage_Movies
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
            this.tb_Search = new System.Windows.Forms.TextBox();
            this.dgv_SearchResults = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SearchResults)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search :";
            // 
            // tb_Search
            // 
            this.tb_Search.Location = new System.Drawing.Point(66, 45);
            this.tb_Search.Name = "tb_Search";
            this.tb_Search.Size = new System.Drawing.Size(100, 20);
            this.tb_Search.TabIndex = 1;
            this.tb_Search.TextChanged += new System.EventHandler(this.tb_Search_TextChanged);
            // 
            // dgv_SearchResults
            // 
            this.dgv_SearchResults.AccessibleName = "";
            this.dgv_SearchResults.AllowUserToAddRows = false;
            this.dgv_SearchResults.AllowUserToDeleteRows = false;
            this.dgv_SearchResults.AllowUserToOrderColumns = true;
            this.dgv_SearchResults.AllowUserToResizeRows = false;
            this.dgv_SearchResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_SearchResults.Location = new System.Drawing.Point(12, 71);
            this.dgv_SearchResults.Name = "dgv_SearchResults";
            this.dgv_SearchResults.ReadOnly = true;
            this.dgv_SearchResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_SearchResults.Size = new System.Drawing.Size(692, 369);
            this.dgv_SearchResults.TabIndex = 2;
            this.dgv_SearchResults.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgv_SearchResults_MouseDoubleClick);
            // 
            // Manage_Movies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 452);
            this.Controls.Add(this.dgv_SearchResults);
            this.Controls.Add(this.tb_Search);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(732, 490);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(732, 490);
            this.Name = "Manage_Movies";
            this.Text = "Manage_Movies";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SearchResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Search;
        private System.Windows.Forms.DataGridView dgv_SearchResults;
    }
}