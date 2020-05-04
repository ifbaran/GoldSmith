using GoldSmith.Class;
using GoldSmith.Modules.Class;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldSmith.Modules
{
    class FirstLoginSetupModules : User
    {
        Database.Database database;

        public bool Save(User user)

        {
            try
            {
                database = new Database.Database();

                string query = string.Format("UPDATE User SET UserName= '{0}',Password='{1}',Name='{2}',Surname='{3}',Email='{4}',PhoneNumber='{5}',Salary='{6}',FirstLogin='{7}',SecurityQuestion='{8}',SecurityAnswer = '{9}' WHERE UserId={10}",
                   user.UserName, user.Password, user.Name, user.Surname, user.Email, user.PhoneNumber, user.Salary, user.Firstlogin, user.SecurityQuestion, user.SecurityAnswer, user.UserID);


                database.ExecuteQueries(query);

            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
    }
}