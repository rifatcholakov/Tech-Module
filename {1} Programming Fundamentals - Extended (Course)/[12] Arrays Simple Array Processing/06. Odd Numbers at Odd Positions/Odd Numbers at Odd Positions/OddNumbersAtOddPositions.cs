using System;
using System.Linq;

namespace Odd_Numbers_at_Odd_Positions
{
    public class OddNumbersAtOddPositions
    {
        public static void Main()
        {
            int[] input = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < input.Length; i++)
            {
                if (i % 2 != 0 && input[i] % 2 != 0)
                {
                    Console.WriteLine($"Index {i} -> {input[i]}");
                }

            }
        }
    }
}
