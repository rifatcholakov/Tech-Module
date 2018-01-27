using System;
using System.Collections.Generic;
using System.Linq;

namespace Fold_and_Sum
{
    public class FoldAndSum
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int k = numbers.Length / 4;

            List<int> firstPartUpperRow = numbers
                .Take(k)
                .Reverse()
                .ToList();

            List<int> secondPartUpperRow = numbers
                .Reverse()
                .Take(k)
                .ToList();

            int[] upperRow = firstPartUpperRow
                .Concat(secondPartUpperRow)
                .ToArray();

            int[] lowerRow = numbers
                .Skip(k)
                .Take(2 * k)
                .ToArray();

            int[] result = new int[upperRow.Length];

            for (int i = 0; i < upperRow.Length; i++)
            {
                result[i] = upperRow[i] + lowerRow[i];
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
