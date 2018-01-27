using System;
using System.Text.RegularExpressions;

namespace Happiness_Index
{
    public class HappinessIndex
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            Regex happyPattern = new Regex(@"(\(:)|(\*:)|(c:)|(\[:)|(\[;)|([:;])([)D*\]}:])");
            Regex sadPattern = new Regex(@"(\];)|(\]:)|(\):)|([D][:])|([:;])([(\[{c])");

            int happyCount = happyPattern.Matches(input).Count;
            int sadCount = sadPattern.Matches(input).Count;

            double happinessIndex = happyCount / (double)sadCount;
            string emoticon = Emoticon(happinessIndex);

            Console.WriteLine($"Happiness index: {happinessIndex:F2} {emoticon}");
            Console.WriteLine($"[Happy count: {happyCount}, Sad count: {sadCount}]");
        }

        private static string Emoticon(double happinessIndex)
        {
            string emoticon = String.Empty;

            if (happinessIndex >= 2)
            {
                emoticon = ":D";
            }
            else if (happinessIndex > 1 && happinessIndex < 2)
            {
                emoticon = ":)";
            }
            else if (happinessIndex == 1)
            {
                emoticon = ":|";
            }
            else if (happinessIndex < 1)
            {
                emoticon = ":(";
            }

            return emoticon;
        }
    }
}
