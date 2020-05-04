using GoldSmith.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static GoldSmith.Helper.Enums;

namespace GoldSmith
{
    public partial class Login : Form
    {
        Database.Database database = new Database.Database();
        public Login()
        {
            InitializeComponent();
        }

        private DataTable GetUsers()
        {
            string query = "SELECT * FROM User";
            var users = database.ShowDataInGridView(query);

            return users;
        }
        private DataTable GetPersonals()
        {
            string query = "SELECT * FROM Personal";
            var personals = database.ShowDataInGridView(query);

            return personals;
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            var users = GetUsers();
            var personals = GetPersonals();

            if (users?.Rows?.Count > 0)
            {
                DataRow[] filteredRows = users.Select("UserName = '" + txtUserName.Text + "' AND Password = '" + txtPassword.Text + "'");

                if (filteredRows?.Count() > 0)
                {
                    this.Hide();

                    int userId = Convert.ToInt32(filteredRows[0]["UserId"].ToString());

                    string query = string.Format("Select FirstLogin from User where UserId = {0}", userId);
                    Database.Database database = new Database.Database();
                    DataTable dt = database.ShowDataInGridView(query);
                    string zeroorone = dt.Rows[0][0].ToString();

                    if (zeroorone == "1")
                    {
                        Main main = new Main(userId,LoginType.User);
                        main.Show();
                        this.Hide();
                    }
                    else
                    {
                        FirstLoginSetup firstLoginSetup = new FirstLoginSetup(userId);
                        firstLoginSetup.ShowDialog();
                    }
                }
                else
                {
                    DataRow[] filteredRows1 = personals.Select("PersonalNickName = '" + txtUserName.Text + "' AND PersonalPassword = '" + txtPassword.Text + "'");

                    if (filteredRows1?.Count() > 0)
                    {
                        this.Hide();

                        int userId = Convert.ToInt32(filteredRows1[0]["Personalid"].ToString());

                        Main main = new Main(userId, LoginType.Personal);
                        main.Show();
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı adı veya şifre yanlış ! ");
                    }
                }
            }
            else
            {
                MessageBox.Show("Kullanıcı bulunamadı. ");
            }
        }

        private void linkForgetPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgetPass forgetPass = new ForgetPass();
            forgetPass.ShowDialog();
        }
    }
}
