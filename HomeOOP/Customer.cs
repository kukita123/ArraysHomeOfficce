using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeOOP
{
    public class Customer
    {
        public int ID;
        public string Name;

        public Customer()
        {           
        }
        public Customer(string name)
        {
            Name = name;
        }
        public Customer(int id, string name)
        {
            this.ID = id;
            this.Name = name;
        }

    }
}
