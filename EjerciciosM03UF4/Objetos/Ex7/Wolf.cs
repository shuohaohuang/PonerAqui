using Objetos.Ex8;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos.Ex7
{
    public class Wolf : Mammal
    {

        public Wolf(string name, string diet, int avgWeight, int legs, int pregnancy,float kmPerHour) : base(name, diet, avgWeight, legs, pregnancy,kmPerHour)
        {
        }
    }
}
