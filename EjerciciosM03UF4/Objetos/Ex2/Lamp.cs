using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos.Ex2
{
    public class Lamp
    {
        private string color;
        private float price;
        private string type;

        public Lamp(string color, float price, string type)
        {
            this.Color = color;
            this.Price = price;
            this.Type = type;
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        public float Price
        {
            get { return price; }
            set { price = value; }
        }
    }
}
