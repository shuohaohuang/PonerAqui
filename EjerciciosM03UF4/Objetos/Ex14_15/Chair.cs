using Objetos.Ex12;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos.Ex14_15
{
    public class Chair:Furniture
    {
        public override void Sit()
        {
            Console.WriteLine("sit");
        }
        public override void Throw()
        {
            Console.WriteLine("throw");
        }

        public void Sit(string name)
        {
            Console.WriteLine($"{name} sits on {this.Name}");
        }
        public void Throw(string name)
        {
            Console.WriteLine($"{name} throws {this.Name}");
        }
    }
}
