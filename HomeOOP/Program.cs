using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeOOP
{


       class Program
    {
        static void Main(string[] args)
        {

            //Customer emptyCustomer = new Customer();
            ////man.Name = "Ivan";
            //Console.WriteLine(emptyCustomer.Name);
            //Console.WriteLine(emptyCustomer.ID);

            //Customer woman = new Customer("Mariana");
            //Console.WriteLine(woman.ID);
            //Console.WriteLine(woman.Name);

            //Customer man = new Customer(2, "Ivan");
            //Console.WriteLine(man.ID);
            //Console.WriteLine(man.Name);

            RationNumber rationNum1 = new RationNumber();
            rationNum1.DisplayData();
            Console.WriteLine();

            RationNumber rationNumber2 = new RationNumber(2, 3);
            rationNumber2.DisplayData();
            Console.WriteLine();
             
            RationNumber rationNumber3 = new RationNumber(2, 0);
            rationNumber3.DisplayData();
            Console.WriteLine();

            Person englishTeacher = new Person(1);
            englishTeacher.FirstName = "Iliana";
            Console.WriteLine(englishTeacher.Id+" "+englishTeacher.FirstName);

            

            Person progrTeacher = new Person(2, "Mariana");

            Console.ReadKey();
        }
    }
}
