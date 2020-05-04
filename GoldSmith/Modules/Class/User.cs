using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldSmith.Modules.Class
{
    public class User
    {
        private int userID;
        private string userName;
        private string password;
        private string name;
        private string surname;
        private string email;
        private string phoneNumber;
        private string salary;
        private string firstlogin;
        private string securityQuestion;
        private string securityAnswer;
        public int UserID { get => userID; set => userID = value; }
        public string UserName { get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Email { get => email; set => email = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string Salary { get => salary; set => salary = value; }
        public string Firstlogin { get => firstlogin; set => firstlogin = value; }
        public string SecurityQuestion { get => securityQuestion; set => securityQuestion = value; }
        public string SecurityAnswer { get => securityAnswer; set => securityAnswer = value; }
    }
}
