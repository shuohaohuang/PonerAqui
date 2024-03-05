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
        
    }
}
