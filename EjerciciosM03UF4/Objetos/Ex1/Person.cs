using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos.Ex1
{
    public class Person
    {
        private string fisrtName,
            lastName;
        private int age;

        public Person(string fisrtName, string lasrtName, int age)
        {
            FirstName = fisrtName;
            LastName = lasrtName;
            Age = age;
        }

        public string FirstName
        {
            get { return fisrtName; }
            set { fisrtName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
    }
}
