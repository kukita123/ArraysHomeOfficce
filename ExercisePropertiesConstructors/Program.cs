using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisePropertiesConstructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle t1 = new Triangle();
            t1.TriangleType();
            t1.A = 2;
            // t1.B =....;
            Console.WriteLine();
            Triangle t2 = new Triangle(5, 5, 8);
            Console.WriteLine("Strana a=" + t2.A);

            Console.WriteLine(t2.TiangleArea());

            Console.ReadKey();

        }
    }
}
