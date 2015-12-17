namespace ClubVideo
{
    partial class Manage_Members
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
            this.components = new System.ComponentModel.Container();
            this.lb_Search = new System.Windows.Forms.Label();
            this.tb_Search = new System.Windows.Forms.TextBox();
            this.dgv_SearchResults = new System.Windows.Forms.DataGridView();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Modify = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SearchResults)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_Search
            // 
            this.lb_Search.Location = new System.Drawing.Point(436, 45);
            this.lb_Search.Name = "lb_Search";
            this.lb_Search.Size = new System.Drawing.Size(86, 15);
            this.lb_Search.TabIndex = 0;
            this.lb_Search.Text = "Search :";
            this.lb_Search.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tb_Search
            // 
            this.tb_Search.Location = new System.Drawing.Point(524, 43);
            this.tb_Search.Name = "tb_Search";
            this.tb_Search.Size = new System.Drawing.Size(171, 20);
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
            this.dgv_SearchResults.SelectionChanged += new System.EventHandler(this.dgv_SearchResults_SelectionChanged);
            this.dgv_SearchResults.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgv_SearchResults_MouseDoubleClick);
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackgroundImage = global::ClubVideo.Properties.Resources.member_delete;
            this.btn_Delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Delete.FlatAppearance.BorderSize = 0;
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Delete.Location = new System.Drawing.Point(125, 6);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(53, 57);
            this.btn_Delete.TabIndex = 6;
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Modify
            // 
            this.btn_Modify.BackgroundImage = global::ClubVideo.Properties.Resources.member_edit;
            this.btn_Modify.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Modify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Modify.FlatAppearance.BorderSize = 0;
            this.btn_Modify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Modify.Location = new System.Drawing.Point(68, 6);
            this.btn_Modify.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Modify.Name = "btn_Modify";
            this.btn_Modify.Size = new System.Drawing.Size(53, 57);
            this.btn_Modify.TabIndex = 6;
            this.btn_Modify.UseVisualStyleBackColor = true;
            this.btn_Modify.Click += new System.EventHandler(this.btn_Modify_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.BackgroundImage = global::ClubVideo.Properties.Resources.member_add;
            this.btn_Add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Add.FlatAppearance.BorderSize = 0;
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add.Location = new System.Drawing.Point(11, 6);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(53, 57);
            this.btn_Add.TabIndex = 6;
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // Manage_Members
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 451);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_Modify);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.dgv_SearchResults);
            this.Controls.Add(this.tb_Search);
            this.Controls.Add(this.lb_Search);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(732, 490);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(732, 490);
            this.Name = "Manage_Members";
            this.Text = "Manage_Members";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SearchResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Search;
        private System.Windows.Forms.TextBox tb_Search;
        private System.Windows.Forms.DataGridView dgv_SearchResults;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Modify;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.ToolTip toolTip;
    }
}