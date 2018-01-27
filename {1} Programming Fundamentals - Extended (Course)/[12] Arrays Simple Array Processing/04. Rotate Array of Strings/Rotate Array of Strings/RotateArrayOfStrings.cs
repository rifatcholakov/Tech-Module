using System;
using System.Linq;

namespace Rotate_Array_of_Strings
{
    public class RotateArrayOfStrings
    {
        public static void Main()
        {
            string[] input = Console.ReadLine()
                .Split(' ')
                .ToArray();

            string result = string.Empty;

            string last = input[input.Length - 1];

            for (int i = 0; i < input.Length-1; i++)
            {
                result  += input[i] + " ";
            }

            Console.WriteLine(last + " "  + result);
        }
    }
}
