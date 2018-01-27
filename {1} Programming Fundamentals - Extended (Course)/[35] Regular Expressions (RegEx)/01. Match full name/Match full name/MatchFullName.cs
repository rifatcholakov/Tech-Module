using System;
using System.Text.RegularExpressions;

namespace Match_full_name
{
    public class MatchFullName
    {
        public static void Main()
        {
            string input = "Ivan Ivanov";

            string pattern = @"[A-Z]{0}[a-z]+ [A-Z]{0}[a-z]+";

            Regex regex = new Regex(pattern);

            Match match = regex.Match(input);

            Console.WriteLine(match);
        }
    }
}
