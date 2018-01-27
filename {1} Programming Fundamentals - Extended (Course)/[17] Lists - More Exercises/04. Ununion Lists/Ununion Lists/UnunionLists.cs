using System;
using System.Collections.Generic;
using System.Linq;

namespace Ununion_Lists
{
    public class UnunionLists
    {
        public static void Main()
        {
            List<int> primalList = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                List<int> list = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToList();

                for (int j = 0; j < list.Count; j++)
                {
                    if (primalList.Contains(list[j]))
                    {
                        primalList.RemoveAll(k => list[j] == k);
                    } else
                    {
                        primalList.Add(list[j]);
                    }
                }

            }

            primalList.Sort();

            Console.WriteLine(string.Join(" ", primalList));
        }
    }
}
