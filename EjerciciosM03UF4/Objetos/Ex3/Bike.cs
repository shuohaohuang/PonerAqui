using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos.Ex3
{
    public class ATrasnport
    {
        public int Wheels { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public string Description { get; set; }

        public ATrasnport(string name, string brand, string description, int wheels)
        {
            Name = name;
            Brand = brand;
            Description = description;
            Wheels = wheels;
        }

        public ATrasnport(string name, string brand, string description)
            : this(name, brand, description, 2) { }
    }
}
