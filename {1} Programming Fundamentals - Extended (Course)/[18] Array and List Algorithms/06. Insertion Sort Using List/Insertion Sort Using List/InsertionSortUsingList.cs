using System;
using System.Collections.Generic;
using System.Linq;

namespace Insertion_Sort_Using_List
{
    public class InsertionSortUsingList
    {
        public static void Main()
        {
            List<int> list = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            for (int i = 0; i < list.Count - 1; i++)
            {
                var j = i + 1;

                while (j > 0)
                {

                    if (list[j] < list[j - 1])
                    {
                        var temp = list[j];
                        list[j] = list[j - 1];
                        list[j - 1] = temp;
                    }

                    j--;
                }

            }

            Console.WriteLine(String.Join(" ", list));
        }
    }
}
