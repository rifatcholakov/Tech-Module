using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Fish_Statistics
{
    public class FishStatistics
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            Regex regex = new Regex(@"(>*)(?:<+)(\(+)('|-|x)>");

            MatchCollection matches = regex.Matches(input);

            if (matches.Count == 0)
            {
                Console.WriteLine("No fish found.");
                return;
            } 

            int count = 1;

            foreach (Match match in matches)
            {
                Console.Write($"Fish {count}: ");
                Console.WriteLine(match);
                TailsTypes(match);
                BodyTypes(match);
                Statuses(match);

                count++;
            }
        }

        private static void TailsTypes(Match match)
        {
            int charCount = match.ToString().Count(x => x == '>');
            int tailLength = (charCount - 1) * 2;

            Console.Write("  Tail type: ");

            if (tailLength / 2 > 5)
            {
                Console.Write("Long");
            }
            else if (tailLength / 2 > 1 && tailLength / 2 <= 5)
            {
                Console.Write("Medium");
            }
            else if (tailLength / 2 == 1)
            {
                Console.Write("Short");
            }
            else if (tailLength < 1)
            {
                Console.WriteLine("None");
            }

            if(tailLength != 0)
            {
                Console.WriteLine(" (" + tailLength + " cm)");
            }
        }

        private static void BodyTypes(Match match)
        {
            int charCount = match.ToString().Count(x => x == '(');
            int bodyLength = charCount * 2;

            Console.Write("  Body type: ");

            if (match.Groups[2].Length > 10)
            {
                Console.Write("Long");
            }
            else if (match.Groups[2].Length > 5 && match.Groups[2].Length <= 10)
            {
                Console.Write("Medium");
            }
            else if (match.Groups[2].Length <= 5)
            {
                Console.Write("Short");
            }

            Console.WriteLine(" (" + bodyLength + " cm)");
        }

        private static void Statuses(Match match)
        {
            string status = match.Groups[3].Value;

            switch (status)
            {
                case "'":
                    Console.WriteLine("  Status: Awake");
                    break;

                case "-":
                    Console.WriteLine("  Status: Asleep"); 
                    break;

                case "x":
                    Console.WriteLine("  Status: Dead");
                    break;
            }
        }
    }
}
