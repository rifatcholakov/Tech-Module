using System;
using System.Collections.Generic;
using System.Linq;

namespace Distinct_List
{
    public class DistinctList
    {
        public static void Main()
        {
            List<int> list = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

           List<int> unique = list.Distinct().ToList();

            Console.WriteLine(string.Join(" ", unique));

        }
    }
}
