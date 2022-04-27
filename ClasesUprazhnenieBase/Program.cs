using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Практическа задача:

Дефинирайте клас Student с член-данни име, фамилия, среден успех и следните методи:
- Конструктор по подразбиране и конструктор с параметри;
- Методи за достъп (setter, getter) до  член-данните;
Във Main декларирайте масив от n обекта от класа (3<=n<=20) и въведете конкретни стойности за член-данните им. 
Изчислете средния успех на въведените студенти и изведете имената на тези от тях, чиито успех е по-висок от средния.

 */

namespace ClasesUprazhnenieBase
{
    class Program
    {
        static void Main(string[] args)
        {
            //Random r = new Random();
            //int n = r.Next(3, 20);
            int n = 3;

            Student[] students = new Student[n];
            for (int i = 0; i < students.Length; i++)
            {
                students[i] = new Student();
            }

            for (int i = 0; i < students.Length; i++)
            {
                Console.Write("Enter student's name: ");
                students[i].Name = Console.ReadLine();
                Console.Write("Enter student's family name:  ");
                students[i].FamilyName = Console.ReadLine();
                Console.Write("Enter student's marks:");
                students[i].Marks = double.Parse(Console.ReadLine());
            }

            double average = 0;
            for (int i = 0; i < students.Length; i++)
            {
                average += students[i].Marks;
            }
            average /= n;
            
            Console.WriteLine("Students with marks above average - {0} are:", Math.Round(average,2));
            foreach (var item in students)
            {
                if (item.Marks > average)
                    item.PrintStudent();
            }

            Console.ReadKey();

        }
    }
}
