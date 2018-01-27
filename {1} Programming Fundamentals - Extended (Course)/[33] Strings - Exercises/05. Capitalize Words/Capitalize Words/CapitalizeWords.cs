using System;
using System.Linq;

namespace Capitalize_Words
{
    public class CapitalizeWords
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            while(input != "end")
            {
                string[] words = input
                    .Split(" ,.:;[]{}\"\\()-=><~|`?!/*%$#@^&".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                    .Select(word => word.ToLower())
                    .ToArray();

                for (int i = 0; i < words.Length; i++)
                {
                    char[] wordParts = words[i].ToCharArray();

                    string theRestOfTheWord = new string(wordParts.Skip(1).ToArray());
                    string capitalLetter = wordParts[0].ToString().ToUpper();

                    words[i] = capitalLetter + theRestOfTheWord;
                }

                Console.WriteLine(string.Join(", ", words));

                input = Console.ReadLine();
            }
        }
    }
}
