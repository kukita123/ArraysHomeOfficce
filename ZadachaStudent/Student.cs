using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadachaStudent
{
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
                if (marks > 2 && marks < 6)
                    this.marks = value;
                else
                    this.marks = 2;
            }
        }
        public void DisplayObject()
        {
            Console.WriteLine("{0} {1} -> {2}",this.name,this.familyName,this.marks);
        }
    }
}
