using System;
using System.Text.RegularExpressions;

namespace MatchPhoneNumber
{
    public class MatchPhoneNumber
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            string pattern = @"\+359 \d{1} \d{3} \d{4}";

            Regex regex = new Regex(pattern);

            Match match = regex.Match(input);

            Console.WriteLine(match);
        }
    }
}
