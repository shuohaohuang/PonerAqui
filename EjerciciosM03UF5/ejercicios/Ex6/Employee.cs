using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.Ex6
{
    public class Employee
    {
        private const float DefaultDalary = 1800f;
        private const int DefaultPayments = 14;

        public Employee(string firstName, string lastName, DateTime birthDate, string code, DateTime hireData, float monthSalary, int payments)
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

        public Employee(string firstName, string lastName, DateTime birthDate, string code, DateTime hireData):this(firstName,lastName,birthDate,code,hireData,DefaultDalary,DefaultPayments){

        }

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
            int age= DateTime.Now.Year-BirthDate.Year-1;
            bool pastDay= DateTime.Now.Day>=BirthDate.Day;
            bool pastMonth = DateTime.Now.Month > BirthDate.Month;
            bool sameMonth = DateTime.Now.Month == BirthDate.Month;
            if (pastMonth) return ++age;
            if(sameMonth&pastDay)return ++age;
            return age;
        }
    }
}
