using System;
using System.Collections.Generic;
using System.Linq;

namespace Smallest_Element_in_Array
{
    public class SmallestElementInArray
    {
        public static void Main()
        {
            List<int> list = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            int smallestNumber = int.MaxValue;

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] < smallestNumber)
                {
                    smallestNumber = list[i];
                }
            }

            Console.WriteLine(smallestNumber);
        }
    }
}
