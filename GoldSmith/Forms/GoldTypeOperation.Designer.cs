namespace GoldSmith.Forms
{
    partial class GoldTypeOperation
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
            this.txtSearchGold = new System.Windows.Forms.TextBox();
            this.txtSearchID = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.grdGoldType = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdGoldType)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearchGold
            // 
            this.txtSearchGold.Location = new System.Drawing.Point(267, 46);
            this.txtSearchGold.Name = "txtSearchGold";
            this.txtSearchGold.Size = new System.Drawing.Size(104, 20);
            this.txtSearchGold.TabIndex = 1;
            this.txtSearchGold.TextChanged += new System.EventHandler(this.txtSearch);
            // 
            // txtSearchID
            // 
            this.txtSearchID.Location = new System.Drawing.Point(71, 46);
            this.txtSearchID.Name = "txtSearchID";
            this.txtSearchID.Size = new System.Drawing.Size(104, 20);
            this.txtSearchID.TabIndex = 2;
            this.txtSearchID.TextChanged += new System.EventHandler(this.txtSearch);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(774, 45);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(398, 36);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Kaydet";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(774, 161);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(398, 36);
            this.btnDel.TabIndex = 5;
            this.btnDel.Text = "Sil";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtSearchID);
            this.groupBox1.Controls.Add(this.txtSearchGold);
            this.groupBox1.Location = new System.Drawing.Point(270, 120);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(431, 100);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Arama";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Altın Tipi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(338, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Altın Tipi";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Controls.Add(this.btnDel);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1218, 266);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Altın Tipi";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Lütfen Altın Tipi seçiniz.",
            "Çeyrek Altın",
            "Yarım Altın",
            "Tam Altın",
            "Cumhuriyet Altını",
            "Ons",
            "Gram Altın",
            "14 Ayar Altın",
            "18 Ayar Altın",
            "22 Ayar Bilezik",
            "İkibuçuk Altın",
            "Beşli Altın",
            "Gremse Altın"});
            this.comboBox1.Location = new System.Drawing.Point(413, 42);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(228, 21);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.Text = "Lütfen Altın Tipi seçiniz.";
            // 
            // grdGoldType
            // 
            this.grdGoldType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdGoldType.Location = new System.Drawing.Point(12, 284);
            this.grdGoldType.Name = "grdGoldType";
            this.grdGoldType.ReadOnly = true;
            this.grdGoldType.RowHeadersVisible = false;
            this.grdGoldType.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdGoldType.Size = new System.Drawing.Size(1218, 265);
            this.grdGoldType.TabIndex = 8;
            this.grdGoldType.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.grdGoldType_DataBindingComplete);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(774, 104);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(398, 36);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // GoldTypeOperation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 561);
            this.Controls.Add(this.grdGoldType);
            this.Controls.Add(this.groupBox2);
            this.Name = "GoldTypeOperation";
            this.Text = "Altın Tipi";
            this.Load += new System.EventHandler(this.GoldTypeOperation_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdGoldType)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtSearchGold;
        private System.Windows.Forms.TextBox txtSearchID;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView grdGoldType;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnUpdate;
    }
}