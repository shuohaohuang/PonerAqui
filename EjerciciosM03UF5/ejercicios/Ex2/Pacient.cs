using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.Ex2

{
    public class Pacient
    {
        public string? Breed {  get; set; }
        public string? Name { get; set; }
        public float Weight { get; set; }
        public int Years { get; set; }
        public Pacient(string name,string breed, float weight, int years)
        {
            this.Name = name;
            this.Breed = breed;
            this.Weight = weight;
            this.Years = years;
        }
    }
}
