using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisePropertiesConstructors
{
    class Triangle
    {
        private double a;
        private double b;
        private double c;

        public Triangle()
        {
            this.a = 1;
            this.b = 1;
            this.c = 1;
        }
        public Triangle(double a, double b, double c)
        {
            if (a>0 && b>0 && c>0 && a+b>c && b+c>a && a+c>b)
            {
                this.a = a;
                this.b = b;
                this.c = c;
            }
            else
            {
                Console.WriteLine("Wrong values , setting all sides to 1");
                this.a = 1;
                this.b = 1;
                this.c = 1;
            }
        }

        public double A
        {
            get { return a; }
            set {
                    //some code goes here - checking if a is correct!!!!
                    a = value;
            }
        }
        //some code - propertie for b
        //some code - propertie for c
        public double TiangleArea()
        {
            double p = (this.a + this.b + this.c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
        
        public bool IsIsosceles()
        {
            if (this.a==this.b && this.b==this.c && this.c==this.a)
            {
                return true;
            }
            return false;
        }

        public bool IsVersatile()
        {
            if (this.a != this.b && this.b != this.c && this.c != this.a)
            {
                return true;
            }
            return false;
        }
        public bool IsEquilateral()
        {
            if(!IsIsosceles() && !IsVersatile())
            {
                return true;
            }
            return false;
        }
        public void TriangleType()
        {
            if (IsIsosceles())
            {
                Console.WriteLine("Triangle is isosceles");
            }
            // if Equilateral
            //if Versatile
        }
    }
}
//isosceles
//isosceles
//versatile