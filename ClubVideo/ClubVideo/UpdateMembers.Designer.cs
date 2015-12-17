namespace ClubVideo
{
    partial class UpdateMembers
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txb_Name = new System.Windows.Forms.TextBox();
            this.txb_LastName = new System.Windows.Forms.TextBox();
            this.txb_Telephone = new System.Windows.Forms.TextBox();
            this.txb_Adress = new System.Windows.Forms.TextBox();
            this.txb_PostalCode = new System.Windows.Forms.TextBox();
            this.txb_City = new System.Windows.Forms.TextBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Previous = new System.Windows.Forms.Button();
            this.btn_Next = new System.Windows.Forms.Button();
            this.btn_Modify = new System.Windows.Forms.Button();
            this.cb_Provinces = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Prenom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(226, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Adresse";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(226, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Code Postal";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(228, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ville";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(228, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Province";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Telephone";
            // 
            // txb_Name
            // 
            this.txb_Name.Location = new System.Drawing.Point(75, 53);
            this.txb_Name.Name = "txb_Name";
            this.txb_Name.Size = new System.Drawing.Size(100, 20);
            this.txb_Name.TabIndex = 0;
            // 
            // txb_LastName
            // 
            this.txb_LastName.Location = new System.Drawing.Point(75, 84);
            this.txb_LastName.Name = "txb_LastName";
            this.txb_LastName.Size = new System.Drawing.Size(100, 20);
            this.txb_LastName.TabIndex = 1;
            // 
            // txb_Telephone
            // 
            this.txb_Telephone.Location = new System.Drawing.Point(76, 124);
            this.txb_Telephone.MaxLength = 10;
            this.txb_Telephone.Name = "txb_Telephone";
            this.txb_Telephone.Size = new System.Drawing.Size(100, 20);
            this.txb_Telephone.TabIndex = 2;
            this.txb_Telephone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_Telephone_KeyPress);
            // 
            // txb_Adress
            // 
            this.txb_Adress.Location = new System.Drawing.Point(307, 53);
            this.txb_Adress.Name = "txb_Adress";
            this.txb_Adress.Size = new System.Drawing.Size(100, 20);
            this.txb_Adress.TabIndex = 3;
            // 
            // txb_PostalCode
            // 
            this.txb_PostalCode.Location = new System.Drawing.Point(307, 88);
            this.txb_PostalCode.MaxLength = 6;
            this.txb_PostalCode.Name = "txb_PostalCode";
            this.txb_PostalCode.Size = new System.Drawing.Size(100, 20);
            this.txb_PostalCode.TabIndex = 4;
            // 
            // txb_City
            // 
            this.txb_City.Location = new System.Drawing.Point(307, 124);
            this.txb_City.Name = "txb_City";
            this.txb_City.Size = new System.Drawing.Size(100, 20);
            this.txb_City.TabIndex = 5;
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(439, 252);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 7;
            this.btn_Add.Text = "Ajouter";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(244, 251);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 11;
            this.btn_Cancel.Text = "Annuler";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Previous
            // 
            this.btn_Previous.Location = new System.Drawing.Point(15, 251);
            this.btn_Previous.Name = "btn_Previous";
            this.btn_Previous.Size = new System.Drawing.Size(75, 23);
            this.btn_Previous.TabIndex = 10;
            this.btn_Previous.Text = "Precedent";
            this.btn_Previous.UseVisualStyleBackColor = true;
            this.btn_Previous.Visible = false;
            this.btn_Previous.Click += new System.EventHandler(this.btn_Previous_Click);
            // 
            // btn_Next
            // 
            this.btn_Next.Location = new System.Drawing.Point(122, 251);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(75, 23);
            this.btn_Next.TabIndex = 9;
            this.btn_Next.Text = "Suivant";
            this.btn_Next.UseVisualStyleBackColor = true;
            this.btn_Next.Visible = false;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // btn_Modify
            // 
            this.btn_Modify.Location = new System.Drawing.Point(342, 251);
            this.btn_Modify.Name = "btn_Modify";
            this.btn_Modify.Size = new System.Drawing.Size(75, 23);
            this.btn_Modify.TabIndex = 8;
            this.btn_Modify.Text = "Modifier";
            this.btn_Modify.UseVisualStyleBackColor = true;
            this.btn_Modify.Visible = false;
            this.btn_Modify.Click += new System.EventHandler(this.btn_Modify_Click);
            // 
            // cb_Provinces
            // 
            this.cb_Provinces.FormattingEnabled = true;
            this.cb_Provinces.Location = new System.Drawing.Point(307, 161);
            this.cb_Provinces.Name = "cb_Provinces";
            this.cb_Provinces.Size = new System.Drawing.Size(100, 21);
            this.cb_Provinces.TabIndex = 6;
            // 
            // UpdateMembers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 287);
            this.Controls.Add(this.cb_Provinces);
            this.Controls.Add(this.btn_Modify);
            this.Controls.Add(this.btn_Next);
            this.Controls.Add(this.btn_Previous);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.txb_City);
            this.Controls.Add(this.txb_PostalCode);
            this.Controls.Add(this.txb_Adress);
            this.Controls.Add(this.txb_Telephone);
            this.Controls.Add(this.txb_LastName);
            this.Controls.Add(this.txb_Name);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UpdateMembers";
            this.Text = "UpdateMembers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txb_Name;
        private System.Windows.Forms.TextBox txb_LastName;
        private System.Windows.Forms.TextBox txb_Telephone;
        private System.Windows.Forms.TextBox txb_Adress;
        private System.Windows.Forms.TextBox txb_PostalCode;
        private System.Windows.Forms.TextBox txb_City;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Previous;
        private System.Windows.Forms.Button btn_Next;
        private System.Windows.Forms.Button btn_Modify;
        private System.Windows.Forms.ComboBox cb_Provinces;
    }
}