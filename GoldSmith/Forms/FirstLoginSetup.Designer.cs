namespace GoldSmith.Forms
{
    partial class FirstLoginSetup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FirstLoginSetup));
            this.btnDel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.cmbSecurityQuestion = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSecurityAnswer = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDel
            // 
            this.btnDel.Image = ((System.Drawing.Image)(resources.GetObject("btnDel.Image")));
            this.btnDel.Location = new System.Drawing.Point(12, 311);
            this.btnDel.Name = "btnDel";
            this.btnDel.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnDel.Size = new System.Drawing.Size(152, 42);
            this.btnDel.TabIndex = 30;
            this.btnDel.Text = "     İptal";
            this.btnDel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(170, 311);
            this.btnSave.Name = "btnSave";
            this.btnSave.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnSave.Size = new System.Drawing.Size(152, 42);
            this.btnSave.TabIndex = 29;
            this.btnSave.Text = "     Kaydet";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.txtUsername);
            this.groupBox1.Controls.Add(this.cmbSecurityQuestion);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtSecurityAnswer);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtSalary);
            this.groupBox1.Controls.Add(this.txtPhoneNumber);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.txtSurname);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 278);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Admin Bilgileri";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "UserName";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(126, 55);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(145, 20);
            this.txtPassword.TabIndex = 21;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(126, 29);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(145, 20);
            this.txtUsername.TabIndex = 20;
            // 
            // cmbSecurityQuestion
            // 
            this.cmbSecurityQuestion.FormattingEnabled = true;
            this.cmbSecurityQuestion.Items.AddRange(new object[] {
            "İlk Evcil Hayvanınızın Adı?",
            "Anne Kızlık Soyadı?",
            "a",
            "b",
            "c",
            "d"});
            this.cmbSecurityQuestion.Location = new System.Drawing.Point(126, 212);
            this.cmbSecurityQuestion.Name = "cmbSecurityQuestion";
            this.cmbSecurityQuestion.Size = new System.Drawing.Size(145, 21);
            this.cmbSecurityQuestion.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 240);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Security Answer";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 214);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Security Question";
            // 
            // txtSecurityAnswer
            // 
            this.txtSecurityAnswer.Location = new System.Drawing.Point(126, 237);
            this.txtSecurityAnswer.Name = "txtSecurityAnswer";
            this.txtSecurityAnswer.Size = new System.Drawing.Size(145, 20);
            this.txtSecurityAnswer.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Salary";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "PhoneNumber";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Surname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Name";
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(126, 185);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(145, 20);
            this.txtSalary.TabIndex = 7;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(126, 159);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(145, 20);
            this.txtPhoneNumber.TabIndex = 6;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(126, 133);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(145, 20);
            this.txtEmail.TabIndex = 5;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(126, 107);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(145, 20);
            this.txtSurname.TabIndex = 4;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(126, 81);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(145, 20);
            this.txtName.TabIndex = 3;
            // 
            // FirstLoginSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 365);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox1);
            this.Name = "FirstLoginSetup";
            this.Text = "FirstLoginSetup";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.ComboBox cmbSecurityQuestion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSecurityAnswer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtName;
    }
}