using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceConstructors
{



    class Program
    {
        static void Main(string[] args)
        {
            //Cat cote1 = new Cat();
            //Console.WriteLine(cote1.Name);
            //Console.WriteLine(cote1.Color);
            //Console.WriteLine(cote1.Age);

            //cote1.Color = "Red";
            //Console.WriteLine(cote1.Color);

            //Cat cote2 = new Cat("Keta", "Black");
            //Console.WriteLine();
            //Console.WriteLine(cote2.Name);
            //Console.WriteLine(cote2.Color);
            //Console.WriteLine(cote2.Age);
            //cote2.Name="Alex";
            //Console.WriteLine(cote2.Name);

            //cote1.Mqukane();
            //cote2.Myrkane();

            //Triangle t1 = new Triangle();
            //Triangle t2 = new Triangle(3, 3, 3);
            //Triangle t3 = new Triangle(4, 4, 4, "red");

            //Console.WriteLine(t1.TriangleArea(t1));

            TriangleProperties t1 = new TriangleProperties();
            Console.WriteLine("Triangle area={0}",Math.Round(t1.Area(),2));
            Console.WriteLine("Strana a={0}",t1.A);
            Console.WriteLine();

            TriangleProperties t2 = new TriangleProperties(4, 5, 6);
            Console.WriteLine("Strana a={0}", t2.A);
            Console.WriteLine("Strana b={0}", t2.B);
            Console.WriteLine("Strana c={0}", t2.C);

            t2.B = 6;
            Console.WriteLine("Strana b={0}", t2.B);
           
            //!!!!!!!!!!!!!!!! масив от обекти! !!!!!!!!!!!!!!!!!!!! всеки обект трябва да се създаде с new
            TriangleProperties[] triangles = new TriangleProperties[5]; 
            for (int i = 0; i < triangles.Length; i++)
            {
                triangles[i] = new TriangleProperties();
            }




            Console.ReadKey();
        }
    }
}
