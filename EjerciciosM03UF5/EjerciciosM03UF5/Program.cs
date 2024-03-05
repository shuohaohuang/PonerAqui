using Ejercicios.Ex2;
using Ejercicios.Ex3;
using Ejercicios.Ex1;
using Ejercicios.Ex5;
using Ejercicios.Ex6;

namespace EjerciciosM03Uf5
{
    public class M03UF5
    {
        public static void Main()
        {
            Owner owner = new("sda", "241934", 4135245);
            Pacient pacient = new("fdadsfad", "persian", 23.43f, 2);
            Visit visit = new(owner, pacient, "fafa");

            Console.WriteLine(visit.ToString());
            int a = 3;
            DateTime today = new DateTime(2, 2, 1);
            Date.PersonalizedData A = Date.UntilToday(today);
            Console.WriteLine(A.GetYear());

            Console.WriteLine(WeekendDays.Day(today));
            //Employee employee = new("pepe", "da", new DateTime(2024, 3, 5));
            //Console.WriteLine(employee.Age());

        }
    }
}