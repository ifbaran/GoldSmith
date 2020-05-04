namespace GoldSmith.Forms
{
    partial class CustomerOperations
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAramaID = new System.Windows.Forms.TextBox();
            this.txtAramaSoyad = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.richtxtAddress = new System.Windows.Forms.RichTextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtCellPhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.grdCustomer = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnDel);
            this.groupBox1.Controls.Add(this.btnNew);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.richtxtAddress);
            this.groupBox1.Controls.Add(this.txtSurname);
            this.groupBox1.Controls.Add(this.txtCellPhone);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1230, 262);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtAramaID);
            this.groupBox2.Controls.Add(this.txtAramaSoyad);
            this.groupBox2.Location = new System.Drawing.Point(197, 173);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(518, 63);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Arama";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Soyad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(292, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "ID";
            // 
            // txtAramaID
            // 
            this.txtAramaID.Location = new System.Drawing.Point(339, 25);
            this.txtAramaID.Name = "txtAramaID";
            this.txtAramaID.Size = new System.Drawing.Size(150, 20);
            this.txtAramaID.TabIndex = 17;
            this.txtAramaID.TextChanged += new System.EventHandler(this.txtArama);
            // 
            // txtAramaSoyad
            // 
            this.txtAramaSoyad.Location = new System.Drawing.Point(85, 25);
            this.txtAramaSoyad.Name = "txtAramaSoyad";
            this.txtAramaSoyad.Size = new System.Drawing.Size(171, 20);
            this.txtAramaSoyad.TabIndex = 16;
            this.txtAramaSoyad.TextChanged += new System.EventHandler(this.txtArama);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(32, 201);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(74, 13);
            this.linkLabel1.TabIndex = 13;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "E-Mail Gönder";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(744, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Adres";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(387, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "E-Mail";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(387, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Soyad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Telefon Numarası";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ad";
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(1091, 160);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(118, 43);
            this.btnDel.TabIndex = 7;
            this.btnDel.Text = "Sil";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(1091, 97);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(118, 43);
            this.btnNew.TabIndex = 6;
            this.btnNew.Text = "Yeni";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(1091, 33);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(118, 43);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Kaydet";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // richtxtAddress
            // 
            this.richtxtAddress.Location = new System.Drawing.Point(793, 33);
            this.richtxtAddress.Name = "richtxtAddress";
            this.richtxtAddress.Size = new System.Drawing.Size(258, 170);
            this.richtxtAddress.TabIndex = 4;
            this.richtxtAddress.Text = "";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(467, 33);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(189, 20);
            this.txtSurname.TabIndex = 2;
            // 
            // txtCellPhone
            // 
            this.txtCellPhone.Location = new System.Drawing.Point(127, 109);
            this.txtCellPhone.Name = "txtCellPhone";
            this.txtCellPhone.Size = new System.Drawing.Size(189, 20);
            this.txtCellPhone.TabIndex = 1;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(467, 109);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(189, 20);
            this.txtEmail.TabIndex = 3;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(127, 33);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(189, 20);
            this.txtName.TabIndex = 0;
            // 
            // grdCustomer
            // 
            this.grdCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCustomer.Location = new System.Drawing.Point(0, 268);
            this.grdCustomer.Name = "grdCustomer";
            this.grdCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdCustomer.Size = new System.Drawing.Size(1230, 415);
            this.grdCustomer.TabIndex = 1;
            this.grdCustomer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdCustomer_CellClick);
            this.grdCustomer.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.grdCustomer_DataBindingComplete);
            // 
            // CustomerOperations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 683);
            this.Controls.Add(this.grdCustomer);
            this.Controls.Add(this.groupBox1);
            this.Name = "CustomerOperations";
            this.Text = "Müşteri İşlemleri";
            this.Load += new System.EventHandler(this.CustomerOperations_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCustomer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.RichTextBox richtxtAddress;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtCellPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAramaID;
        private System.Windows.Forms.TextBox txtAramaSoyad;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.DataGridView grdCustomer;
    }
}