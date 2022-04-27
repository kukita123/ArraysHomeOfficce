using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseOOP_Properties
{
    class Point
    {
        private double x;
        private double y;

        public Point()
        {
            this.x = 0;
            this.y = 0;
        }
        public Point(double x,double y)
        {
            this.x = x;
            this.y = y;
        }

        public double X
        {
            get { return x; }
            set { x = value; }
        }
        public double Y
        {
            get { return y; }
            set { y = value; }
        }
        public double Distance(Point p)
        {
            //p.X  p.Y
            return Math.Sqrt(Math.Pow(this.x - p.X, 2) + Math.Pow(this.y - p.Y, 2));
        }


    }
}
