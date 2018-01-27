using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Cards
{
    public class Cards
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            Regex regex = new Regex("([1]?[0-9JQKA])([SHDC])");

            MatchCollection matchedCards = regex.Matches(input);

            List<string> validCards = new List<string>();

            foreach (Match card in matchedCards)
            {
                int power = 0;

                if (int.TryParse(card.Groups[1].Value, out power))
                {

                    if (power < 2 || power > 10)
                    {
                        continue;
                    }
                }

                validCards.Add(card.Value);
            }

            Console.WriteLine(string.Join(", ", validCards));
        }
    }
}
