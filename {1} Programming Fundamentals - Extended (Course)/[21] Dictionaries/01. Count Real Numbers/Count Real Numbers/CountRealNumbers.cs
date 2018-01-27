using System;
using System.Collections.Generic;
using System.Linq;

namespace Count_Real_Numbers
{
    public class CountRealNumbers
    {
        public static void Main()
        {
            List<double> numbers = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToList();

            SortedDictionary<double, int> result = new SortedDictionary<double, int>();

            foreach (var number in numbers)
            {
                if (!result.ContainsKey(number))
                {
                    result[number] = 0;
                }

                result[number]++;
            }

            foreach (var number in result)
            {
                Console.WriteLine(number.Key + " -> " + number.Value);
            }
        }
    }
}
