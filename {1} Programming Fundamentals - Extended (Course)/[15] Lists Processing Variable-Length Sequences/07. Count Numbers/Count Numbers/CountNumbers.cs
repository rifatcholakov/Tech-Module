using System;
using System.Collections.Generic;
using System.Linq;

namespace Count_Numbers
{
    public class CountNumbers
    {
        public static void Main()
        {
            List<int> list = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            list.Sort();

            var dict = new Dictionary<int, int>();
            foreach (int d in list)
            {
                if (dict.ContainsKey(d))
                    dict[d]++;
                else
                    dict.Add(d, 1);
            }

            foreach (var number in dict)
            {
                Console.WriteLine(number.Key + " -> " + number.Value);
            }
        }
    }
}
