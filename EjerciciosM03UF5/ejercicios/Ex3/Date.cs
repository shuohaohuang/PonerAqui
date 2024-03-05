using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.Ex3
{
    public class Date
    {
        public struct PersonalizedData(int year, int month, int day)
        {
            int Year = year,
                Month = month,
                Day = day;

            public int GetYear()
            {
                return Year;
            }

            public int GetMonth()
            {
                return Month;
            }

            public int GetDay()
            {
                return Day;
            }
        }

        public static PersonalizedData UntilToday(DateTime time)
        {
            if (time > DateTime.Now)
            {
                throw new Exception("fecha mayor a actual");
            }

            TimeSpan a = DateTime.Now - time;
            PersonalizedData personalizedData = new PersonalizedData(
                a.Days / 365,
                a.Days % 365 / 30,
                a.Days % 365 % 30
            );
            return personalizedData;
        }
    }
}
