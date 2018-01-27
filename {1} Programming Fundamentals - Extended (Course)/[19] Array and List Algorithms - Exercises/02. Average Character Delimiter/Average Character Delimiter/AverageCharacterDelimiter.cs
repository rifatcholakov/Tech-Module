using System;
using System.Linq;

namespace Average_Character_Delimiter
{
    public class AverageCharacterDelimiter
    {
        public static void Main()
        {
            string[] input = Console.ReadLine()
                .Split(' ')
                .ToArray();

            int sum = 0;
            int charCount = 0;

            CharactersSum(input, ref sum, ref charCount);

            int delimeter = sum / charCount;

            char charDelimeter = Char.ToUpper((char)delimeter);

            Output(input, charDelimeter);

        }

        public static void CharactersSum(string[] input, ref int sum, ref int charCount)
        {
            for (int i = 0; i < input.Length; i++)
            {
                char[] characters = input[i].ToCharArray();

                for (int j = 0; j < characters.Length; j++)
                {
                    sum += characters[j];

                    charCount++;
                }
            }
        }

        public static void Output(string[] input, char charDelimeter)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (i != input.Length - 1)
                {
                    Console.Write(input[i] + charDelimeter);
                }
                else
                {
                    Console.Write(input[i]);
                }
            }
        }
    }
}
