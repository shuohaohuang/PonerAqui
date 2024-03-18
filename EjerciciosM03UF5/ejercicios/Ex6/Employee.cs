using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using static Ejercicios.Ex3.Date;

namespace Ejercicios.Ex6
{
    public class Employee : IComparable<Employee>
    {
        private const float DefaultDalary = 1800f;
        private const int DefaultPayments = 14;

        public Employee(
            string firstName,
            string lastName,
            DateTime birthDate,
            string code,
            DateTime hireData,
            float monthSalary,
            int payments
        )
        {
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
            Code = code;
            HireData = hireData;
            MonthSalary = monthSalary;
            Payments = payments;
            numEmployees = 0;
        }

        public Employee(
            string firstName,
            string lastName,
            DateTime birthDate,
            string code,
            DateTime hireData
        )
            : this(firstName, lastName, birthDate, code, hireData, DefaultDalary, DefaultPayments)
        { }

        ~Employee()
        {
            numEmployees--;
        }

        private static int numEmployees = 0;

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Code { get; set; }
        public DateTime HireData { get; set; }
        public float MonthSalary { get; set; }
        public int Payments { get; set; }

        public int Age()
        {
            int age = DateTime.Now.Year - BirthDate.Year - 1;
            bool pastDay = DateTime.Now.Day >= BirthDate.Day;
            bool pastMonth = DateTime.Now.Month > BirthDate.Month;
            bool sameMonth = DateTime.Now.Month == BirthDate.Month;
            if (pastMonth)
                return ++age;
            if (sameMonth & pastDay)
                return ++age;
            return age;
        }

        public string FullName()
        {
            return this.FirstName + " " + this.LastName;
        }

        public string FullNameReverse()
        {
            return this.LastName + " " + this.FirstName;
        }

        public int Antiquity()
        {
            DateTime today = DateTime.Now;
            int years = today.Year - HireData.Year;
            if (this.HireData > today.AddYears(-years))
            {
                years--;
            }
            return years;
        }

        public float AnnualSalary()
        {
            return this.MonthSalary * this.Payments;
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("-----------------------------------------------------------------------------------------------------\r\n                           E M P L O Y E E\r\n-----------------------------------------------------------------------------------------------------\r\n");
            stringBuilder.Append($">Code: {this.Code}\r\n");
            stringBuilder.Append($">Firstname: {this.FirstName}\r\n");
            stringBuilder.Append($">Last name: {this.LastName}\r\n");
            stringBuilder.Append($">Full name: {this.FullName()}  \r\n");
            stringBuilder.Append($">Reverse name: {this.FullNameReverse()}\r\n");
            stringBuilder.Append($">Age: {this.Age()}\r\n");
            stringBuilder.Append($">Seniority:{this.Antiquity()}\r\n");
            stringBuilder.Append($">Annual salary:{this.AnnualSalary()}\r\n");

            return stringBuilder.ToString();
        }

        public int CompareTo(Employee? other)
        {
            if(other==null) return 0;
            return other.Antiquity().CompareTo(this.Antiquity());
        }
    }
}
