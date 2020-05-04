namespace GoldSmith
{
    partial class Login
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.linkForgetPass = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(197, 99);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Şifre";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(97, 12);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(184, 20);
            this.txtUserName.TabIndex = 2;
            this.txtUserName.Text = "a";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(97, 45);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(184, 20);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.Text = "a";
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // linkForgetPass
            // 
            this.linkForgetPass.AutoSize = true;
            this.linkForgetPass.Location = new System.Drawing.Point(158, 74);
            this.linkForgetPass.Name = "linkForgetPass";
            this.linkForgetPass.Size = new System.Drawing.Size(123, 13);
            this.linkForgetPass.TabIndex = 4;
            this.linkForgetPass.TabStop = true;
            this.linkForgetPass.Text = "Paralanızı mı Unuttunuz?";
            this.linkForgetPass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkForgetPass_LinkClicked);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 133);
            this.Controls.Add(this.linkForgetPass);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLogin);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.LinkLabel linkForgetPass;
    }
}