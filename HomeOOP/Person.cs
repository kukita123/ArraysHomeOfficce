using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeOOP
{
    class Person
    {
        public int Id;
        public string FirstName;
        public string LastName;
        public DateTime BirthDate;

        public Person()
        {
            this.BirthDate = new DateTime();
        }

        public Person(int id)
           :this()
        {
            this.Id = id;
        }

        public Person(int id, string firstName)
           :this(id)
        {

            this.FirstName = firstName;
        }


        public Person(int id, string firstName, string lastName)
            :this(id,firstName)
        {
            this.LastName = lastName;
        }

        public Person(int id, DateTime birthDate)
            :this(id)
        {
            this.BirthDate = birthDate;
        }

    }
}
