using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Word_Encounter
{
    public class WordEncounter
    {
        public static void Main()
        {
            string filter = Console.ReadLine();
            string line = Console.ReadLine();
            List<string> result = new List<string>();

            while (line != "end")
            {
                bool isMatch = Regex.IsMatch(line, @"(?<!.)[A-Z](.*)[.!?](?!.)");

                if (isMatch)
                {
                    MatchCollection words = Regex.Matches(line, @"(\w+)");

                    foreach (Match word in words)
                    {
                        char letter = filter[0];
                        int minLenght = int.Parse(filter[1].ToString());
                        string currentWord = word.Groups[0].Value;
                        int counter = 0;
                        for (int i = 0; i < currentWord.Length; i++)
                        {
                            if (currentWord[i] == letter)
                            {
                                counter++;
                            }
                        }

                        if (counter >= minLenght)
                        {
                            result.Add(currentWord);
                        }

                        counter = 0;
                    }
                }

                line = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", result));
        }
    }
}
