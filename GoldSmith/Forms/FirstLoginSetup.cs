using GoldSmith.Class;
using GoldSmith.Modules;
using GoldSmith.Modules.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GoldSmith.Forms
{
    public partial class FirstLoginSetup : Form
    {

        int userId = 0;

        FirstLoginSetupModules firstLoginSetupModule = new FirstLoginSetupModules();
        User user = new User();

        public FirstLoginSetup(int userId)
        {
            InitializeComponent();
            this.userId = userId;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            user.UserID = userId;
            user.UserName = txtUsername.Text;
            user.Password = txtPassword.Text;
            user.Name = txtName.Text;
            user.Surname = txtSurname.Text;
            user.Email = txtEmail.Text;
            user.PhoneNumber = txtPhoneNumber.Text;
            user.Salary = txtSalary.Text;
            user.Firstlogin = "1";
            user.SecurityQuestion = cmbSecurityQuestion.SelectedItem.ToString();
            user.SecurityAnswer = txtSecurityAnswer.Text;

            if (!BosMu())
            {

                firstLoginSetupModule.Save(user);
                MessageBox.Show("Başarılı bir şekilde eklendi.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Ekleme başarısız.");
            }
        }

        private bool BosMu()
        {
            if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text) || string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtSurname.Text) || string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtPhoneNumber.Text) || string.IsNullOrEmpty(txtSalary.Text) || string.IsNullOrEmpty(cmbSecurityQuestion.SelectedText) || string.IsNullOrEmpty(txtSecurityAnswer.Text))
            {

                return false;
            }
            else
            {
                MessageBox.Show("Lütfen Gerekli Alanları Doldurunuz!", "EKSİK BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Çıkış", "KURULUMU İPTAL ET", MessageBoxButtons.OK, MessageBoxIcon.Question);
            this.Close();
            Login lgn = new Login();
            lgn.Show();
        }
    }
}
