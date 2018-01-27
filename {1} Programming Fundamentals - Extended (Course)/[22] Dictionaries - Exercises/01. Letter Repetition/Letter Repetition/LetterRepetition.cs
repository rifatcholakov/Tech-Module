using System;
using System.Collections.Generic;
using System.Linq;

namespace Letter_Repetition
{
    public class LetterRepetition
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            Dictionary<char, int> result = new Dictionary<char, int>();

            foreach (var letter in input)
            {
                if (!result.ContainsKey(letter))
                {
                    result.Add(letter, 0);
                }

                result[letter]++;
            }

            foreach (var character in result)
            {
                Console.WriteLine(character.Key + " -> " + character.Value);
            }
        }
    }
}
