using System;
using System.Linq;

namespace Count_of_Given_Element_in_Array
{
    public class CountOfGivenElementInArray
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int repeatedNumber = int.Parse(Console.ReadLine());

            int count = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == repeatedNumber)
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
