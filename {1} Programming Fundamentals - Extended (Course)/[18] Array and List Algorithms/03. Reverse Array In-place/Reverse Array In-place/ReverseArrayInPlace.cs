using System;
using System.Collections.Generic;
using System.Linq;

namespace Reverse_Array_In_place
{
    public class ReverseArrayInPplace
    {
        public static void Main()
        {
            List<int> list = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            for (int i = 0; i < list.Count / 2; i++)
            {
                var leftIndex = i;
                var rightIndex = list.Count - 1 - i;

                var temp = list[leftIndex];
                list[leftIndex] = list[rightIndex];
                list[rightIndex] = temp;
            }

            foreach (var number in list)
            {
                Console.Write(number + " ");
            }
        }
    }
}
