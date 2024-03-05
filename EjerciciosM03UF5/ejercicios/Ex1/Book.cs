namespace Ejercicios.Ex1
{
    public class Book:IComparable<Book>,IComparer<Book>
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int NumPages { get; set; }

        public Book(int id, string title, int numPages)
        {
            Id = id;
            Title = title;
            NumPages = numPages;
        }
        public Book():this(1,"Al",2){ }

        public override string ToString()
        {
            return string.Format("Id: {0} Title: {1} NumPages: {2} ", this.Id, this.Title, this.NumPages);
        }

        public int CompareTo(Book? other)
        {
            if (other == null) return 1;
            return this.NumPages.CompareTo(other.NumPages);
        }
        public static int CompareDescend(Book? one, Book? two)
        {
            if (one == null) return 1;
            return -one.NumPages.CompareTo(two.NumPages);
        }

        public int Compare(Book? x, Book? y)
        {
            if (x == null) return 1;
            if (y == null) return -1;
            if (x == null && y == null) return 0;
            return x.NumPages.CompareTo(y.NumPages);
        }
    }
}
