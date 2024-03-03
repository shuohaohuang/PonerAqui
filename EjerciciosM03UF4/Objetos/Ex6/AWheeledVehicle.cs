using Objetos.Ex6;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos.Ex6
{
    public abstract class AWheeledVehicle : AVehicle
    {
        public int Wheels { get; set; }

        public AWheeledVehicle(string ground, string name, string description, int power, int wheels)
            : base(ground, name, description, power)
        {
            Wheels = wheels;
        }
    }
}
