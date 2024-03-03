using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos.Ex8
{
    public abstract class AAnimals
    {
        public string name {  get; set; }
        public float AvgWeight {  get; set; }
        public string Diet {  get; set; }
        public int Legs {  get; set; }

        public AAnimals(string name, string diet, int avgWeight,int legs)
        {
            this.name = name;
            this.Diet = diet;
            this.AvgWeight = avgWeight;
            this.Legs = legs;
        }


    }
}
