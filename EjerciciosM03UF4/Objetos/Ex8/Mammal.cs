using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos.Ex8
{
    public class Mammal : AAnimals, IEatAble, IRunAble
    {
        public int pregnancy {  get; set; }
        public float KmPerHour { get ; set; }

        public Mammal(string name, string diet, int avgWeight, int legs, int pregnancy, float kmPerHour) : base(name, diet, avgWeight, legs)
        {
            this.pregnancy = pregnancy;
            KmPerHour = kmPerHour;
        }

        public void Eat()
        {
            Console.WriteLine("{0} is eating",this.name);
        }
        public void Run()
        {
            Console.WriteLine("{0} is running", this.name);
        }
    }
}
