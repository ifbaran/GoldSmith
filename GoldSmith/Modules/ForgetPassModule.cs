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
    class ForgetPassModule
    {
        Database.Database database;
        User user = new User();



        public DataTable Search(string UserName)
        {
            database = new Database.Database();

            string query = "SELECT * FROM User ";
            string options = string.Empty;
            if (!string.IsNullOrEmpty(UserName))
            {
                options = "WHERE UserName= '" + UserName + "'";
            }

            query = query + options;

            var user = database.ShowDataInGridView(query);

            return user;
        }
    }
}
