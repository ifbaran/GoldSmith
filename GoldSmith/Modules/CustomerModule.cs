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
    public class CustomerModule : Customer
    {
        Database.Database database;
        public bool Insert( Customer customer)
        {
            try
            {
                database = new Database.Database();

                string query = string.Format("INSERT INTO Customer (CustomerName, CustomerSurname, CustomerNumber, CustomerAddress, CustomerEmail) VALUES ('{0}','{1}','{2}','{3}','{4}')", customer.name, customer.Surname, customer.Number, customer.address, customer.email);
                database.ExecuteQueries(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }

            return true;

        }

        public bool Update(Customer customer)
        {
            try
            {
                database = new Database.Database();
                string query = string.Format("UPDATE Customer SET CustomerName='{0}',CustomerSurname='{1}',customerNumber='{2}',customerAddress='{3}',customerEmail='{4}'WHERE customerid='{5}'", customer.name, customer.Surname, customer.Number, customer.address, customer.email, customer.id);

                database.ExecuteQueries(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }

            return true;
        }

        public DataTable GetCustomer()
        {
            database = new Database.Database();
            string query = "SELECT * FROM Customer";
            var customer = database.ShowDataInGridView(query);

            return customer;

        }

        public int Delete(int id)
        {

            database = new Database.Database();
            string query = string.Format("DELETE FROM Customer WHERE CustomerID = {0}", id);

            var customer = database.ExecuteQueries(query);
            return customer;
        }

        public DataTable Search(int id, string surname)
        {
            database = new Database.Database();

            string query = "SELECT * FROM Customer ";
            string options = string.Empty;

            if (id > 0 && string.IsNullOrEmpty(surname))
            {
                options = "WHERE CustomerID =" + id;
            }
            else if (id == 0 && !string.IsNullOrEmpty(surname))
            {
                options = "WHERE CustomerSurname LIKE '%" + surname + "%'";
            }
            else if (id > 0 && !string.IsNullOrEmpty(surname))
            {
                options = "WHERE CustomerID = '" + id + "' AND CustomerSurname LIKE '%" + surname + "%'";
            }

            query = query + options;

            var customer = database.ShowDataInGridView(query);

            return customer;
        }
    }
}
