using System;
using System.Collections.Generic;
using System.Linq;

namespace Sort_Numbers
{
    public class SortNumbers
    {
        public static void Main()
        {
            List<decimal> list = Console.ReadLine()
                .Split(' ')
                .Select(decimal.Parse)
                .ToList();

            list.Sort();

            Console.WriteLine(string.Join(" <= ", list));
        }
    }
}
