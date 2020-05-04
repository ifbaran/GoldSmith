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
    public class Store
    {
        public int storeID;
        public string storeName;
        public string storeAdress;
        public string storeOpenHour;
        public string storeCloseHour;
        public string storeStorage;

        public int StoreID { get => storeID; set => storeID = value; }
        public string StoreName { get => storeName; set => storeName = value; }
        public string StoreAdress { get => storeAdress; set => storeAdress = value; }
        public string StoreOpenHour { get => storeOpenHour; set => storeOpenHour = value; }
        public string StoreCloseHour { get => storeCloseHour; set => storeCloseHour = value; }
        public string StoreStorage { get => storeStorage; set => storeStorage = value; }
    }
}
