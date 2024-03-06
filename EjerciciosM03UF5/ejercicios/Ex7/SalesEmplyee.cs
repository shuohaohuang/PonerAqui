using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicios.Ex6;

namespace Ejercicios.Ex7
{
    public class SalesEmplyee : Employee
    {
        public SalesEmplyee(string firstName, string lastName, DateTime birthDate, string code, DateTime hireData, float monthSalary, int payments) : base(firstName, lastName, birthDate, code, hireData, monthSalary, payments)
        {
        }

        public float Commission { get; set; }

        public override string ToString()
        {
            string format =
                "-----------------------------------------------------------------------------------------------------\r\n                           E M P L O Y E E\r\n-----------------------------------------------------------------------------------------------------\r\n" +
                $">Code: {this.Code}\r\n" +
                $">Firstname: {this.FirstName}\r\n" +
                $">Last name: {this.LastName}\r\n" +
                $">Full name: {this.FullName()}  \r\n" +
                $">Reverse name: {this.FullNameReverse()}\r\n" +
                $">Age: {this.Age()}\r\n" +
                $">Seniority:{this.Antiquity()}\r\n" +
                $">Annual salary:{this.AnnualSalary()}\r\n"+
                $">Commission: {this.Commission}\r\n";
            return format;
        }

    }
}
