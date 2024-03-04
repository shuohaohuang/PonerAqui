

using ejercicios.Ej1;
using Ejercicios.Ej1;

namespace EjerciciosM03Uf5
{
    public class M03UF5
    {
        public static void Main()
        {
            List<Book> Books = [];
            Books.Add(new Book());
            Books.Add(new Book(3, "Fausto", 1000));
            Books.Add(new Book(2, "Diccionario", 100));
            Books.Add(new Book(5, "La Odisea", 4000));
            Books.Add(new Book(4, "Nada", 300));
            

            Books.Sort(Book.CompareDescend);

            foreach (Book book in Books) 
            {
                Console.WriteLine(book);
            }
            Console.WriteLine("********************************");

            Books.Sort();

            foreach (Book book in Books)
            {
                Console.WriteLine(book);
            }
            Console.WriteLine("********************************");


            Books.Sort(new BookComparer());

            foreach (Book book in Books)
            {
                Console.WriteLine(book);
            }

        }
    }
}