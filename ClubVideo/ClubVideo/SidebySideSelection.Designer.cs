namespace ClubVideo
{
    partial class SidebySideSelection
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
            this.lv_Selection = new System.Windows.Forms.ListBox();
            this.lv_Selected = new System.Windows.Forms.ListBox();
            this.bt_Accept = new System.Windows.Forms.Button();
            this.bt_Remove = new System.Windows.Forms.Button();
            this.bt_Erase = new System.Windows.Forms.Button();
            this.bt_Add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lv_Selection
            // 
            this.lv_Selection.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_Selection.ItemHeight = 17;
            this.lv_Selection.Location = new System.Drawing.Point(12, 12);
            this.lv_Selection.Name = "lv_Selection";
            this.lv_Selection.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lv_Selection.Size = new System.Drawing.Size(355, 412);
            this.lv_Selection.Sorted = true;
            this.lv_Selection.TabIndex = 3;
            // 
            // lv_Selected
            // 
            this.lv_Selected.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_Selected.ItemHeight = 17;
            this.lv_Selected.Location = new System.Drawing.Point(469, 12);
            this.lv_Selected.Name = "lv_Selected";
            this.lv_Selected.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lv_Selected.Size = new System.Drawing.Size(355, 412);
            this.lv_Selected.Sorted = true;
            this.lv_Selected.TabIndex = 3;
            // 
            // bt_Accept
            // 
            this.bt_Accept.BackgroundImage = global::ClubVideo.Properties.Resources.Done;
            this.bt_Accept.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_Accept.FlatAppearance.BorderSize = 0;
            this.bt_Accept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Accept.Location = new System.Drawing.Point(390, 344);
            this.bt_Accept.Name = "bt_Accept";
            this.bt_Accept.Size = new System.Drawing.Size(59, 54);
            this.bt_Accept.TabIndex = 1;
            this.bt_Accept.UseVisualStyleBackColor = true;
            this.bt_Accept.Click += new System.EventHandler(this.bt_Accept_Click);
            // 
            // bt_Remove
            // 
            this.bt_Remove.BackgroundImage = global::ClubVideo.Properties.Resources.Left_Arrow;
            this.bt_Remove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_Remove.FlatAppearance.BorderSize = 0;
            this.bt_Remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Remove.Location = new System.Drawing.Point(390, 242);
            this.bt_Remove.Name = "bt_Remove";
            this.bt_Remove.Size = new System.Drawing.Size(59, 54);
            this.bt_Remove.TabIndex = 1;
            this.bt_Remove.UseVisualStyleBackColor = true;
            this.bt_Remove.Click += new System.EventHandler(this.bt_Remove_Click);
            // 
            // bt_Erase
            // 
            this.bt_Erase.BackgroundImage = global::ClubVideo.Properties.Resources.Erase;
            this.bt_Erase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_Erase.FlatAppearance.BorderSize = 0;
            this.bt_Erase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Erase.Location = new System.Drawing.Point(389, 175);
            this.bt_Erase.Name = "bt_Erase";
            this.bt_Erase.Size = new System.Drawing.Size(59, 54);
            this.bt_Erase.TabIndex = 1;
            this.bt_Erase.UseVisualStyleBackColor = true;
            this.bt_Erase.Click += new System.EventHandler(this.bt_Erase_Click);
            // 
            // bt_Add
            // 
            this.bt_Add.BackgroundImage = global::ClubVideo.Properties.Resources.Right_Arrow;
            this.bt_Add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_Add.FlatAppearance.BorderSize = 0;
            this.bt_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Add.Location = new System.Drawing.Point(390, 106);
            this.bt_Add.Name = "bt_Add";
            this.bt_Add.Size = new System.Drawing.Size(59, 54);
            this.bt_Add.TabIndex = 1;
            this.bt_Add.UseVisualStyleBackColor = true;
            this.bt_Add.Click += new System.EventHandler(this.bt_Add_Click);
            // 
            // SidebySideSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 436);
            this.Controls.Add(this.lv_Selected);
            this.Controls.Add(this.lv_Selection);
            this.Controls.Add(this.bt_Accept);
            this.Controls.Add(this.bt_Remove);
            this.Controls.Add(this.bt_Erase);
            this.Controls.Add(this.bt_Add);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SidebySideSelection";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_Add;
        private System.Windows.Forms.ListBox lv_Selection;
        private System.Windows.Forms.Button bt_Remove;
        private System.Windows.Forms.ListBox lv_Selected;
        private System.Windows.Forms.Button bt_Erase;
        private System.Windows.Forms.Button bt_Accept;


    }
}