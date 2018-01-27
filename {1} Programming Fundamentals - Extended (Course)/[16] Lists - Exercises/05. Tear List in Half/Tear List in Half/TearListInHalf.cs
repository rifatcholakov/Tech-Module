using System;
using System.Collections.Generic;
using System.Linq;

namespace Tear_List_in_Half
{
    public class TearListInHalf
    {
        public static void Main()
        {
            List<int> list = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            List<int> rightPart = new List<int>();

            int length = (list.Count - 1) / 2;

            for (int i = list.Count - 1; i > length; i--)
            {
                rightPart.Add(list[i]);
                list.RemoveAt(i);
            }

            rightPart.Reverse();

            for (int i = 0, j = 0; j < rightPart.Count; i++, j++)
            {

                    int firstHalf = rightPart[j] % 10;
                    int secondHalf = (rightPart[j] / 10) % 10;

                list.Insert(i, secondHalf);

                list.Insert(i + 2, firstHalf);

                i += 2;
            }

            Console.WriteLine(string.Join(" ", list));
        }
    }
}
