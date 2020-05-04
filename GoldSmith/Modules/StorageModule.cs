using GoldSmith.Modules.Class;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;

namespace GoldSmith.Modules
{
    public class StorageModule : Storage
    {
        Database.Database database;

        public bool Insert(Storage storage)
        {
            try
            {
                database = new Database.Database();


                string query = string.Format("INSERT INTO Storage (StorageType,StorageTaxNumber,StorageSize,StorageAdress,StoragePhoneNumber,StorageFaxNumber) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}')",
                                     storage.StorageType, storage.StorageTaxNumber, storage.StorageSize
                                     , storage.StorageAddress, storage.StoragePhoneNumber, storage.StorageFaxNumber);


                database.ExecuteQueries(query);
            }
            catch (Exception ex)
            {
                return false;

            }
            return true;
        }
        public bool Update(Storage storage)
        {
            try
            {
                database = new Database.Database();

                string query = string.Format("UPDATE Storage SET StorageType='{0}',StorageTaxNumber='{1}''StorageSize{2}',StorageAdress='{3}',StoragePhoneNumber='{4}',StorageFaxNumber='{5}' WHERE StorageID ='{6}'",
                        storage.StorageType, storage.StorageTaxNumber, storage.StorageSize, storage.StorageAddress, storage.StoragePhoneNumber, storage.StorageFaxNumber, storage.StorageId);

                database.ExecuteQueries(query);
            }
            catch (Exception ex)
            {

                return false;
            }

            return true;
        }


        public DataTable GetStorage()
        {
            database = new Database.Database();

            string query = "SELECT * FROM Storage";
            var storage = database.ShowDataInGridView(query);

            return storage;
        }


        public int Delete(int id)
        {

            database = new Database.Database();
            string query = string.Format("DELETE FROM Storage WHERE StorageId = {0}", id);

            var storage = database.ExecuteQueries(query);
            return storage;
        }


        public DataTable Search(long storageTaxNumber, string storageType)
        {
            database = new Database.Database();

            string query = "SELECT * FROM Storage ";
            string options = string.Empty;

            if (storageTaxNumber > 0 && string.IsNullOrEmpty(storageType))
            {
                options = "WHERE StorageTaxNumber =" + storageTaxNumber;
            }
            else if (storageTaxNumber == 0 && !string.IsNullOrEmpty(storageType))
            {
                options = "WHERE StorageType LIKE '%" + storageType + "%'";
            }
            else if (storageTaxNumber > 0 && !string.IsNullOrEmpty(storageType))
            {
                options = "WHERE StorageTaxNumber = '" + storageTaxNumber + "' AND StorageType LIKE '%" + storageType + "%'";
            }

            query = query + options;

            var storage = database.ShowDataInGridView(query);

            return storage;
        }
    }
}