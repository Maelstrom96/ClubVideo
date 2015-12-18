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
            this.lb_LastName = new System.Windows.Forms.Label();
            this.lb_Name = new System.Windows.Forms.Label();
            this.lb_Address = new System.Windows.Forms.Label();
            this.lb_PostalCode = new System.Windows.Forms.Label();
            this.lb_City = new System.Windows.Forms.Label();
            this.lb_Province = new System.Windows.Forms.Label();
            this.lb_PhoneNumber = new System.Windows.Forms.Label();
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
            // lb_LastName
            // 
            this.lb_LastName.AutoSize = true;
            this.lb_LastName.Location = new System.Drawing.Point(15, 52);
            this.lb_LastName.Name = "lb_LastName";
            this.lb_LastName.Size = new System.Drawing.Size(29, 13);
            this.lb_LastName.TabIndex = 0;
            this.lb_LastName.Text = "Nom";
            // 
            // lb_Name
            // 
            this.lb_Name.AutoSize = true;
            this.lb_Name.Location = new System.Drawing.Point(15, 21);
            this.lb_Name.Name = "lb_Name";
            this.lb_Name.Size = new System.Drawing.Size(43, 13);
            this.lb_Name.TabIndex = 0;
            this.lb_Name.Text = "Prenom";
            // 
            // lb_Address
            // 
            this.lb_Address.AutoSize = true;
            this.lb_Address.Location = new System.Drawing.Point(15, 120);
            this.lb_Address.Name = "lb_Address";
            this.lb_Address.Size = new System.Drawing.Size(45, 13);
            this.lb_Address.TabIndex = 0;
            this.lb_Address.Text = "Adresse";
            // 
            // lb_PostalCode
            // 
            this.lb_PostalCode.AutoSize = true;
            this.lb_PostalCode.Location = new System.Drawing.Point(15, 154);
            this.lb_PostalCode.Name = "lb_PostalCode";
            this.lb_PostalCode.Size = new System.Drawing.Size(64, 13);
            this.lb_PostalCode.TabIndex = 0;
            this.lb_PostalCode.Text = "Code Postal";
            // 
            // lb_City
            // 
            this.lb_City.AutoSize = true;
            this.lb_City.Location = new System.Drawing.Point(15, 189);
            this.lb_City.Name = "lb_City";
            this.lb_City.Size = new System.Drawing.Size(26, 13);
            this.lb_City.TabIndex = 0;
            this.lb_City.Text = "Ville";
            // 
            // lb_Province
            // 
            this.lb_Province.AutoSize = true;
            this.lb_Province.Location = new System.Drawing.Point(15, 228);
            this.lb_Province.Name = "lb_Province";
            this.lb_Province.Size = new System.Drawing.Size(49, 13);
            this.lb_Province.TabIndex = 0;
            this.lb_Province.Text = "Province";
            // 
            // lb_PhoneNumber
            // 
            this.lb_PhoneNumber.AutoSize = true;
            this.lb_PhoneNumber.Location = new System.Drawing.Point(15, 86);
            this.lb_PhoneNumber.Name = "lb_PhoneNumber";
            this.lb_PhoneNumber.Size = new System.Drawing.Size(58, 13);
            this.lb_PhoneNumber.TabIndex = 0;
            this.lb_PhoneNumber.Text = "Telephone";
            // 
            // txb_Name
            // 
            this.txb_Name.Location = new System.Drawing.Point(94, 18);
            this.txb_Name.Name = "txb_Name";
            this.txb_Name.Size = new System.Drawing.Size(100, 20);
            this.txb_Name.TabIndex = 0;
            // 
            // txb_LastName
            // 
            this.txb_LastName.Location = new System.Drawing.Point(94, 49);
            this.txb_LastName.Name = "txb_LastName";
            this.txb_LastName.Size = new System.Drawing.Size(100, 20);
            this.txb_LastName.TabIndex = 1;
            // 
            // txb_Telephone
            // 
            this.txb_Telephone.Location = new System.Drawing.Point(95, 83);
            this.txb_Telephone.MaxLength = 10;
            this.txb_Telephone.Name = "txb_Telephone";
            this.txb_Telephone.Size = new System.Drawing.Size(100, 20);
            this.txb_Telephone.TabIndex = 2;
            this.txb_Telephone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_Telephone_KeyPress);
            // 
            // txb_Adress
            // 
            this.txb_Adress.Location = new System.Drawing.Point(94, 117);
            this.txb_Adress.Name = "txb_Adress";
            this.txb_Adress.Size = new System.Drawing.Size(100, 20);
            this.txb_Adress.TabIndex = 3;
            // 
            // txb_PostalCode
            // 
            this.txb_PostalCode.Location = new System.Drawing.Point(94, 151);
            this.txb_PostalCode.MaxLength = 6;
            this.txb_PostalCode.Name = "txb_PostalCode";
            this.txb_PostalCode.Size = new System.Drawing.Size(100, 20);
            this.txb_PostalCode.TabIndex = 4;
            // 
            // txb_City
            // 
            this.txb_City.Location = new System.Drawing.Point(94, 186);
            this.txb_City.Name = "txb_City";
            this.txb_City.Size = new System.Drawing.Size(100, 20);
            this.txb_City.TabIndex = 5;
            // 
            // btn_Add
            // 
            this.btn_Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Add.Location = new System.Drawing.Point(0, 266);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(212, 23);
            this.btn_Add.TabIndex = 7;
            this.btn_Add.Text = "Ajouter";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Cancel.Location = new System.Drawing.Point(0, 295);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(212, 23);
            this.btn_Cancel.TabIndex = 11;
            this.btn_Cancel.Text = "Annuler";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Previous
            // 
            this.btn_Previous.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Previous.Location = new System.Drawing.Point(0, 266);
            this.btn_Previous.Name = "btn_Previous";
            this.btn_Previous.Size = new System.Drawing.Size(106, 23);
            this.btn_Previous.TabIndex = 10;
            this.btn_Previous.Text = "Precedent";
            this.btn_Previous.UseVisualStyleBackColor = true;
            this.btn_Previous.Visible = false;
            this.btn_Previous.Click += new System.EventHandler(this.btn_Previous_Click);
            // 
            // btn_Next
            // 
            this.btn_Next.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Next.Location = new System.Drawing.Point(105, 266);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(107, 23);
            this.btn_Next.TabIndex = 9;
            this.btn_Next.Text = "Suivant";
            this.btn_Next.UseVisualStyleBackColor = true;
            this.btn_Next.Visible = false;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // btn_Modify
            // 
            this.btn_Modify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Modify.Location = new System.Drawing.Point(0, 266);
            this.btn_Modify.Name = "btn_Modify";
            this.btn_Modify.Size = new System.Drawing.Size(212, 23);
            this.btn_Modify.TabIndex = 8;
            this.btn_Modify.Text = "Modifier";
            this.btn_Modify.UseVisualStyleBackColor = true;
            this.btn_Modify.Visible = false;
            this.btn_Modify.Click += new System.EventHandler(this.btn_Modify_Click);
            // 
            // cb_Provinces
            // 
            this.cb_Provinces.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_Provinces.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Provinces.FormattingEnabled = true;
            this.cb_Provinces.Location = new System.Drawing.Point(94, 225);
            this.cb_Provinces.Name = "cb_Provinces";
            this.cb_Provinces.Size = new System.Drawing.Size(100, 21);
            this.cb_Provinces.TabIndex = 6;
            // 
            // UpdateMembers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(212, 325);
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
            this.Controls.Add(this.lb_PhoneNumber);
            this.Controls.Add(this.lb_Province);
            this.Controls.Add(this.lb_City);
            this.Controls.Add(this.lb_PostalCode);
            this.Controls.Add(this.lb_Address);
            this.Controls.Add(this.lb_Name);
            this.Controls.Add(this.lb_LastName);
            this.Name = "UpdateMembers";
            this.Text = "UpdateMembers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_LastName;
        private System.Windows.Forms.Label lb_Name;
        private System.Windows.Forms.Label lb_Address;
        private System.Windows.Forms.Label lb_PostalCode;
        private System.Windows.Forms.Label lb_City;
        private System.Windows.Forms.Label lb_Province;
        private System.Windows.Forms.Label lb_PhoneNumber;
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