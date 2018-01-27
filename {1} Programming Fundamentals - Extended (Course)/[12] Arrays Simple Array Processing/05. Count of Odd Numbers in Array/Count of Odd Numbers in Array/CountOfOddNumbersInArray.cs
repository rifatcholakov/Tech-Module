using System;
using System.Linq;

namespace Count_of_Odd_Numbers_in_Array
{
    public class CountOfOddNumbersInArray
    {
        public static void Main()
        {
            int[] input = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int odd = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] % 2 != 0)
                {
                    odd++;
                }
            }

            Console.WriteLine(odd);
        }
    }
}
