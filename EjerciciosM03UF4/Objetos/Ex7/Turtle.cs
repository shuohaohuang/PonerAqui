using Objetos.Ex8;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos.Ex7
{
    public class Turtle : Reptile
    {
        public string type {  get; set; }
        public Turtle(string name,string type, string diet, int avgWeight, int legs, int eggsPerNest) : base(name, diet, avgWeight, legs, eggsPerNest)
        {
            this.type = type;
        }


    }
}
