using GoldSmith.Class;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldSmith.Modules
{
    public class StoreModule
    {
        Database.Database database;
        Store store = new Store();

        public bool Insert(Store store)
        {
            try
            {
                database = new Database.Database();

                string query = string.Format("INSERT INTO Store (StoreName,StoreAdress,StoreOpenHour,StoreCloseHour,StoreStorage) VALUES ('{0}','{1}','{2}','{3}','{4}')"
                    , store.StoreName, store.StoreAdress, store.StoreOpenHour, store.StoreCloseHour, store.StoreStorage);

                database.ExecuteQueries(query);
            }
            catch (Exception ex)
            {
                return false;
            }

            return true;
        }


        public bool Update(Store store)
        {
            try
            {
                database = new Database.Database();

                string query = string.Format("UPDATE Store SET StoreName='{0}',StoreAdress='{1}',StoreOpenHour='{2}',StoreCloseHour='{3}',StoreStorage='{4}' WHERE StoreID='{5}'"
                    , store.storeName, store.StoreAdress, store.StoreOpenHour, store.StoreCloseHour, store.StoreStorage, store.StoreID);

                database.ExecuteQueries(query);
            }
            catch (Exception ex)
            {
                return false;
            }

            return true;
        }


        public int Delete(int StoreID)
        {

            database = new Database.Database();
            string query = string.Format("DELETE FROM STORE WHERE StoreID = {0}", StoreID);

            var store = database.ExecuteQueries(query);
            return store;
        }


        public DataTable GetStore()
        {
            database = new Database.Database();

            string query = "SELECT * FROM Store";
            var store = database.ShowDataInGridView(query);

            return store;
        }


        public DataTable Search(int StoreID, string StoreName)
        {
            database = new Database.Database();

            string query = "SELECT * FROM Store ";
            string options = string.Empty;

            if (StoreID > 0 && string.IsNullOrEmpty(StoreName))
            {
                options = "WHERE StoreID=" + StoreID;
            }
            else if (StoreID == 0 && !string.IsNullOrEmpty(StoreName))
            {
                options = "WHERE StoreName LIKE '%" + StoreName + "%'";
            }
            else if (StoreID > 0 && !string.IsNullOrEmpty(StoreName))
            {
                options = "WHERE StoreID = '" + StoreID + "' AND StoreName LIKE '%" + StoreName + "%'";
            }

            query = query + options;

            var store = database.ShowDataInGridView(query);

            return store;
        }
    }
}
