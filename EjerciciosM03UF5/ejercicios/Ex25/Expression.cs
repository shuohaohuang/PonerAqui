using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ejercicios.Ex25
{
    public class Expression
    {
        public static string Clean(string message)
        {
            message = Regex.Replace(message, "[^a-z]", "", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"[\u0000-\u001F][^a-o \p{IsGreekandCoptic}]", "CTRL");
            message = Regex.Replace(message, "-", "");

            return message.Replace(" ", "_");
            
        }
    }
}
