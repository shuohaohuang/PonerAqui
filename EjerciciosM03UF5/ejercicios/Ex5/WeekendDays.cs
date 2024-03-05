using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.Ex5
{
    
    public class WeekendDays
    {
        static Dictionary<string, string> days = new Dictionary<string, string>()
        {
            {"Monday","Lunes"},
            {"Tuesday","Martes"},
            {"Wednesday","Miercoles"},
            {"Thursday","Jueves"},
            {"Friday","Viernes"},
            {"Saturday","Sabado"},
            {"Sunday","Domingo"},
        };

        public static string Day(DateTime time)
        {
            return days[time.DayOfWeek.ToString()];
        }
    }
}
