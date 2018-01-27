using System;
using System.Collections.Generic;
using System.Linq;

namespace Palindromes
{
    public class Palindromes
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split(" ,.?!".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            HashSet<string> result = new HashSet<string>();

            foreach (var word in input)
            { 

                if (new string(word.ToCharArray().Reverse().ToArray()).Equals(word))
                {
                    result.Add(word);
                }
            }

            Console.WriteLine(string.Join(", ", result.OrderBy(x => x)));
        }
    }
}
