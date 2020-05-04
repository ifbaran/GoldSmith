namespace GoldSmith.Forms
{
    partial class StoreOperations
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StoreOperations));
            this.txtStoreStorage = new System.Windows.Forms.TextBox();
            this.txtAramaMağazaId = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtAramaMağazaAdi = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.mtxtClose = new System.Windows.Forms.MaskedTextBox();
            this.mtxtOpen = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grdStore = new System.Windows.Forms.DataGridView();
            this.txtStoreAdress = new System.Windows.Forms.TextBox();
            this.txtStoreName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdStore)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtStoreStorage
            // 
            this.txtStoreStorage.Location = new System.Drawing.Point(403, 39);
            this.txtStoreStorage.Multiline = true;
            this.txtStoreStorage.Name = "txtStoreStorage";
            this.txtStoreStorage.Size = new System.Drawing.Size(169, 125);
            this.txtStoreStorage.TabIndex = 22;
            // 
            // txtAramaMağazaId
            // 
            this.txtAramaMağazaId.Location = new System.Drawing.Point(114, 19);
            this.txtAramaMağazaId.Name = "txtAramaMağazaId";
            this.txtAramaMağazaId.Size = new System.Drawing.Size(155, 20);
            this.txtAramaMağazaId.TabIndex = 14;
            this.txtAramaMağazaId.Tag = "";
            this.txtAramaMağazaId.TextChanged += new System.EventHandler(this.txtArama);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(300, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Mağaza Adı";
            // 
            // txtAramaMağazaAdi
            // 
            this.txtAramaMağazaAdi.Location = new System.Drawing.Point(369, 19);
            this.txtAramaMağazaAdi.Name = "txtAramaMağazaAdi";
            this.txtAramaMağazaAdi.Size = new System.Drawing.Size(155, 20);
            this.txtAramaMağazaAdi.TabIndex = 14;
            this.txtAramaMağazaAdi.Tag = "";
            this.txtAramaMağazaAdi.TextChanged += new System.EventHandler(this.txtArama);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(49, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Mağaza ID";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtAramaMağazaId);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtAramaMağazaAdi);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Location = new System.Drawing.Point(12, 217);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(594, 54);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Arama";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(400, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Mağaza Stoğu : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(106, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Kapanış :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Açılış :";
            // 
            // mtxtClose
            // 
            this.mtxtClose.Location = new System.Drawing.Point(123, 144);
            this.mtxtClose.Mask = "00:00";
            this.mtxtClose.Name = "mtxtClose";
            this.mtxtClose.Size = new System.Drawing.Size(34, 20);
            this.mtxtClose.TabIndex = 19;
            this.mtxtClose.ValidatingType = typeof(System.DateTime);
            // 
            // mtxtOpen
            // 
            this.mtxtOpen.Location = new System.Drawing.Point(53, 144);
            this.mtxtOpen.Mask = "00:00";
            this.mtxtOpen.Name = "mtxtOpen";
            this.mtxtOpen.Size = new System.Drawing.Size(34, 20);
            this.mtxtOpen.TabIndex = 18;
            this.mtxtOpen.ValidatingType = typeof(System.DateTime);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(99, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(10, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "-";
            // 
            // btnDel
            // 
            this.btnDel.Image = ((System.Drawing.Image)(resources.GetObject("btnDel.Image")));
            this.btnDel.Location = new System.Drawing.Point(656, 135);
            this.btnDel.Name = "btnDel";
            this.btnDel.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnDel.Size = new System.Drawing.Size(159, 42);
            this.btnDel.TabIndex = 27;
            this.btnDel.Text = "     &Sil";
            this.btnDel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnNew
            // 
            this.btnNew.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.Image")));
            this.btnNew.Location = new System.Drawing.Point(656, 72);
            this.btnNew.Name = "btnNew";
            this.btnNew.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnNew.Size = new System.Drawing.Size(159, 42);
            this.btnNew.TabIndex = 26;
            this.btnNew.Text = "    &Yeni";
            this.btnNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mağaza Çalışma Saatleri :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(225, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mağaza Adresi :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mağaza Adı:";
            // 
            // grdStore
            // 
            this.grdStore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdStore.Location = new System.Drawing.Point(12, 277);
            this.grdStore.MultiSelect = false;
            this.grdStore.Name = "grdStore";
            this.grdStore.ReadOnly = true;
            this.grdStore.RowHeadersVisible = false;
            this.grdStore.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdStore.Size = new System.Drawing.Size(803, 213);
            this.grdStore.TabIndex = 24;
            this.grdStore.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdStore_CellClick);
            // 
            // txtStoreAdress
            // 
            this.txtStoreAdress.Location = new System.Drawing.Point(228, 39);
            this.txtStoreAdress.Multiline = true;
            this.txtStoreAdress.Name = "txtStoreAdress";
            this.txtStoreAdress.Size = new System.Drawing.Size(169, 125);
            this.txtStoreAdress.TabIndex = 1;
            // 
            // txtStoreName
            // 
            this.txtStoreName.Location = new System.Drawing.Point(53, 39);
            this.txtStoreName.Name = "txtStoreName";
            this.txtStoreName.Size = new System.Drawing.Size(169, 20);
            this.txtStoreName.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtStoreStorage);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.mtxtClose);
            this.groupBox1.Controls.Add(this.mtxtOpen);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtStoreAdress);
            this.groupBox1.Controls.Add(this.txtStoreName);
            this.groupBox1.Location = new System.Drawing.Point(11, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(595, 204);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mağaza Bilgileri";
            // 
            // btnSave
            // 
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(656, 13);
            this.btnSave.Name = "btnSave";
            this.btnSave.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnSave.Size = new System.Drawing.Size(159, 42);
            this.btnSave.TabIndex = 25;
            this.btnSave.Text = "     &Kaydet";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // StoreOperations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 503);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.grdStore);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "StoreOperations";
            this.Text = "StoreOperations";
            this.Load += new System.EventHandler(this.StoreOperations_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdStore)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtStoreStorage;
        private System.Windows.Forms.TextBox txtAramaMağazaId;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtAramaMağazaAdi;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mtxtClose;
        private System.Windows.Forms.MaskedTextBox mtxtOpen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grdStore;
        private System.Windows.Forms.TextBox txtStoreAdress;
        private System.Windows.Forms.TextBox txtStoreName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSave;
    }
}