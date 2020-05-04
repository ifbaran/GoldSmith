using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GoldSmith.Modules.Class;

namespace GoldSmith.Modules
{
    public class PersonalModule : Personal
    {
        Database.Database database;

        public bool Insert(Personal personal, int roleID)
        {
            try
            {
                database = new Database.Database();

                string query = string.Format("INSERT INTO Personal (PersonalName,PersonalSurname,PersonalNationalNumber,PersonalNumber,PersonalAddress,PersonalEmail,PersonalTitle,PersonalNickName,PersonalPassword) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')", personal.PersonalName, personal.PersonalSurname, personal.PersonalNationalNumber, personal.PersonalNumber, personal.PersonalAddress, personal.PersonalEmail, personal.PersonalTitle,personal.PersonalNickName,personal.PersonalPassword);
                database.ExecuteQueries(query);

                string query1 = string.Format("INSERT INTO UserRole (Personalid,RoleId) VALUES ({0},{1})", personal.PersonalId, roleID);
                database.ExecuteQueries(query1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }

            return true;

        }

        public bool Update (Class.Personal personal)
        {
            try
            {
                database = new Database.Database();
                string query = string.Format("UPDATE Personal SET PersonalName='{0}',PersonalSurname='{1}',PersonalNationalNumber='{2}',PersonalNumber='{3}',PersonalAddress='{4}',PersonalEmail='{5}',PersonalTitle='{6}',PersonalNickName='{7}',PersonalPassword='{8}'WHERE Personalid='{9}'", personal.PersonalName, personal.PersonalSurname, personal.PersonalNationalNumber, personal.PersonalNumber, personal.PersonalAddress, personal.PersonalEmail, personal.PersonalTitle,personal.PersonalNickName,personal.PersonalPassword, personal.PersonalId);

                database.ExecuteQueries(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }

            return true;
        }

        public DataTable GetPersonal()
        {
            database = new Database.Database();
            string query = "SELECT * FROM Personal";
            var personal = database.ShowDataInGridView(query);

            return personal;

        }

        public int Delete(int id)
        {

            database = new Database.Database();
            string query = string.Format("DELETE FROM Personal WHERE Personalid = {0}", id);

            var personal = database.ExecuteQueries(query);
            return personal;
        }

        public DataTable Search(long tcKimlikNumarasi, string surname)
        {
            database = new Database.Database();

            string query = "SELECT * FROM Personal ";
            string options = string.Empty;

            if (tcKimlikNumarasi > 0 && string.IsNullOrEmpty(surname))
            {
                options = "WHERE PersonalNationalNumber =" + tcKimlikNumarasi;
            }
            else if (tcKimlikNumarasi == 0 && !string.IsNullOrEmpty(surname))
            {
                options = "WHERE PersonalSurname LIKE '%" + surname + "%'";
            }
            else if (tcKimlikNumarasi > 0 && !string.IsNullOrEmpty(surname))
            {
                options = "WHERE PersonalNationalNumber = '" + tcKimlikNumarasi + "' AND PersonalSurname LIKE '%" + surname + "%'";
            }

            query = query + options;

            var personal = database.ShowDataInGridView(query);

            return personal;
        }
    }
}
