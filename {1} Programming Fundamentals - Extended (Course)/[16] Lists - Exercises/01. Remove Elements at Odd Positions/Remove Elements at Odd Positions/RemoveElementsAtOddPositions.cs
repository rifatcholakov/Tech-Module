using System;
using System.Collections.Generic;
using System.Linq;

namespace Remove_Elements_at_Odd_Positions
{
    public class RemoveElementsAtOddPositions
    {
        public static void Main()
        {
            List<string> input = Console.ReadLine()
                .Split(' ')
                .ToList();

            int count = input.Count;

            bool even = true;

            for (int i = 0; i < input.Count; i++)
            {
                if (i % 2 == 0 && even == true)
                {
                    input.RemoveAt(i);
                } else
                {
                    input.RemoveAt(i);
                    even = false;
                }
               
            }

            Console.Write(string.Join("", input));
        }
    }
}
