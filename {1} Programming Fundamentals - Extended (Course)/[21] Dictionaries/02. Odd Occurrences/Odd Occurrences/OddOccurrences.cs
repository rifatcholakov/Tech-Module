using System;
using System.Collections.Generic;
using System.Linq;

namespace Odd_Occurrences
{
    public class OddOccurrences
    {
        public static void Main()
        {
            List<string> words = Console.ReadLine()
                .ToLower()
                .Split(' ')
                .ToList();

            Dictionary<string, int> result = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if (!result.ContainsKey(word))
                {
                    result[word] = 0;
                }

                result[word]++;
            }

            List<string> oddNumber = new List<string>();

            foreach (var item in result)
            {
                int value = item.Value;

                if(value % 2 != 0)
                {
                    oddNumber.Add(item.Key);
                }
            }

            Console.WriteLine(string.Join(", ", oddNumber));
        }
    }
}
