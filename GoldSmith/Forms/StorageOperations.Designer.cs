namespace GoldSmith.Forms
{
    partial class StorageOperations
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtSearchType = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAramaVergiNo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btCleaner = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btSave = new System.Windows.Forms.Button();
            this.rtxtStorageAdress = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStorageTaxNumber = new System.Windows.Forms.TextBox();
            this.txtStorageSize = new System.Windows.Forms.TextBox();
            this.txtStoragePhoneNumber = new System.Windows.Forms.TextBox();
            this.txtStorageFaxNumber = new System.Windows.Forms.TextBox();
            this.txtStorageType = new System.Windows.Forms.TextBox();
            this.grdStorage = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdStorage)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btCleaner);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btDelete);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btSave);
            this.groupBox1.Controls.Add(this.rtxtStorageAdress);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtStorageTaxNumber);
            this.groupBox1.Controls.Add(this.txtStorageSize);
            this.groupBox1.Controls.Add(this.txtStoragePhoneNumber);
            this.groupBox1.Controls.Add(this.txtStorageFaxNumber);
            this.groupBox1.Controls.Add(this.txtStorageType);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1143, 213);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Depo İşlemleri";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "StorageTaxNumber";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "StroageType";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtSearchType);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtAramaVergiNo);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(459, 130);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(498, 65);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Depo Arama";
            // 
            // txtSearchType
            // 
            this.txtSearchType.Location = new System.Drawing.Point(281, 26);
            this.txtSearchType.Name = "txtSearchType";
            this.txtSearchType.Size = new System.Drawing.Size(100, 20);
            this.txtSearchType.TabIndex = 4;
            this.txtSearchType.TextChanged += new System.EventHandler(this.txtArama);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(204, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Storage Type";
            // 
            // txtAramaVergiNo
            // 
            this.txtAramaVergiNo.Location = new System.Drawing.Point(89, 26);
            this.txtAramaVergiNo.Name = "txtAramaVergiNo";
            this.txtAramaVergiNo.Size = new System.Drawing.Size(106, 20);
            this.txtAramaVergiNo.TabIndex = 1;
            this.txtAramaVergiNo.TextChanged += new System.EventHandler(this.txtArama);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Depo Vergi No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "StroageFaxNumber";
            // 
            // btCleaner
            // 
            this.btCleaner.Location = new System.Drawing.Point(851, 76);
            this.btCleaner.Name = "btCleaner";
            this.btCleaner.Size = new System.Drawing.Size(93, 36);
            this.btCleaner.TabIndex = 25;
            this.btCleaner.Text = "Temizle";
            this.btCleaner.UseVisualStyleBackColor = true;
            this.btCleaner.Click += new System.EventHandler(this.btCleaner_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "StroagePhoneNumber";
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(965, 49);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(93, 33);
            this.btDelete.TabIndex = 24;
            this.btDelete.Text = "SİL";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "StroageSize";
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(851, 28);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(93, 32);
            this.btSave.TabIndex = 23;
            this.btSave.Text = "KAYDET";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // rtxtStorageAdress
            // 
            this.rtxtStorageAdress.Location = new System.Drawing.Point(538, 19);
            this.rtxtStorageAdress.Name = "rtxtStorageAdress";
            this.rtxtStorageAdress.Size = new System.Drawing.Size(215, 105);
            this.rtxtStorageAdress.TabIndex = 22;
            this.rtxtStorageAdress.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(456, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "StroageAdress";
            // 
            // txtStorageTaxNumber
            // 
            this.txtStorageTaxNumber.Location = new System.Drawing.Point(208, 56);
            this.txtStorageTaxNumber.Name = "txtStorageTaxNumber";
            this.txtStorageTaxNumber.Size = new System.Drawing.Size(184, 20);
            this.txtStorageTaxNumber.TabIndex = 20;
            this.txtStorageTaxNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStorageTaxNumber_KeyPress);
            // 
            // txtStorageSize
            // 
            this.txtStorageSize.Location = new System.Drawing.Point(208, 93);
            this.txtStorageSize.Name = "txtStorageSize";
            this.txtStorageSize.Size = new System.Drawing.Size(184, 20);
            this.txtStorageSize.TabIndex = 19;
            // 
            // txtStoragePhoneNumber
            // 
            this.txtStoragePhoneNumber.Location = new System.Drawing.Point(209, 131);
            this.txtStoragePhoneNumber.Name = "txtStoragePhoneNumber";
            this.txtStoragePhoneNumber.Size = new System.Drawing.Size(184, 20);
            this.txtStoragePhoneNumber.TabIndex = 18;
            // 
            // txtStorageFaxNumber
            // 
            this.txtStorageFaxNumber.Location = new System.Drawing.Point(208, 167);
            this.txtStorageFaxNumber.Name = "txtStorageFaxNumber";
            this.txtStorageFaxNumber.Size = new System.Drawing.Size(184, 20);
            this.txtStorageFaxNumber.TabIndex = 17;
            // 
            // txtStorageType
            // 
            this.txtStorageType.Location = new System.Drawing.Point(208, 19);
            this.txtStorageType.Name = "txtStorageType";
            this.txtStorageType.Size = new System.Drawing.Size(184, 20);
            this.txtStorageType.TabIndex = 16;
            // 
            // grdStorage
            // 
            this.grdStorage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdStorage.Location = new System.Drawing.Point(143, 219);
            this.grdStorage.Name = "grdStorage";
            this.grdStorage.ReadOnly = true;
            this.grdStorage.RowHeadersVisible = false;
            this.grdStorage.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdStorage.Size = new System.Drawing.Size(791, 327);
            this.grdStorage.TabIndex = 2;
            this.grdStorage.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdStorage_CellClick_1);
            this.grdStorage.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.grdStorage_DataBindingComplete);
            // 
            // StorageOperations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 554);
            this.Controls.Add(this.grdStorage);
            this.Controls.Add(this.groupBox1);
            this.Name = "StorageOperations";
            this.Text = "StorageOperations";
            this.Load += new System.EventHandler(this.StorageOperations_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdStorage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtSearchType;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAramaVergiNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btCleaner;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.RichTextBox rtxtStorageAdress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtStorageTaxNumber;
        private System.Windows.Forms.TextBox txtStorageSize;
        private System.Windows.Forms.TextBox txtStoragePhoneNumber;
        private System.Windows.Forms.TextBox txtStorageFaxNumber;
        private System.Windows.Forms.TextBox txtStorageType;
        public System.Windows.Forms.DataGridView grdStorage;
    }
}