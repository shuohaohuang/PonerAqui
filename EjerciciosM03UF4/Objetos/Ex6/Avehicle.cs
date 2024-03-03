using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos.Ex6
{
    public abstract class AVehicle
    {
        public string Ground { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Power { get; set; }

        public AVehicle(string ground, string name, string description, int power)
        {
            this.Ground = ground;
            this.Name = name;
            this.Description = description;
            this.Power = power;
        }
    }
}
