﻿using System.Text.RegularExpressions;
using System.Threading.Channels;
using Ejercicios.Ex1;
using Ejercicios.Ex14;
using Ejercicios.Ex17;
using Ejercicios.Ex2;
using Ejercicios.Ex3;
using Ejercicios.Ex5;
using Ejercicios.Ex25;
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
            Owner owner = new("sda", "241934", 4135245);
            Pacient pacient = new("fdadsfad", "persian", 23.43f, 2);
            Visit visit = new(owner, pacient, "fafa");

            Console.WriteLine(visit.ToString());
            int a = 3;
            DateTime today = new DateTime(2020, 3, 1);
            Date.PersonalizedData A = Date.UntilToday(today);
            Console.WriteLine(A);

            Console.WriteLine(WeekendDays.Day(today));
            Employee employee =
                new("pepe", "da", new DateTime(2004, 7, 7), "3224", new DateTime(2004, 7, 7));
            Employee employee2 =
                new("p", "da", new DateTime(2004, 7, 7), "3224", new DateTime(200, 7, 7));
            Employee employee3 =
                new("pe", "da", new DateTime(2004, 7, 7), "3224", new DateTime(204, 7, 7));
            Employee employee4 =
                new("pep", "da", new DateTime(2004, 7, 7), "3224", new DateTime(2764, 7, 7));
            Employee employee5 =
                new("pepa", "da", new DateTime(2004, 7, 7), "3224", new DateTime(4004, 7, 7));
            List<Employee> employees = new List<Employee>();
            employees.Add(employee);
            employees.Add(employee2);
            employees.Add(employee3);
            employees.Add(employee4);
            employees.Add(employee5);
            employees.Sort();
            Console.WriteLine(employee5.Age());

            foreach (var employe in employees)
                Console.WriteLine(employe);

            List<int> numbers = new List<int>();
            for (int i = 0; i < 9; i++)
                numbers.Add(i);
            Console.WriteLine(numbers.Sum());

            numbers.FindAll(x => x % 2 == 0).ForEach(x => Console.WriteLine(x));
            string[] array = { "a", "b", "c", "d" };

            List<string> strings = array.ToList<string>();
            foreach (var s in strings)
                Console.WriteLine(s);

            Dictionary<string, float> empl = new Dictionary<string, float>();
            empl.Add(employee.FullName(), employee.MonthSalary);
            empl.Add(employee2.FullName(), employee2.MonthSalary);
            empl.Add(employee3.FullName(), employee3.MonthSalary);
            empl.Add(employee4.FullName(), employee4.MonthSalary);
            empl.Add(employee5.FullName(), employee5.MonthSalary);

            numbers.FindAll(x => x > 5).ForEach(x => numbers.Remove(x));
            foreach (var num in numbers)
                Console.WriteLine(num);

            Console.WriteLine(RegexMatch.MatchLetterNums("das#a"));
            Console.WriteLine(RegexMatch.MatchLetterNums("DAS"));
            Console.WriteLine(RegexMatch.MatchLetterNums("12"));
            Console.WriteLine();
            Console.WriteLine(RegexMatch.MatchSequence("1a0"));
            Console.WriteLine(RegexMatch.MatchSequence("1ab"));
            Console.WriteLine(RegexMatch.MatchSequence("a.c"));
            Console.WriteLine();
            Console.WriteLine(RegexMatch.MatchSequenceSecond("1a0"));
            Console.WriteLine(RegexMatch.MatchSequenceSecond("1abb"));
            Console.WriteLine(RegexMatch.MatchSequenceSecond("a.c"));
            Console.WriteLine();
            Console.WriteLine(RegexMatch.MatchSequenceThird("1a_0"));
            Console.WriteLine(RegexMatch.MatchSequenceThird("1a_bb"));
            Console.WriteLine(RegexMatch.MatchSequenceThird("a_c"));

            Console.WriteLine(RegexMatch.MatchEmail("adasaaaa@asd.cfom"));

            BirdWatcher.LastWeek();
            BirdWatcher.Today();
            BirdWatcher.IncrementTodaysCount();
            BirdWatcher.Today();

            int[] birdsPerDay = { 2, 5, 0, 7, 4, 1 };
            var birdCount = new BirdWatcher(birdsPerDay);
            Console.WriteLine(birdCount.HasDayWithoutBirds());
            Console.WriteLine(birdCount.CountForFirstDays(4));
            Console.WriteLine(birdCount.BusyDays());

            List<int> birds = new List<int> { 2, 5, 0, 7, 4, 1 };

            birds.Sort((x, y) => y.CompareTo(x));
            foreach (var bird in birds)
                Console.WriteLine(bird);

            Power power = (x, y) => Math.Pow(x, y);
            int[] pow = [2, 3];
            Console.WriteLine(power(pow[0], pow[1]));

            int[] ints = { 1, 2, 3, 4, 5, };
            Console.WriteLine(ints.Average());

            EvenOdd nums = x => x % 2 == 0 ? $"{x * 2}" : $"{x} es impar";
            Console.WriteLine(nums(2));

            Fibonacci fibonacci = null;
            fibonacci = x => x <= 1 ? x : fibonacci(x - 1) + fibonacci(x - 2);
            Console.WriteLine(fibonacci(2));

            IsNatural isNatural= x => x%1==0 && x>=0;
            Console.WriteLine(isNatural(3));

            Console.WriteLine(Expression.Clean("m-y  \n Id u1😀2😀3😀 MyΟβιεγτFinder"));


        }
    }
}
