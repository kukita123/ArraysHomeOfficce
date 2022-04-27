using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseOOP_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Point A = new Point();
            Console.WriteLine("Xa={0}, Ya={1}",A.X,A.Y);
            A.X = 5;
            A.Y = -3;
            Console.WriteLine("Xa={0}, Ya={1}", A.X, A.Y);
            Point B = new Point(-2, -6);
            Console.WriteLine("Xb={0}, Yb={1}", B.X, B.Y);

            double d1 = A.Distance(B);
            double d2 = B.Distance(A);

            Console.WriteLine("Distance A -> B: {0}",Math.Round(d1,2));
            Console.WriteLine("Distance B -> A: {0}", Math.Round(d2,2));

            //int[] arr = new int[12];

            Random r = new Random();
            int n = r.Next(3, 10);

            Point[] points = new Point[n];
            for (int i = 0; i < points.Length; i++)
            {
                points[i] = new Point();
            }

            for (int i = 0; i < points.Length; i++)
            {
                points[i].X = r.Next(-10, 10);
                points[i].Y = r.Next(-10, 10);
                Console.WriteLine("Xpoint={0}, Ypoint={1}", points[i].X, points[i].Y);
            }

            double min = points[0].Distance(points[1]);
            for (int i = 0; i < points.Length - 1; i++)
            {
                for (int j = i+1; j < points.Length; j++)
                {
                    double dp = points[i].Distance(points[j]);
                    if (dp<min)
                    {
                        min = dp;
                    }
                }
            }
            Console.WriteLine(min);
           
 


            Console.ReadKey();
        }
    }
}
