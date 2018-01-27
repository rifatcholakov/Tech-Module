using System;
using System.Collections.Generic;
using System.Linq;

namespace Sort_Array_of_Strings
{
    public class SortArrayOfStrings
    {
        public static void Main()
        {
            List<string> input = Console.ReadLine()
                .Split(' ')
                .ToList();

            input.Sort();

            Console.WriteLine(string.Join(" ", input));

        }
    }
}
