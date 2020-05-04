namespace GoldSmith.Forms
{
    partial class SendMail
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
            this.txtWhom = new System.Windows.Forms.TextBox();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.richtxtContent = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGonder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtWhom
            // 
            this.txtWhom.Location = new System.Drawing.Point(139, 40);
            this.txtWhom.Name = "txtWhom";
            this.txtWhom.ReadOnly = true;
            this.txtWhom.Size = new System.Drawing.Size(409, 20);
            this.txtWhom.TabIndex = 0;
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(139, 75);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(409, 20);
            this.txtSubject.TabIndex = 1;
            // 
            // richtxtContent
            // 
            this.richtxtContent.Location = new System.Drawing.Point(139, 114);
            this.richtxtContent.Name = "richtxtContent";
            this.richtxtContent.Size = new System.Drawing.Size(409, 198);
            this.richtxtContent.TabIndex = 2;
            this.richtxtContent.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kime:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Konu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "İçerik:";
            // 
            // btnGonder
            // 
            this.btnGonder.Location = new System.Drawing.Point(428, 331);
            this.btnGonder.Name = "btnGonder";
            this.btnGonder.Size = new System.Drawing.Size(120, 44);
            this.btnGonder.TabIndex = 6;
            this.btnGonder.Text = "Gönder";
            this.btnGonder.UseVisualStyleBackColor = true;
            this.btnGonder.Click += new System.EventHandler(this.btnGonder_Click);
            // 
            // SendMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 416);
            this.Controls.Add(this.btnGonder);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richtxtContent);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.txtWhom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SendMail";
            this.Text = "Mail Gönderme";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGonder;
        public System.Windows.Forms.TextBox txtSubject;
        public System.Windows.Forms.RichTextBox richtxtContent;
        public System.Windows.Forms.TextBox txtWhom;
    }
}