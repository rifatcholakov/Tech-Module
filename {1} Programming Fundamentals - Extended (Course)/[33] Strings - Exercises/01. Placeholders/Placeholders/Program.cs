using System;

namespace Placeholders
{
    public class Program
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            while(input != "end")
            {
                string[] inputParts = input.Split("->".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                string sentence = inputParts[0];
                string placeholderWords = inputParts[1];

                string[] placeholderWordsParts = placeholderWords.Split(" ,".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < placeholderWordsParts.Length; i++)
                {
                    string currentPlaceholder = "{" + i + "}";

                    sentence = sentence.Replace(currentPlaceholder, placeholderWordsParts[i]);
                }

                Console.WriteLine(sentence);

                input = Console.ReadLine();
            }
        }
    }
}
