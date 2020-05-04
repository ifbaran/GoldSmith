using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldSmith.Modules
{
    public class AdminAuthorityModule
    {
        Database.Database database;
        public DataTable GetPersonalForAuthority()
        {
            database = new Database.Database();
            string query = "SELECT * FROM Personal";
            var personal = database.ShowDataInGridView(query);

            return personal;
        }

        public DataTable Search(string tcKimlikNumarasi, string surname)
        {
            database = new Database.Database();

            string query = "SELECT * FROM Personal ";
            string options = string.Empty;

            if (!string.IsNullOrEmpty(tcKimlikNumarasi) && string.IsNullOrEmpty(surname))
            {
                options = "WHERE PersonalNationalNumber LIKE '%" + tcKimlikNumarasi + "%'";
            }
            else if (string.IsNullOrEmpty(tcKimlikNumarasi) && !string.IsNullOrEmpty(surname))
            {
                options = "WHERE PersonalSurname LIKE '%" + surname + "%'";
            }
            else if (!string.IsNullOrEmpty(tcKimlikNumarasi) && !string.IsNullOrEmpty(surname))
            {
                options = "WHERE PersonalNationalNumber LIKE '%" + tcKimlikNumarasi + "%'" + " AND PersonalSurname LIKE '%" + surname + "%'";
            }

            query = query + options;

            var personal = database.ShowDataInGridView(query);

            return personal;
        }

    }
}
