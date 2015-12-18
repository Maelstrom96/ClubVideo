namespace ClubVideo
{
    partial class Manage_Categories
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
            this.dgv_View = new System.Windows.Forms.DataGridView();
            this.tb_Search = new System.Windows.Forms.TextBox();
            this.lb_Search = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.bt_AddCategory = new System.Windows.Forms.Button();
            this.bt_EditCategory = new System.Windows.Forms.Button();
            this.bt_DeleteCategory = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_View
            // 
            this.dgv_View.AllowUserToAddRows = false;
            this.dgv_View.AllowUserToDeleteRows = false;
            this.dgv_View.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_View.Location = new System.Drawing.Point(0, 59);
            this.dgv_View.MultiSelect = false;
            this.dgv_View.Name = "dgv_View";
            this.dgv_View.ReadOnly = true;
            this.dgv_View.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_View.Size = new System.Drawing.Size(732, 361);
            this.dgv_View.TabIndex = 0;
            // 
            // tb_Search
            // 
            this.tb_Search.Location = new System.Drawing.Point(549, 33);
            this.tb_Search.Name = "tb_Search";
            this.tb_Search.Size = new System.Drawing.Size(171, 20);
            this.tb_Search.TabIndex = 11;
            // 
            // lb_Search
            // 
            this.lb_Search.Location = new System.Drawing.Point(461, 35);
            this.lb_Search.Name = "lb_Search";
            this.lb_Search.Size = new System.Drawing.Size(86, 15);
            this.lb_Search.TabIndex = 10;
            this.lb_Search.Text = "Search :";
            this.lb_Search.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // bt_AddCategory
            // 
            this.bt_AddCategory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_AddCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_AddCategory.FlatAppearance.BorderSize = 0;
            this.bt_AddCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_AddCategory.Image = global::ClubVideo.Properties.Resources.AddCategory;
            this.bt_AddCategory.Location = new System.Drawing.Point(1, 2);
            this.bt_AddCategory.Margin = new System.Windows.Forms.Padding(2);
            this.bt_AddCategory.Name = "bt_AddCategory";
            this.bt_AddCategory.Size = new System.Drawing.Size(53, 57);
            this.bt_AddCategory.TabIndex = 7;
            this.bt_AddCategory.UseVisualStyleBackColor = true;
            this.bt_AddCategory.Click += new System.EventHandler(this.btn_Add_Click);
            this.bt_AddCategory.MouseEnter += new System.EventHandler(this.bt_MouseEnter);
            this.bt_AddCategory.MouseLeave += new System.EventHandler(this.bt_MouseLeave);
            // 
            // bt_EditCategory
            // 
            this.bt_EditCategory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_EditCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_EditCategory.FlatAppearance.BorderSize = 0;
            this.bt_EditCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_EditCategory.Image = global::ClubVideo.Properties.Resources.EditCategory;
            this.bt_EditCategory.Location = new System.Drawing.Point(58, 2);
            this.bt_EditCategory.Margin = new System.Windows.Forms.Padding(2);
            this.bt_EditCategory.Name = "bt_EditCategory";
            this.bt_EditCategory.Size = new System.Drawing.Size(53, 57);
            this.bt_EditCategory.TabIndex = 8;
            this.bt_EditCategory.UseVisualStyleBackColor = true;
            this.bt_EditCategory.Click += new System.EventHandler(this.btn_Modify_Click);
            this.bt_EditCategory.MouseEnter += new System.EventHandler(this.bt_MouseEnter);
            this.bt_EditCategory.MouseLeave += new System.EventHandler(this.bt_MouseLeave);
            // 
            // bt_DeleteCategory
            // 
            this.bt_DeleteCategory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_DeleteCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_DeleteCategory.FlatAppearance.BorderSize = 0;
            this.bt_DeleteCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_DeleteCategory.Image = global::ClubVideo.Properties.Resources.DeleteCategory;
            this.bt_DeleteCategory.Location = new System.Drawing.Point(115, 2);
            this.bt_DeleteCategory.Margin = new System.Windows.Forms.Padding(2);
            this.bt_DeleteCategory.Name = "bt_DeleteCategory";
            this.bt_DeleteCategory.Size = new System.Drawing.Size(53, 57);
            this.bt_DeleteCategory.TabIndex = 9;
            this.bt_DeleteCategory.UseVisualStyleBackColor = true;
            this.bt_DeleteCategory.Click += new System.EventHandler(this.btn_Delete_Click);
            this.bt_DeleteCategory.MouseEnter += new System.EventHandler(this.bt_MouseEnter);
            this.bt_DeleteCategory.MouseLeave += new System.EventHandler(this.bt_MouseLeave);
            // 
            // Manage_Categories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 420);
            this.Controls.Add(this.tb_Search);
            this.Controls.Add(this.lb_Search);
            this.Controls.Add(this.bt_AddCategory);
            this.Controls.Add(this.bt_EditCategory);
            this.Controls.Add(this.bt_DeleteCategory);
            this.Controls.Add(this.dgv_View);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(748, 459);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(748, 459);
            this.Name = "Manage_Categories";
            this.Text = "Manage_Categories";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_View;
        private System.Windows.Forms.Button bt_AddCategory;
        private System.Windows.Forms.Button bt_EditCategory;
        private System.Windows.Forms.Button bt_DeleteCategory;
        private System.Windows.Forms.TextBox tb_Search;
        private System.Windows.Forms.Label lb_Search;
        private System.Windows.Forms.ToolTip toolTip;
    }
}