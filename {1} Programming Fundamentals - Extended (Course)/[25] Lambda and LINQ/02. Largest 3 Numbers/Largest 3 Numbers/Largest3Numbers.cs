using System;
using System.Collections.Generic;
using System.Linq;

namespace Largest_3_Numbers
{
    public class Largest3Numbers
    {
        public static void Main()
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .OrderByDescending(x => x)
                .Take(3)
                .ToList();

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
