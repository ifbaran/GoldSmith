using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldSmith.Class
{
    public class Saler
    {
        private int salerId;
        private string firmName;
        private string firmTitle;
        private string taxNumber;
        private string taxOffice;
        private string adress;
        private string workPhone;
        private string cellPhone;
        private string faxNumber;
        private string email;
        

        //properties
        public int SalerId { get => salerId; set => salerId = value; }
        public string FirmName { get => firmName; set => firmName = value; }
        public string FirmTitle { get => firmTitle; set => firmTitle = value; }
        public string TaxNumber { get => taxNumber; set => taxNumber = value; }
        public string TaxOffice { get => taxOffice; set => taxOffice = value; }
        public string Address { get => adress; set => adress = value; }
        public string WorkPhone { get => workPhone; set => workPhone = value; }
        public string CellPhone { get => cellPhone; set => cellPhone = value; }
        public string FaxNumber { get => faxNumber; set => faxNumber = value; }
        public string Email { get => email; set => email = value; }



    }
}
