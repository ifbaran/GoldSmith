namespace GoldSmith
{
    partial class ForgetPass
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txtSecurityAnswer = new System.Windows.Forms.TextBox();
            this.txtSecurityQuestion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.txtNewPass);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(67, 311);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(340, 85);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Parola Güncelleme .";
            this.groupBox3.Visible = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(46, 44);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(237, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "Kaydet";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtNewPass
            // 
            this.txtNewPass.Location = new System.Drawing.Point(132, 18);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.Size = new System.Drawing.Size(151, 20);
            this.txtNewPass.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Yeni Parolanız :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.txtSecurityAnswer);
            this.groupBox2.Controls.Add(this.txtSecurityQuestion);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(11, 133);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(447, 113);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Güvenlik Sorusu :";
            this.groupBox2.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(17, 78);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(413, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Cevapla";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtSecurityAnswer
            // 
            this.txtSecurityAnswer.Location = new System.Drawing.Point(165, 52);
            this.txtSecurityAnswer.Name = "txtSecurityAnswer";
            this.txtSecurityAnswer.Size = new System.Drawing.Size(265, 20);
            this.txtSecurityAnswer.TabIndex = 8;
            // 
            // txtSecurityQuestion
            // 
            this.txtSecurityQuestion.Enabled = false;
            this.txtSecurityQuestion.Location = new System.Drawing.Point(111, 19);
            this.txtSecurityQuestion.Name = "txtSecurityQuestion";
            this.txtSecurityQuestion.Size = new System.Drawing.Size(319, 20);
            this.txtSecurityQuestion.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Güvenlik Sorunuzun Cevabı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Güvenlik Sorusu :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtUserName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(67, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 79);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kullanıcı Adı Sorgulama";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(46, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(237, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Sorgula";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(132, 17);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(151, 20);
            this.txtUserName.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adınız :";
            // 
            // ForgetPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 404);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ForgetPass";
            this.Text = "ForgetPass";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtNewPass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtSecurityAnswer;
        private System.Windows.Forms.TextBox txtSecurityQuestion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label1;
    }
}