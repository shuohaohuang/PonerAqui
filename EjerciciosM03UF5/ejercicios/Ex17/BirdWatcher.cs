using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.Ex17
{
    public class BirdWatcher
    {
        private static List<int> LastWeekBirds = new List<int> { 0, 2, 5, 3, 7, 8, 4 };
        private static int[] BirdsPerDay = [2, 5, 1, 7, 4, 1];

        public BirdWatcher(int[] birds)
        {
            BirdsPerDay = birds;
        }

        public static void LastWeek()
        {
            StringBuilder lastWeek = new StringBuilder();
            lastWeek.Append('[');
            foreach (int i in LastWeekBirds)
                lastWeek.Append(i + ",");
            lastWeek.Length--;
            lastWeek.Append(']');
            Console.WriteLine(lastWeek);
        }

        public static void SetLastWeek(List<int> birds)
        {
            BirdWatcher.LastWeekBirds = birds;
        }

        public static void Today()
        {
            Console.WriteLine(BirdsPerDay[BirdsPerDay.Length - 1]);
        }

        public static void IncrementTodaysCount()
        {
            BirdsPerDay[BirdsPerDay.Length - 1] += 1;
        }

        public bool HasDayWithoutBirds()
        {
            foreach (int i in BirdsPerDay)
                if (i > 0)
                    return true;

            return false;
        }

        public int CountForFirstDays(int day)
        {
            int count = 0;
            if (BirdsPerDay.Length >= day)
            {
                for (int i = 0; i < day; i++)
                    count += BirdsPerDay[i];
                return count;
            }
            return count - 1;
        }
        public int BusyDays()
        {
            int busyDays = 0;
            foreach (var bird in BirdsPerDay)
                busyDays =bird>=5? busyDays+1: busyDays;
            return busyDays;
        }
    }
}
