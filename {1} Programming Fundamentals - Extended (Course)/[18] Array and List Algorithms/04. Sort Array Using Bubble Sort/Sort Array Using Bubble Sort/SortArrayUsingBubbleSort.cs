using System;
using System.Collections.Generic;
using System.Linq;

namespace Sort_Array_Using_Bubble_Sort
{
    public class SortArrayUsingBubbleSort
    {
        public static void Main()
        {
            int[] arr = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            bool swaped = false;

            do
            {
                swaped = false;

                for (int i = 0; i < arr.Length - 1; i++)
                {
                    var current = arr[i];
                    var next = arr[i + 1];

                    if (current > next)
                    {
                        var temp = current;
                        arr[i] = next;
                        arr[i + 1] = current;
                        
                        swaped = true;
                    }
                }
            } while (swaped);

            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
