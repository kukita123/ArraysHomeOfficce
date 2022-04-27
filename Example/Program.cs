using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number:");

            var str = Console.ReadLine();
            int x;
            bool check = int.TryParse(str, out x);
            if (!check)
                throw new Exception("Incorrect input data, you need a number!!!");

            x = int.Parse(str);
            Console.WriteLine("The number is: {0}", x);
            Console.ReadKey();
        }
    }
}
