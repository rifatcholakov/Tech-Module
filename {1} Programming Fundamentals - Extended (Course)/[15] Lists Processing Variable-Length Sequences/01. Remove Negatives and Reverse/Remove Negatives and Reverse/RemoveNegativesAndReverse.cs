using System;
using System.Collections.Generic;
using System.Linq;

namespace Remove_Negatives_and_Reverse
{
    public class RemoveNegativesAndReverse
    {
        public static void Main()
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList(); 

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] < 0)
                {
                    numbers.Remove(numbers[i]);

                    i--;
                }

            }

            if (numbers.Count == 0)
            {
                Console.WriteLine("empty");
                return;
            }

            numbers.Reverse();

            foreach (var number in numbers)
            {
                Console.Write(number + " ");
            }

        }
    }
}
