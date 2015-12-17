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
            this.dgv_View = new System.Windows.Forms.DataGridView();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Modify = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.tb_Search = new System.Windows.Forms.TextBox();
            this.lb_Search = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_View
            // 
            this.dgv_View.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_View.Location = new System.Drawing.Point(12, 68);
            this.dgv_View.Name = "dgv_View";
            this.dgv_View.Size = new System.Drawing.Size(470, 340);
            this.dgv_View.TabIndex = 0;
            // 
            // btn_Add
            // 
            this.btn_Add.BackgroundImage = global::ClubVideo.Properties.Resources.member_add;
            this.btn_Add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Add.FlatAppearance.BorderSize = 0;
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add.Location = new System.Drawing.Point(12, 6);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(53, 57);
            this.btn_Add.TabIndex = 7;
            this.btn_Add.UseVisualStyleBackColor = true;
            // 
            // btn_Modify
            // 
            this.btn_Modify.BackgroundImage = global::ClubVideo.Properties.Resources.member_edit;
            this.btn_Modify.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Modify.FlatAppearance.BorderSize = 0;
            this.btn_Modify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Modify.Location = new System.Drawing.Point(69, 6);
            this.btn_Modify.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Modify.Name = "btn_Modify";
            this.btn_Modify.Size = new System.Drawing.Size(53, 57);
            this.btn_Modify.TabIndex = 8;
            this.btn_Modify.UseVisualStyleBackColor = true;
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackgroundImage = global::ClubVideo.Properties.Resources.member_delete;
            this.btn_Delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Delete.FlatAppearance.BorderSize = 0;
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Delete.Location = new System.Drawing.Point(126, 6);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(53, 57);
            this.btn_Delete.TabIndex = 9;
            this.btn_Delete.UseVisualStyleBackColor = true;
            // 
            // tb_Search
            // 
            this.tb_Search.Location = new System.Drawing.Point(312, 42);
            this.tb_Search.Name = "tb_Search";
            this.tb_Search.Size = new System.Drawing.Size(171, 20);
            this.tb_Search.TabIndex = 11;
            // 
            // lb_Search
            // 
            this.lb_Search.Location = new System.Drawing.Point(224, 44);
            this.lb_Search.Name = "lb_Search";
            this.lb_Search.Size = new System.Drawing.Size(86, 15);
            this.lb_Search.TabIndex = 10;
            this.lb_Search.Text = "Search :";
            this.lb_Search.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Manage_Categories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 420);
            this.Controls.Add(this.tb_Search);
            this.Controls.Add(this.lb_Search);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_Modify);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.dgv_View);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Manage_Categories";
            this.Text = "Manage_Categories";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_View;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Modify;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.TextBox tb_Search;
        private System.Windows.Forms.Label lb_Search;
    }
}