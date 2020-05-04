namespace GoldSmith.Forms
{
    partial class SalerOperations
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalerOperations));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtAramaId = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtAramaFirmaAdi = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCellPhone1 = new System.Windows.Forms.MaskedTextBox();
            this.txtWorkPhone1 = new System.Windows.Forms.MaskedTextBox();
            this.LblMail = new System.Windows.Forms.LinkLabel();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtAddress = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtFirmTitle = new System.Windows.Forms.TextBox();
            this.txtFirmName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTaxNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTaxOffice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFaxNumber = new System.Windows.Forms.TextBox();
            this.grdSaler = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSaler)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txtCellPhone1);
            this.groupBox1.Controls.Add(this.txtWorkPhone1);
            this.groupBox1.Controls.Add(this.LblMail);
            this.groupBox1.Controls.Add(this.btnDel);
            this.groupBox1.Controls.Add(this.btnNew);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtFirmTitle);
            this.groupBox1.Controls.Add(this.txtFirmName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtTaxNumber);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtTaxOffice);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtFaxNumber);
            this.groupBox1.Location = new System.Drawing.Point(12, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1218, 238);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Toptancı Bilgiler";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtAramaId);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtAramaFirmaAdi);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Location = new System.Drawing.Point(138, 169);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(532, 54);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Arama";
            // 
            // txtAramaId
            // 
            this.txtAramaId.Location = new System.Drawing.Point(95, 19);
            this.txtAramaId.Name = "txtAramaId";
            this.txtAramaId.Size = new System.Drawing.Size(155, 20);
            this.txtAramaId.TabIndex = 14;
            this.txtAramaId.Tag = "";
            this.txtAramaId.TextChanged += new System.EventHandler(this.txtArama);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(281, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Firma Adı";
            // 
            // txtAramaFirmaAdi
            // 
            this.txtAramaFirmaAdi.Location = new System.Drawing.Point(350, 19);
            this.txtAramaFirmaAdi.Name = "txtAramaFirmaAdi";
            this.txtAramaFirmaAdi.Size = new System.Drawing.Size(155, 20);
            this.txtAramaFirmaAdi.TabIndex = 14;
            this.txtAramaFirmaAdi.Tag = "";
            this.txtAramaFirmaAdi.TextChanged += new System.EventHandler(this.txtArama);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(24, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(18, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "ID";
            // 
            // txtCellPhone1
            // 
            this.txtCellPhone1.Location = new System.Drawing.Point(846, 32);
            this.txtCellPhone1.Mask = "(999) 000-0000";
            this.txtCellPhone1.Name = "txtCellPhone1";
            this.txtCellPhone1.Size = new System.Drawing.Size(186, 20);
            this.txtCellPhone1.TabIndex = 6;
            // 
            // txtWorkPhone1
            // 
            this.txtWorkPhone1.Location = new System.Drawing.Point(846, 58);
            this.txtWorkPhone1.Mask = "(999) 000-0000";
            this.txtWorkPhone1.Name = "txtWorkPhone1";
            this.txtWorkPhone1.Size = new System.Drawing.Size(186, 20);
            this.txtWorkPhone1.TabIndex = 7;
            // 
            // LblMail
            // 
            this.LblMail.AutoSize = true;
            this.LblMail.Location = new System.Drawing.Point(21, 169);
            this.LblMail.Name = "LblMail";
            this.LblMail.Size = new System.Drawing.Size(82, 13);
            this.LblMail.TabIndex = 13;
            this.LblMail.TabStop = true;
            this.LblMail.Text = "E-Posta Gönder";
            this.LblMail.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LblMail_LinkClicked);
            // 
            // btnDel
            // 
            this.btnDel.Image = ((System.Drawing.Image)(resources.GetObject("btnDel.Image")));
            this.btnDel.Location = new System.Drawing.Point(1053, 154);
            this.btnDel.Name = "btnDel";
            this.btnDel.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnDel.Size = new System.Drawing.Size(159, 42);
            this.btnDel.TabIndex = 12;
            this.btnDel.Text = "     Sil";
            this.btnDel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnNew
            // 
            this.btnNew.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.Image")));
            this.btnNew.Location = new System.Drawing.Point(1053, 91);
            this.btnNew.Name = "btnNew";
            this.btnNew.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnNew.Size = new System.Drawing.Size(159, 42);
            this.btnNew.TabIndex = 11;
            this.btnNew.Text = "    Yeni";
            this.btnNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(1053, 32);
            this.btnSave.Name = "btnSave";
            this.btnSave.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnSave.Size = new System.Drawing.Size(159, 42);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "     Kaydet";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(434, 32);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(227, 101);
            this.txtAddress.TabIndex = 5;
            this.txtAddress.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(729, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Faks Numarası";
            // 
            // txtFirmTitle
            // 
            this.txtFirmTitle.Location = new System.Drawing.Point(129, 58);
            this.txtFirmTitle.Name = "txtFirmTitle";
            this.txtFirmTitle.Size = new System.Drawing.Size(186, 20);
            this.txtFirmTitle.TabIndex = 2;
            // 
            // txtFirmName
            // 
            this.txtFirmName.Location = new System.Drawing.Point(129, 32);
            this.txtFirmName.Name = "txtFirmName";
            this.txtFirmName.Size = new System.Drawing.Size(186, 20);
            this.txtFirmName.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(729, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Telefon (İş)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Vergi Dairesi";
            // 
            // txtTaxNumber
            // 
            this.txtTaxNumber.Location = new System.Drawing.Point(129, 87);
            this.txtTaxNumber.MaxLength = 24;
            this.txtTaxNumber.Name = "txtTaxNumber";
            this.txtTaxNumber.Size = new System.Drawing.Size(186, 20);
            this.txtTaxNumber.TabIndex = 3;
            this.txtTaxNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTaxNumber_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(358, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Adres";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(846, 113);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(186, 20);
            this.txtEmail.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(729, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Vergi Numarası";
            // 
            // txtTaxOffice
            // 
            this.txtTaxOffice.Location = new System.Drawing.Point(129, 113);
            this.txtTaxOffice.Name = "txtTaxOffice";
            this.txtTaxOffice.Size = new System.Drawing.Size(186, 20);
            this.txtTaxOffice.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(729, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Telefon (Cep)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Firma Ünvanı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Firma Adı";
            // 
            // txtFaxNumber
            // 
            this.txtFaxNumber.Location = new System.Drawing.Point(846, 87);
            this.txtFaxNumber.Name = "txtFaxNumber";
            this.txtFaxNumber.Size = new System.Drawing.Size(186, 20);
            this.txtFaxNumber.TabIndex = 8;
            // 
            // grdSaler
            // 
            this.grdSaler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdSaler.ColumnHeadersHeight = 41;
            this.grdSaler.Location = new System.Drawing.Point(0, 260);
            this.grdSaler.MultiSelect = false;
            this.grdSaler.Name = "grdSaler";
            this.grdSaler.ReadOnly = true;
            this.grdSaler.RowHeadersVisible = false;
            this.grdSaler.RowHeadersWidth = 91;
            this.grdSaler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdSaler.Size = new System.Drawing.Size(1242, 423);
            this.grdSaler.TabIndex = 1;
            this.grdSaler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdSaler_CellClick);
            this.grdSaler.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.grdSaler_DataBindingComplete);
            // 
            // SalerOperations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 683);
            this.Controls.Add(this.grdSaler);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SalerOperations";
            this.ShowIcon = false;
            this.Text = "Toptancı İşlemleri";
            this.Load += new System.EventHandler(this.SalerOperations_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSaler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.RichTextBox txtAddress;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtFirmTitle;
        private System.Windows.Forms.TextBox txtFirmName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTaxNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTaxOffice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFaxNumber;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.LinkLabel LblMail;
        private System.Windows.Forms.MaskedTextBox txtWorkPhone1;
        private System.Windows.Forms.MaskedTextBox txtCellPhone1;
        private System.Windows.Forms.TextBox txtAramaFirmaAdi;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.DataGridView grdSaler;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtAramaId;
        private System.Windows.Forms.Label label11;
    }
}