using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesUprazhnenieBase
{
    /*
     * Практическа задача:

Дефинирайте клас Student с член-данни име, фамилия, среден успех и следните методи:
- Конструктор по подразбиране и конструктор с параметри;
- Методи за достъп (setter, getter) до  член-данните;
Във Main декларирайте масив от n обекта от класа (3<=n<=20) и въведете конкретни стойности за член-данните им. 
Изчислете средния успех на въведените студенти и изведете имената на тези от тях, чиито успех е по-висок от средния.

     */
    class Student
    {
        private string name;
        private string familyName;
        private double marks;

        public Student()
        {
            this.name = "NoName";
            this.familyName = "NoFamilyName";
            this.marks = 2;
        }
        public Student(string name, string familyName, double marks)
        {
            this.name = name;
            this.familyName = familyName;
            if (marks > 2 && marks < 6)
                this.marks = marks;
            else
                this.marks = 2;
        }
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public string FamilyName
        {
            get { return this.familyName; }
            set { this.familyName = value; }
        }
        public double Marks
        {
            get { return this.marks; }
            set
            {
                if (value > 2 && value < 6)
                    this.marks = value;
                else
                    this.marks = 2;
            }
        }
        public void PrintStudent()
        {
            Console.WriteLine("{0} {1} - marks: {2}", this.name, this.familyName, this.marks);
        }

    }
}
