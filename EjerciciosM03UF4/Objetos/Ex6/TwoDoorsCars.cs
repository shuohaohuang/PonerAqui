using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos.Ex6
{
    public class TwoDoorsCars : Car
    {
        private int doors = 2;

        public TwoDoorsCars(string ground, string name, string description, int power, int wheels) : base(ground, name, description, power, wheels)
        {
        }

        public int Doors
        {
            get { return doors; }
        }

        
    }
}
