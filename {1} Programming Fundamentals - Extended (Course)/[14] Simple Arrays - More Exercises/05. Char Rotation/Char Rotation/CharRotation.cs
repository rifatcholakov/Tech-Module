using System;
using System.Linq;

namespace Char_Rotation
{
    public class CharRotation
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            char[] text = input.ToCharArray();


            int[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int result;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    result = Convert.ToChar(text[i]) - numbers[i];

                    text[i] = (Convert.ToChar(result));
                }
                else
                {
                    result = Convert.ToChar(text[i]) + numbers[i];

                    text[i] = (Convert.ToChar(result));
                }
            }

            Console.WriteLine(text);
        }
    }
}
