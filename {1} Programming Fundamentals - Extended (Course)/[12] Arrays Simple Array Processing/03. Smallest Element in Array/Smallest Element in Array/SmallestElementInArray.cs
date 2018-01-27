using System;
using System.Linq;

namespace Smallest_Element_in_Array
{
    public class SmallestElementInArray
    {
        public static void Main()
        {
            var input = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();

            int minValue = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (i == 0)
                {
                    minValue = Math.Min(input[i], int.MaxValue);
                }
                else
                {
                    minValue = Math.Min(input[i], minValue);
                }
            }
            Console.WriteLine(minValue);
        }
    }
}
