using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceConstructors
{
    class TriangleProperties
    {
        private double a;
        private double b;
        private double c;

        public TriangleProperties()
        {
            this.a = 3;
            this.b = 3;
            this.c = 3;
        }
        public TriangleProperties(double a,double b, double c)
        {
            if (a > 0 && b > 0 && c > 0 && a + b > c && b + c > a && a + c > b)
            { 
                this.a = a;
                this.b = b;
                this.c = c;
            }
            else
            {
                this.a = 3;
                this.b = 3;
                this.c = 3;
            }
        }
        public double A
        {
            get { return a; }
            set
            {
                if(a > 0)   //недостатъчна валидация, нужна е и проверка за връзката с b и c
                a = value;                
            }
        }
        public double B
        {
            get { return b; }
            set { if(b > 0) b = value; }   //недостатъчна валидация, нужна е и проверка за връзката с a и c
        }
        public double C
        {
            get { return c; }
            set { if (c > 0)c = value; }   //недостатъчна валидация, нужна е и проверка за връзката с b и a
        }
        public double Area()
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }
}
