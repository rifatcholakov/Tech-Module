using System;
using System.Collections.Generic;
using System.Linq;

namespace Split_by_Word_Casing
{
    public class SplitByWordCasing
    {
        public static void Main()
        {
            List <string> words = Console.ReadLine()
                .Split(new char[] { ',', ';', ':', '.', '!', '(', ')', '"', '\'', '\\', '/', '[', ']', ' ' },
                StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            List<string> lowerCaseWords = new List<string>();

            List<string> upperCaseWords = new List<string>();

            List<string> mixedCaseWords = new List<string>();


            for (int i = 0; i < words.Count; i++)
            {


                bool result = words[i].All(Char.IsLetter);

                if (result && words[i].ToLower().Equals(words[i]))
                {
                    lowerCaseWords.Add(words[i]);

                } else if(result && words[i].ToUpper().Equals(words[i]))
                {
                    upperCaseWords.Add(words[i]);

                } else
                {

                    mixedCaseWords.Add(words[i]);

                }
            }

            Console.Write("Lower-case: ");
            Console.Write(String.Join(", ", lowerCaseWords));

            Console.WriteLine();
            Console.Write("Mixed-case: ");
            Console.Write(String.Join(", ", mixedCaseWords));

            Console.WriteLine();
            Console.Write("Upper-case: ");
            Console.Write(String.Join(", ", upperCaseWords));
            
        }
    }
}
