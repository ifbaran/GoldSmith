using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldSmith.Modules.Class
{
    public class Customer : Person
    {
        private string surname;
        private string number;

        public string name { get => Name; set => Name = value; }
        public int id  { get => Id; set => Id = value; }
        public string address { get => Address; set => Address = value; }
        public string email { get => Email; set => Email = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Number { get => number; set => number = value; }
    }
}
