using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ejercicios.Ex14
{
    public class RegexMatch
    {
        private static readonly string patter = "^[a-z0-9]$";
        private static readonly string patterSecond = "ab*";
        private static readonly string patterThird = "ab{2,3}"; 
        private static readonly string patterFourth = "[a-z]_[a-z]";
        private static readonly string mailPattern = "...@...[.]...";
        static private Regex rg = new(patter, RegexOptions.IgnoreCase);
        static private Regex rgSecond = new(patterSecond, RegexOptions.IgnoreCase);
        static private Regex rgThird = new(patterThird, RegexOptions.IgnoreCase);
        static private Regex rgFourth = new(patterFourth);
        private static Regex rgMailPattern = new(mailPattern, RegexOptions.IgnoreCase);

        public static bool MatchLetterNums(string word)
        {
            return rg.IsMatch(word);
        }
        public static bool MatchSequence(string word)
        {
            return rgSecond.IsMatch(word);
        }
        public static bool MatchSequenceSecond(string word)
        {
            return rgThird.IsMatch(word);
        }
        public static bool MatchSequenceThird(string word)
        {
            return rgFourth.IsMatch(word);
        }
        public static bool MatchEmail(string mail)
        {
            return rgMailPattern.IsMatch(mail);
        }

    }
}
