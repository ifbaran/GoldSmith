namespace GoldSmith.Forms
{
    partial class GoldCurrencyOperation
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
            this.grdGoldCurrency = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdGoldCurrency)).BeginInit();
            this.SuspendLayout();
            // 
            // grdGoldCurrency
            // 
            this.grdGoldCurrency.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grdGoldCurrency.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdGoldCurrency.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdGoldCurrency.Location = new System.Drawing.Point(12, 12);
            this.grdGoldCurrency.MultiSelect = false;
            this.grdGoldCurrency.Name = "grdGoldCurrency";
            this.grdGoldCurrency.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdGoldCurrency.Size = new System.Drawing.Size(776, 426);
            this.grdGoldCurrency.TabIndex = 0;
            // 
            // GoldCurrencyOperation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grdGoldCurrency);
            this.Name = "GoldCurrencyOperation";
            this.Text = "GoldCurrencyOperation";
            this.Load += new System.EventHandler(this.GoldCurrencyOperation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdGoldCurrency)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdGoldCurrency;
    }
}