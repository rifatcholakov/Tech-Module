using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Nether_Realms
{

    public class NetherRealms
    {
        public static void Main()
        {
            string[] demonNames = Console.ReadLine()
                .Split(',')
                .Select(x => x.Trim())
                .ToArray();

            List<Deamon> book = new List<Deamon>();

            string heathPattern = @"([^0-9\+\-\*\/\.])";
            string damageDigitPattern = @"-?\d+\.?\d*";

            Regex healthRegex = new Regex(heathPattern);
            Regex damageDigitRegex = new Regex(damageDigitPattern);

            foreach (var deamonName in demonNames)
            {
                Deamon currentDeamon = new Deamon();
                currentDeamon.Name = deamonName;

                char[] nameCharacters = deamonName.ToCharArray();
                foreach (var character in nameCharacters)
                {
                    if (healthRegex.IsMatch(character.ToString()))
                    {
                        currentDeamon.Health += character;
                    }
                }

                MatchCollection damageDigitMatches = damageDigitRegex.Matches(deamonName);
                foreach (var digit in damageDigitMatches)
                {
                    currentDeamon.Damage += decimal.Parse(digit.ToString());
                }

                char[] modifiers = deamonName.Where(x => x == '*' || x == '/').ToArray();
                foreach (var modifier in modifiers)
                {
                    if (modifier == '*')
                    {
                        currentDeamon.Damage *= 2;
                    }
                    else if (modifier == '/')
                    {
                        currentDeamon.Damage /= 2;
                    }
                }

                book.Add(currentDeamon);
            }

            foreach (var deamon in book.OrderBy(deamon => deamon.Name))
            {
                Console.WriteLine($"{deamon.Name} - {deamon.Health} health, {deamon.Damage:F2} damage");
            }
        }
    }
}
