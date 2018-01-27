using System;
using System.Collections.Generic;
using System.Linq;

namespace Append_Lists
{
    public class AppendLists
    {
        public static void Main()
        {
            List<string> input = Console.ReadLine()
                .Split('|')
                .ToList();

            List<int> output = new List<int>();

            int counter = 0;

            foreach (var list in input)
            {
                list
                    .Split(' ')
                    .ToList();

                int length = list.Length;

                for (int i = 0; i < length; i++)
                {

                    if (list[i] >= 48 && list[i] <= 57)
                    {
                        output.Add(list[i]);
                        Console.Write(string.Join(" ", list[i] + " "));
                    }
                        
                }

                foreach (var item in output)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
