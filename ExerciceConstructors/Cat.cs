using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceConstructors
{
    class Cat
    {
        private string name;
        private string color;
        private int age;

        public Cat()
        {
            this.name = "Maca";
            this.color = "White";
            this.age = 0;
        }
        public Cat(string name, string color)
        {
            this.name = name;
            this.color = color;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }

        }
        public string Color
        {
            get;set;
        }

        public int Age
        {
            set;get;
        }

        public void Mqukane()
        {
            Console.WriteLine($"The {this.color} cat {this.name} said Miqauuuuuuu");
        }
        public void Myrkane()
        {
            Console.WriteLine($"The {this.color} cat {this.name} said Myyrrrrr");
        }

        //....
    }
}
