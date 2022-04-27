using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceConstructors
{
    class Triangle
    {
        public double a;
        public double b;
        public double c;
        public string color;

        public Triangle()
        {
            this.a = 10;
            this.b = 10;
            this.c = 10;
            this.color = "blue";
        }
        public Triangle(double a, double b, double c)
            :this()
        {
            if (IfExists(a,b,c))
            {
                this.a = a;
                this.b = b;
                this.c = c;
            }
            else
                Console.WriteLine("Wrong values, setting the triangle by default");
        }
        public Triangle(double a, double b, double c, string color)
            :this(a,b,c)
        {
            this.color = color;
        }
        public bool IfExists(double a, double b, double c)
        {
            if (a > 0 && b > 0 && c > 0 && a + b > c && a + c > b && b + c > a)
            {
                return true;
            }
            else
                return false;
        }
        public double TriangleArea(Triangle t1)
        {
            double p = (t1.a + t1.b + t1.c) / 2;
            return Math.Sqrt(p*(p - a) * (p - b) * (p - c));
       }
    }
}
