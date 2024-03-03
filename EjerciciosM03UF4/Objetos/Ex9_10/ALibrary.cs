using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos.Ex9_10
{
    public abstract class ALecture
    {
        public string Name { get; set; }
        public string Publicher { get; set; }
        public string ReleaseDate { get; set; }
        public int BookNumber { get; set; }
        public int Pages { get; set; }
        public string Author { get; set; }
        public string Categorty { get; set; }

        public ALecture(
            string name,
            string publisher,
            string releaseDate,
            int bookNumber,
            int pages,
            string author,
            string category
        ) 
        {
            this.Name = name;
            this.Publicher = publisher;
            this.ReleaseDate = releaseDate;
            this.BookNumber = bookNumber;
            this.Pages = pages;
            this.Author = author;
            this.Categorty = category;
        }
    }
}
