using System;
using System.Collections.Generic;
using System.Linq;

namespace Largest_N_Elements
{
    public class LargestNElements
    {
        public static void Main()
        {
            List<int> list = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            int n = int.Parse(Console.ReadLine());

            list.Sort();

            for (int i = list.Count - 1; n > 0; i--)
            {
                Console.Write(list[i] + " ");
                n--;
            }
        }
    }
}
