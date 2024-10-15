using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldSmith.Helper
{
    public class Enums
    {
        public enum LoginType
        {
            User,
            Personal,
            Manager
        }
    }
    public class Ogrenci
    {
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}