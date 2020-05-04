using GoldSmith.Class;
using GoldSmith.Modules;
using GoldSmith.Modules.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoldSmith
{
    public partial class ForgetPass : Form
    {
        Database.Database database = new Database.Database();
        User user = new User();
        ForgetPassModule forgetPassModule = new ForgetPassModule();
        public ForgetPass()
        {
            InitializeComponent();
        }
        public DataTable GetUser()
        {
            string query = "SELECT * FROM User";
            var user = database.ShowDataInGridView(query);

            return user;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var users = GetUser();

            if (users?.Rows?.Count > 0)
            {
                DataRow[] filteredRows = users.Select("UserName = '" + txtUserName.Text + "'");
                if (filteredRows?.Count() > 0)
                {
                    int userId = Convert.ToInt32(filteredRows[0]["UserId"].ToString());
                    SQLiteConnection con = new SQLiteConnection(@"Data Source=C:\Users\İbrahim Furkan BARAN\Desktop\Son Hal\GoldSmith\GoldSmith\Database\GOLDSMITH.db");
                    string query = String.Format("Select SecurityQuestion from User where UserId = '" + userId + "'");
                    var cmd = new SQLiteCommand(query, con);
                    {
                        DataTable dt = new DataTable();
                        SQLiteDataAdapter adp = new SQLiteDataAdapter(cmd);
                        adp.Fill(dt);
                        string securityQuestion = dt.Rows[0].Field<string>(0);
                        txtSecurityQuestion.Text = securityQuestion;
                        groupBox2.Visible = true;
                        groupBox1.Visible = false;
                    }
                }
                else
                {
                    MessageBox.Show("Böyle Bir Kullanıcı Adı Bulunamadı");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var users = GetUser();
            if (users?.Rows?.Count > 0)
            {
                SQLiteConnection con = new SQLiteConnection(@"Data Source=C:\Users\İbrahim Furkan BARAN\Desktop\Son Hal\GoldSmith\GoldSmith\Database\GOLDSMITH.db");
                DataRow[] filteredRows = users.Select("SecurityAnswer = '" + txtSecurityAnswer.Text + "'");
                if (filteredRows?.Count() > 0)
                {
                    groupBox3.Visible = true;
                    groupBox2.Visible = false;
                }
                else
                {
                    MessageBox.Show("Hatalı Security Answer!");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            user.Password = txtNewPass.Text;
            string query = string.Format("UPDATE User Set Password= '{0}' where UserId = {1}", user.Password, user.UserID);
            database.ShowDataInGridView(query);
        }
    }
}
