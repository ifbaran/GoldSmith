namespace GoldSmith.Forms
{
    partial class AdminOperations
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtAramaTcNo = new System.Windows.Forms.MaskedTextBox();
            this.txtAramaSurname = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.grdPersonal = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.rbtnMüdür = new System.Windows.Forms.RadioButton();
            this.rbtnİşçi = new System.Windows.Forms.RadioButton();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPersonal)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtAramaTcNo);
            this.groupBox2.Controls.Add(this.txtAramaSurname);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(26, 160);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(576, 60);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Çalışan Arama";
            // 
            // txtAramaTcNo
            // 
            this.txtAramaTcNo.Location = new System.Drawing.Point(140, 24);
            this.txtAramaTcNo.Mask = "00000000000";
            this.txtAramaTcNo.Name = "txtAramaTcNo";
            this.txtAramaTcNo.Size = new System.Drawing.Size(141, 20);
            this.txtAramaTcNo.TabIndex = 22;
            this.txtAramaTcNo.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtAramaTcNo_MaskInputRejected);
            // 
            // txtAramaSurname
            // 
            this.txtAramaSurname.Location = new System.Drawing.Point(381, 24);
            this.txtAramaSurname.Name = "txtAramaSurname";
            this.txtAramaSurname.Size = new System.Drawing.Size(141, 20);
            this.txtAramaSurname.TabIndex = 17;
            this.txtAramaSurname.TextChanged += new System.EventHandler(this.txtAramaSurname_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(320, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Soyisim";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "TC Kimlik Numarası";
            // 
            // grdPersonal
            // 
            this.grdPersonal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPersonal.Location = new System.Drawing.Point(26, 226);
            this.grdPersonal.MultiSelect = false;
            this.grdPersonal.Name = "grdPersonal";
            this.grdPersonal.ReadOnly = true;
            this.grdPersonal.RowHeadersVisible = false;
            this.grdPersonal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdPersonal.Size = new System.Drawing.Size(755, 212);
            this.grdPersonal.TabIndex = 22;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(349, 119);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 23);
            this.button1.TabIndex = 26;
            this.button1.Text = "Yetkiyi Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // rbtnMüdür
            // 
            this.rbtnMüdür.AutoSize = true;
            this.rbtnMüdür.Location = new System.Drawing.Point(157, 125);
            this.rbtnMüdür.Name = "rbtnMüdür";
            this.rbtnMüdür.Size = new System.Drawing.Size(55, 17);
            this.rbtnMüdür.TabIndex = 25;
            this.rbtnMüdür.TabStop = true;
            this.rbtnMüdür.Text = "Müdür";
            this.rbtnMüdür.UseVisualStyleBackColor = true;
            // 
            // rbtnİşçi
            // 
            this.rbtnİşçi.AutoSize = true;
            this.rbtnİşçi.Location = new System.Drawing.Point(42, 125);
            this.rbtnİşçi.Name = "rbtnİşçi";
            this.rbtnİşçi.Size = new System.Drawing.Size(41, 17);
            this.rbtnİşçi.TabIndex = 24;
            this.rbtnİşçi.TabStop = true;
            this.rbtnİşçi.Text = "İşçi";
            this.rbtnİşçi.UseVisualStyleBackColor = true;
            // 
            // AdminOperations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grdPersonal);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rbtnMüdür);
            this.Controls.Add(this.rbtnİşçi);
            this.Name = "AdminOperations";
            this.Text = "AdminOperations";
            this.Load += new System.EventHandler(this.AdminOperations_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPersonal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox txtAramaTcNo;
        private System.Windows.Forms.TextBox txtAramaSurname;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView grdPersonal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rbtnMüdür;
        private System.Windows.Forms.RadioButton rbtnİşçi;
    }
}