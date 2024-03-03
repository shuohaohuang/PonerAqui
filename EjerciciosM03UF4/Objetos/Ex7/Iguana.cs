using Objetos.Ex8;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos.Ex7
{
    public class Iguana : Reptile, IRunAble
    {
        public Iguana(string name, string diet, int avgWeight, int legs, int eggsPerNest, float kmPerHour) : base(name, diet, avgWeight, legs, eggsPerNest)
        {
            KmPerHour = kmPerHour;
        }

        public float KmPerHour { get; set; }
    }
}
