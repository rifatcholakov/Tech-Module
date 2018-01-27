using System;
using System.Linq;

namespace Sort_Array_Using_Insertion_Sort
{
    public class SortArrayUsingInsertionSort
    {
        public static void Main()
        {
            int[] arr = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < arr.Length - 1; i++)
            {
                var j = i + 1;

                while (j > 0)
                {

                    if (arr[j] < arr[j - 1])
                    {
                        var temp = arr[j];
                        arr[j] = arr[j - 1];
                        arr[j - 1] = temp;
                    }

                    j--;
                }

            }

            Console.WriteLine(String.Join(" ", arr));
        }
    }
}
