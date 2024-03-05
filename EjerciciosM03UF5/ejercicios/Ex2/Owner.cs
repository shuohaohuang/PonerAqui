using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.Ex2
{
    public class Owner
    {
        public string? Name{get;set;}
        public string? Dni { get;set;}
        public int Phone {  get;set;}

        public Owner (string name, string dni, int phone)
        {
            this.Name = name;
            this.Dni = dni;
            this.Phone = phone;
        }
    }
}
