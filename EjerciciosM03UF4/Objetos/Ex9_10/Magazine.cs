using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos.Ex9_10
{
    public class Magazine : ALecture,ILendAble
    {
        public Magazine(string name, string publisher, string releaseDate, int bookNumber, int pages, string author, string category) : base(name, publisher, releaseDate, bookNumber, pages, author, category)
        {
        }
        public void Crop()
        {
            Console.WriteLine("{0} fue recortado",this.Name);
        }
        public void Read()
        {
            Console.WriteLine("reading");
        }
        public void Lend()
        {
            Console.WriteLine("Has cogido prestado prestado {0}", this.Name); ;
        }

        public void _ReTurn()
        {
            Console.WriteLine("Has devuelto {0}", this.Name);
        }

        public int BeLate()
        {
            return 2;
        }
    }
}
