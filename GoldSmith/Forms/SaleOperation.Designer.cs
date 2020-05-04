namespace GoldSmith.Forms
{
    partial class SaleOperation
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
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txt_SalePrice = new System.Windows.Forms.TextBox();
            this.txt_GoldPrice = new System.Windows.Forms.TextBox();
            this.txt_SalerName = new System.Windows.Forms.TextBox();
            this.txt_SaleAmount = new System.Windows.Forms.TextBox();
            this.txt_BuyerName = new System.Windows.Forms.TextBox();
            this.txt_StoreName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1003, 171);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 42;
            this.button4.Text = "İade";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1003, 124);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 41;
            this.button3.Text = "Sil";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1003, 80);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 40;
            this.button2.Text = "Güncelle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1003, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 39;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 237);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1208, 410);
            this.dataGridView1.TabIndex = 38;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(586, 180);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 37;
            this.label8.Text = "Tarih:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(670, 174);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(251, 20);
            this.dateTimePicker1.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(586, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 35;
            this.label7.Text = "Toplam Tutar:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(583, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "Altın Birim Fiyat:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(583, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "Alıcının Adı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Altın Miktarı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Altın Tipi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Satıcının Adı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Mağaza Adı:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Lütfen bir Altın Tipi seçiniz.",
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
            this.comboBox1.Location = new System.Drawing.Point(177, 126);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(251, 21);
            this.comboBox1.TabIndex = 28;
            this.comboBox1.Text = "Lütfen bir Altın Tipi seçiniz.";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txt_SalePrice
            // 
            this.txt_SalePrice.Location = new System.Drawing.Point(670, 127);
            this.txt_SalePrice.Name = "txt_SalePrice";
            this.txt_SalePrice.ReadOnly = true;
            this.txt_SalePrice.Size = new System.Drawing.Size(251, 20);
            this.txt_SalePrice.TabIndex = 27;
            // 
            // txt_GoldPrice
            // 
            this.txt_GoldPrice.Location = new System.Drawing.Point(670, 87);
            this.txt_GoldPrice.Name = "txt_GoldPrice";
            this.txt_GoldPrice.ReadOnly = true;
            this.txt_GoldPrice.Size = new System.Drawing.Size(251, 20);
            this.txt_GoldPrice.TabIndex = 26;
            // 
            // txt_SalerName
            // 
            this.txt_SalerName.Location = new System.Drawing.Point(177, 83);
            this.txt_SalerName.Name = "txt_SalerName";
            this.txt_SalerName.ReadOnly = true;
            this.txt_SalerName.Size = new System.Drawing.Size(251, 20);
            this.txt_SalerName.TabIndex = 25;
            // 
            // txt_SaleAmount
            // 
            this.txt_SaleAmount.Location = new System.Drawing.Point(177, 173);
            this.txt_SaleAmount.Name = "txt_SaleAmount";
            this.txt_SaleAmount.Size = new System.Drawing.Size(251, 20);
            this.txt_SaleAmount.TabIndex = 24;
            this.txt_SaleAmount.TextChanged += new System.EventHandler(this.txt_SaleAmount_TextChanged);
            // 
            // txt_BuyerName
            // 
            this.txt_BuyerName.Location = new System.Drawing.Point(670, 39);
            this.txt_BuyerName.Name = "txt_BuyerName";
            this.txt_BuyerName.Size = new System.Drawing.Size(251, 20);
            this.txt_BuyerName.TabIndex = 23;
            // 
            // txt_StoreName
            // 
            this.txt_StoreName.Location = new System.Drawing.Point(177, 39);
            this.txt_StoreName.Name = "txt_StoreName";
            this.txt_StoreName.Size = new System.Drawing.Size(251, 20);
            this.txt_StoreName.TabIndex = 22;
            // 
            // SaleOperation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 664);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txt_SalePrice);
            this.Controls.Add(this.txt_GoldPrice);
            this.Controls.Add(this.txt_SalerName);
            this.Controls.Add(this.txt_SaleAmount);
            this.Controls.Add(this.txt_BuyerName);
            this.Controls.Add(this.txt_StoreName);
            this.Name = "SaleOperation";
            this.Text = "SaleOperation";
            this.Load += new System.EventHandler(this.SaleOperation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txt_SalePrice;
        private System.Windows.Forms.TextBox txt_GoldPrice;
        private System.Windows.Forms.TextBox txt_SalerName;
        private System.Windows.Forms.TextBox txt_SaleAmount;
        private System.Windows.Forms.TextBox txt_BuyerName;
        private System.Windows.Forms.TextBox txt_StoreName;
    }
}