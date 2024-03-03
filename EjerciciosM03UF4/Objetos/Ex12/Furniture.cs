using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos.Ex12
{
    public class Furniture
    {
        private const string NameC = "lampara",
                             MaterialC = "aluminium",
                             ColorC = "orange";
        private const float WeightC = 3f;
        private const double PriceC = 96d;
        private const bool SetC=false;

        public float Weight { get; set; }
        public double Price { get; set; }
        public bool Set { get; set; }
        public string Name { get; set; }
        public string Material { get; set; }
        public string Color { get; set; }

        public Furniture(string name, double price, string material, string color, float weight, bool set)
        {
            this.Name = name;
            this.Price = price;
            this.Material = material;
            this.Color = color;
            this.Weight = weight;
            this.Set = set;
        }
        public Furniture() : this(NameC, PriceC,MaterialC,ColorC,WeightC,SetC) { }

        public virtual void Sit() { }
        public virtual void Throw() { }


    }
}
