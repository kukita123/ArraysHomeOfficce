using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trucks
{
    class Truck
    {
        private string truckName;
        private int truckWeight;
        private List<Freight> freights;

        public Truck()
        {
            this.truckName = "";
            this.truckWeight = 0;
            this.freights = new List<Freight>();
        }
        public Truck(string truckName, int truckWeight)
        {
            this.truckName = "truckName";
            this.truckWeight = truckWeight;
            this.freights = new List<Freight>();
        }
        public string TruckName
        {
            get { return this.truckName;}
            set { this.truckName= value; }
        }
        public int TruckWeight
        {
            get { return this.truckWeight; }
            set { this.truckWeight = value; }
        }
    }
}
