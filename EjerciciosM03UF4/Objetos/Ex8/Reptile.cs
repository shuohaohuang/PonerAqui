using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos.Ex8
{
    public class Reptile: AAnimals,IEatAble
    {
        public Reptile(string name, string diet, int avgWeight, int legs, int eggsPerNest) : base(name, diet, avgWeight, legs)
        {
            this.EggsPerNest = eggsPerNest;
        }

        public int EggsPerNest { get; set; }

        public void Eat()
        {
            Console.WriteLine("{0} is eating", this.name);

        }
    }
}
