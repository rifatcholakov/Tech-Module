using System;
using System.Collections.Generic;
using System.Linq;

namespace Flip_List_Sides
{
    public class FlipListSides
    {
        public static void Main()
        {
            List<int> list = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            for (int i = 0; i < list.Count / 2; i++)
            {

                if(list[i] == list[0] || list[i] == list[list.Count - 1])
                {
                    continue;
                } else
                {
                    var temp = list[i];
                    list[i] = list[list.Count - 1 - i];
                    list[list.Count - 1 - i] = temp;
                }

            }

            Console.WriteLine(string.Join(" ", list));
        }
    }
}
