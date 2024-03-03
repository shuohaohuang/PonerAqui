using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class Food : AItem, IMenu
    {
        public int PreparationTime { get; set; }
        public int Type { get; set; }

        public Food(
            string? name,
            string? description,
            double price,
            bool onSpecial,
            int quantity,
            int preparationTime,
            int type
        )
            : base(name, description, price, onSpecial, quantity)
        {
            PreparationTime = preparationTime;
            Type = type;
        }

        public void AddItem(AItem food)
        {
            Console.WriteLine($"añadir {food}");
        }

        public override void UpdateInventory(int quantyReceived)
        {
            this.Quantity += quantyReceived;
            Console.WriteLine($"añadir {quantyReceived} de {this.Name}");
        }

        public int CalculateTimeCooking(int type)
        {
            return this.PreparationTime * this.Type;
        }
    }
}
