using System;
using System.Text.RegularExpressions;

namespace _01.Melrah_Shake
{
    public class MelrahShake
    {
        public static void Main()
        {
            string inputString = Console.ReadLine();
            string inputPattern = Console.ReadLine();

            Regex regex = new Regex(Regex.Escape(inputPattern));

            MatchCollection matches = regex.Matches(inputString);

            while (true)
            {
                if (matches.Count >= 2 && inputPattern.Length > 0)
                {
                    int startIndex = inputString.IndexOf(inputPattern);
                    int lastIndex = inputString.LastIndexOf(inputPattern);

                    inputString = inputString.Remove(lastIndex, inputPattern.Length);
                    inputString = inputString.Remove(startIndex, inputPattern.Length);

                    inputPattern = inputPattern.Remove(inputPattern.Length / 2, 1);

                    Console.WriteLine("Shaked it.");
                }
                else
                {
                    Console.WriteLine("No shake.");
                    break;
                }

                regex = new Regex(Regex.Escape(inputPattern));
                matches = regex.Matches(inputString);
            }

            Console.WriteLine(inputString);
        }
    }
}
