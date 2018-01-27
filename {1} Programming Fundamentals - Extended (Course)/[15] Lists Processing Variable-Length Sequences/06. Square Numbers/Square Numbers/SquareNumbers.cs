using System;
using System.Collections.Generic;
using System.Linq;

namespace Square_Numbers
{
    public class SquareNumbers
    {
        public static void Main()
        {
            List<int> list = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            List<int> result = new List<int>();

            list.Sort();

            for (int i = 0; i < list.Count; i++)
            {
                if(Math.Sqrt(list[i]) == (int)Math.Sqrt(list[i]))
                {
                    result.Add(list[i]);
                }
            }

            result.Reverse();

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
