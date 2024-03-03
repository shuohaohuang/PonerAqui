using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos.Ex6
{
    public class bicycle : AWheeledVehicle
    {

        public bicycle(string ground, string name, string description, int power, int wheels) : base(ground, name, description, power, wheels)
        {
        }
        
    }
}
