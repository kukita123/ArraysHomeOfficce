using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trucks
{
    class Freight
    {
        private string name;
        private int weight;

        public Freight()
        {
            this.name = "";
            this.weight = 0;
        }
        public Freight(string Name, int Weight)
        {
            this.name = Name;
            if (Weight > 0)
                this.weight = Weight;
            else
                this.weight = 0;
        }
        public string Name
        {
            set { this.name = value; }
            get { return this.name; }
        }
        public int Weight
        {
            get { return this.weight; }
            set { if (Weight > 0)
                    this.weight = value;
                else
                    this.weight = 0;
            }
        }
    }
}
