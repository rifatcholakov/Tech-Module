using System;
using System.Linq;

namespace Array_Elements_Equal_to_Their_Index
{
    public class ArrayElementsEqualToTheirIndex
    {
        public static void Main()
        {
            int[] input = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < input.Length; i++)
            {
                if (i == input[i])
                {
                    Console.Write(i + " ");
                }
            }

        }
    }
}
