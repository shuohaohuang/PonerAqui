using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos.Ex6
{
    public class FourDoorsCars : Car
    {
        private int doors = 4;

        public FourDoorsCars(string ground, string name, string description, int power, int wheels) : base(ground, name, description, power, wheels)
        {
        }

        public int Doors
        {
            get { return doors; }
        }

        
    }
}
