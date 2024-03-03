using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos.Ex9_10
{
    public class Book : ALecture,ILendAble
    {
        public int BookMark {  get; set; }
        public bool LinedBook {  get; set; }
        public Book(string name, string publisher, string releaseDate, int bookNumber, int pages, string author, string category, bool linedBook) : base(name, publisher, releaseDate, bookNumber, pages, author, category)
        {
            LinedBook = linedBook;
        }

        public void SetBookMark(int page)
        {
            this.BookMark = page;
        }

        public void LineBooK()
        {
            Console.WriteLine(LinedBook? "Ya estaba forrado":"Libro recien forrado");
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
