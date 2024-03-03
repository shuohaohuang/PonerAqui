using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos.Ex8
{
    internal interface IEatAble
    {
        public virtual void Eat()
        {
            Console.WriteLine("eating");

        }
    }
}
