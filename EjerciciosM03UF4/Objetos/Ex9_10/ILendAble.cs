using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos.Ex9_10
{
    internal interface ILendAble
    {
        public abstract void Lend();
        public abstract void _ReTurn();
        public abstract int BeLate();
    }
}
