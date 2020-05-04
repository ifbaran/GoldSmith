using GoldSmith.Class;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldSmith.Modules
{
    public class SalerModule : Saler
    {
        Database.Database database;

        public virtual bool Insert(Saler saler)
        {

            try
            {
                database = new Database.Database();

                string query = string.Format("INSERT INTO Saler (FirmName,FirmTitle,TaxNumber,TaxOffice,Address,WorkPhone,CellPhone,FaxNumber,Email) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')",
                                    saler.FirmName, saler.FirmTitle, saler.TaxNumber, saler.TaxOffice, saler.Address, saler.WorkPhone, saler.CellPhone, saler.FaxNumber, saler.Email);
                
                database.ExecuteQueries(query);
            }
            catch (Exception ex)
            {
                return false;
            }

            return true;
        }

        public bool Update(Saler saler)
        {
            try
            {
                database = new Database.Database();

                string query = string.Format("UPDATE Saler SET FirmName='{0}',FirmTitle='{1}',TaxNumber='{2}',TaxOffice='{3}',Address='{4}',WorkPhone='{5}',CellPhone='{6}',FaxNumber='{7}',Email='{8}' WHERE SalerId='{9}'",
                      saler.FirmName, saler.FirmTitle, saler.TaxNumber, saler.TaxOffice, saler.Address, saler.WorkPhone, saler.CellPhone, saler.FaxNumber, saler.Email, saler.SalerId);
                
                database.ExecuteQueries(query);
            }
            catch (Exception ex)
            {
                
                return false;
            }

            return true;
        }

        public DataTable GetSaler()
        {
            database = new Database.Database();

            string query = "SELECT * FROM Saler";
            var saler = database.ShowDataInGridView(query);

            return saler;
        }

        public int Delete(int id)
        {
            
            database = new Database.Database();
            string query = string.Format("DELETE FROM SALER WHERE SalerId = {0}", id);

            var saler = database.ExecuteQueries(query);
            return saler;
        }

        public DataTable Search(int taxNumber, string firmName)
        {
            database = new Database.Database();

            string query = "SELECT * FROM Saler ";
            string options = string.Empty;

            if (taxNumber > 0 && string.IsNullOrEmpty(firmName))
            {
                options = "WHERE TaxNumber=" + taxNumber;
            }
            else if (taxNumber == 0 && !string.IsNullOrEmpty(firmName))
            {
                options = "WHERE FirmName LIKE '%" + firmName + "%'";
            }
            else if (taxNumber > 0 && !string.IsNullOrEmpty(firmName))
            {
                options = "WHERE TaxNumber = '" + taxNumber + "' AND FirmName LIKE '%" + firmName + "%'";
            }

            query = query + options;

            var saler = database.ShowDataInGridView(query);

            return saler;
        }
    }
}
