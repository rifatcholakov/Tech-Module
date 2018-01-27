using System;
using System.Collections.Generic;
using System.Linq;

namespace Randomize_Words
{
    public class RandomizeWords
    {
        public static void Main()
        {
            List<string> words = Console.ReadLine()
                .Split(' ')
                .ToList();

            Random random = new Random();

            for (int i = 0; i < words.Count; i++)
            {
                int randomPosition = random.Next(0, words.Count);

                string temp = words[i];

                words[i] = words[randomPosition];

                words[randomPosition] = temp;
            }

            Console.WriteLine(string.Join("\r\n", words));
        }
    }
}
