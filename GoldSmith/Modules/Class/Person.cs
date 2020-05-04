using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldSmith.Modules.Class
{
    public class Person
    {
        private int id;
        private string name;
        private string address;
        private string email;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
        public string Email { get => email; set => email = value; }
    }
}
