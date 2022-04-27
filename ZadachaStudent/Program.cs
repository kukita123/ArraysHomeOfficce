using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadachaStudent
{
    class Program
    {
        static void Main(string[] args)
        {

            Student student1 = new Student("Мариана", "Христозкожа", 3.33);

            student1.DisplayObject();
            Console.ReadKey();
            int n;
            do
            {
                Console.Write("Enter n=");
                n = int.Parse(Console.ReadLine());
            }
            while (n < 3 || n > 20);

            Student[] studentsArray = new Student[n];
            for (int i = 0; i < studentsArray.Length; i++)
            {
                studentsArray[i] = new Student();
            }

            for (int i = 0; i < studentsArray.Length; i++)
            {
                Console.Write("Enter students name: ");
                studentsArray[i].Name = Console.ReadLine();

                Console.Write("Enter students family name: ");
                studentsArray[i].FamilyName = Console.ReadLine();

                Console.Write("Enter students marks:");
                studentsArray[i].Marks = double.Parse(Console.ReadLine());
            }

            double average = 0;
            for (int i = 0; i < studentsArray.Length; i++)
            {
                average += studentsArray[i].Marks;
            }
            average /= n;

            Console.WriteLine("Students above average:");
            for (int i = 0; i < studentsArray.Length; i++)
            {
                if (studentsArray[i].Marks > average)
                {
                    Console.WriteLine(studentsArray[i].Name+" "+studentsArray[i].FamilyName);
                }
            }

            Console.ReadKey();
        }
    }
}
