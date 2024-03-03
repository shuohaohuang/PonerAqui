using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    internal class Beverage : AItem, IMenu
    {
        public double Size { get; set; }
        public bool WithIce { get; set; }

        public Beverage(
            string? name,
            string? description,
            double price,
            bool onSpecial,
            int quantity,
            double size,
            bool withIce
        )
            : base(name, description, price, onSpecial, quantity)
        {
            this.Size = size;
            this.WithIce = withIce;
        }

        public void AddItem(AItem beverage)
        {
            Console.WriteLine($"añadir {beverage}");
        }

        public override void UpdateInventory(int quantyReceived)
        {
            this.Quantity += quantyReceived;
            Console.WriteLine($"añadir {quantyReceived} de {this.Name}");
        }

        public void toString(int type)
        {
            Console.WriteLine(
                $"Name:{this.Name}\n" +
                $"Description:{this.Description}\n" +
                $"Price:{this.Price}\n" +
                $"On Special:{this.OnSpecial}\n" +
                $"Quantity: {this.Quantity}\n" +
                $"Size: {this.Size}\n" +
                $"With ice:{this.WithIce}"
            );
        }
    }
}
