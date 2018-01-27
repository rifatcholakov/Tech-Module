using System;
using System.Collections.Generic;
using System.Linq;

namespace Serialize_String
{
    public class SerializeString
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            char[] characters = input.ToCharArray();

            List<char> uniqueCharacters = characters.ToList().Distinct().ToList();

            List<int> indexes = new List<int>();

            for (int i = 0; i < uniqueCharacters.Count; i++)
            {
                Console.Write($"{uniqueCharacters[i]}:");

                for (int j = 0; j < characters.Length; j++)
                {
                    if(uniqueCharacters[i] == characters[j])
                    {
                        indexes.Add(j);
                    }
                }

                Console.WriteLine(string.Join("/", indexes));

                indexes.Clear();
            }
            
            
        }
    }
}
