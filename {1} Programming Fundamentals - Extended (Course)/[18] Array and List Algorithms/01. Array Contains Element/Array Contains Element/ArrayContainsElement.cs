using System;
using System.Collections.Generic;
using System.Linq;

namespace Array_Contains_Element
{
    public class ArrayContainsElement
    {
        public static void Main()
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            int n = int.Parse(Console.ReadLine());

            bool doNotContain = false;

            for (int i = 0; i < numbers.Count - 1; i++)
            {
                if(numbers[i] == n)
                {
                    Console.WriteLine("yes");

                    doNotContain = false;

                    break;
                }
                else
                {
                    doNotContain = true;
                }
            }

            if (doNotContain)
            {
                Console.WriteLine("no");
            }

        }
    }
}
