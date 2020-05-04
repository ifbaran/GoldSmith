using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;

namespace GoldSmith.Modules.Class
{
    public class Storage
    {
        private int storageId;
        private string storageType;
        private string storageTaxNumber;
        private string storageSize;
        private string storageAdress;
        private string storagePhoneNumber;
        private string storageFaxNumber;



        //properties
        public int StorageId { get => storageId; set => storageId = value; }
        public string StorageType { get => storageType; set => storageType = value; }
        public string StorageTaxNumber { get => storageTaxNumber; set => storageTaxNumber = value; }
        public string StorageSize { get => storageSize; set => storageSize = value; }
        public string StorageAddress { get => storageAdress; set => storageAdress = value; }
        public string StoragePhoneNumber { get => storagePhoneNumber; set => storagePhoneNumber = value; }
        public string StorageFaxNumber { get => storageFaxNumber; set => storageFaxNumber = value; }
    }
}
