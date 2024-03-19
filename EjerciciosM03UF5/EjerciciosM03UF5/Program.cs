using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Channels;
using Ejercicios.Ex1;
using Ejercicios.Ex14;
using Ejercicios.Ex17;
using Ejercicios.Ex2;
using Ejercicios.Ex25;
using Ejercicios.Ex3;
using Ejercicios.Ex5;
using Ejercicios.Ex6;

namespace EjerciciosM03Uf5
{
    public class M03UF5
    {
        public delegate double Power(int numA, int numB);
        public delegate string EvenOdd(int num);
        public delegate int Fibonacci(int num);
        public delegate bool IsNatural(int num);

        public static void Main()
        {
            List<int> list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var even = from num in list where num % 2 == 0 select num;
            even.ToList().ForEach(x => Console.WriteLine(x));

            List<int> secondList = new List<int> { -1, 2, 3, -4, -5, 6, -7, 8, -9, 10 };
            var positive = from num in secondList where num >= 0 select num;
            positive.ToList().ForEach(x => Console.WriteLine());

            List<int> nums = new List<int>();
            for (int i = 0; i < 20; i++)
                nums.Add(new Random().Next(0, 5));

            var greater20 = from num in list where num > 20 select num;
            greater20.ToList().ForEach(x => Console.WriteLine($"{x}:{Math.Pow(x, 2)}"));

            // IEnumerable<IGrouping<int, int>> frequency =
            //     from num in list
            //     where num >= 0
            //     group num by num;
            // foreach (int group in list)
            // {
            //     Console.WriteLine(gr);
            // }

            List<int> numbers = [35, 44, 20, 84, 3987, 20, 199, 329, 446, 208];

            int search = 20;
            var frequenci = from num in numbers where num == search select num;

            int Count = frequenci.Count();
            Console.WriteLine(
                "{0} occurrences(s) of the search term \"{1}\" were found.",
                Count,
                search
            );
            string text =
                @"Historically, the world of data and the world of objects"
                + @" have not been well integrated. Programmers work in C# or Visual Basic"
                + @" and also in SQL or XQuery. On the one side are concepts such as classes,"
                + @" objects, fields, inheritance, and .NET APIs. On the other side"
                + @" are tables, columns, rows, nodes, and separate languages for dealing with"
                + @" them. Data types often require translation between the two worlds; there are"
                + @" different standard functions. Because the object world has no notion of query, a"
                + @" query can only be represented as a string without compile-time type checking or"
                + @" IntelliSense support in the IDE. Transferring data from SQL tables or XML trees to"
                + @" objects in memory is often tedious and error-prone.";

            List<char> chars = new List<char>();
            List<int> frequncyChars = new List<int>();
            foreach (var letter in text.ToLower())
            {
                if (!chars.Contains(letter))
                {
                    chars.Add(letter);
                    var frequency =
                        from letters in text.ToLower()
                        where letters == letter
                        select letters;
                    Console.WriteLine($"{letter}: {frequency.Count()}");
                }
            }
            List<int> days = new List<int> { 1, 2, 3, 4, 5, 6, 0 };

            var daysOfWeek = from day in days select (DayOfWeek)(day);
            foreach (var day in daysOfWeek)
            {
                string a = day.ToString();
                Console.WriteLine(a);
            }

            List<int> ints = new List<int>();
            List<int> numArray = new List<int>();
            foreach (var num in nums)
            {
                if (!ints.Contains(num))
                {
                    ints.Add(num);
                    var frequency = from i in nums where i == num select i;
                    numArray.Add(num);
                    numArray.Add(frequency.Count());
                    numArray.Add(num * frequency.Count());
                    Console.WriteLine($"{num}:fr {frequency.Count()}, {num * frequency.Count()}");
                }
            }

            List<string> cities = new List<string>
            {
                "ROMA",
                "LONDRES",
                "NAIROBI",
                "CALIFÒRNIA",
                "ZURICH",
                "NOVA DELHI",
                "AMSTERDAM",
                "ABU DHABI",
                "PARÍS"
            };
            char Letter = 'A';
            char letterB = 'M';
            var matchCity= from city in cities
                           where city[0]==Letter && city[city.Length-1]==letterB
                           select city;
            string[] citi = matchCity.ToArray();
            foreach (var city in citi)
            { Console.WriteLine(city); }
        }
    }
}
