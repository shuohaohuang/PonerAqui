using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ejercicios.Ej1;

namespace Ejercicios.Ej1
{
    public class BookComparer : IComparer<Book>
    {
        public int Compare(Book? x, Book? y)
        {
            if (x == null) return 1;
            if (y == null) return -1;
            if (x == null && y == null) return 0;
            return -x.NumPages.CompareTo(y.NumPages);
        }
    }
}
