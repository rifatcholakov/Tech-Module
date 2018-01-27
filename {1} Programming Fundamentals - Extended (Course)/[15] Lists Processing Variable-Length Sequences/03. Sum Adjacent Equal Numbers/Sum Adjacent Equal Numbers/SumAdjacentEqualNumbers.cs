using System;
using System.Collections.Generic;
using System.Linq;

namespace Sum_Adjacent_Equal_Numbers
{
    public class SumAdjacentEqualNumbers
    {

        public static void Main()
        {
            List<decimal> numbers = Console.ReadLine()
                .Split(' ')
                .Select(decimal.Parse)
                .ToList();

            decimal sum = 0;

            for (int j = 0; j < numbers.Count + 1; j++)
            {
                bool execute = true;


                for (int i = 0; i < numbers.Count - 1; i++)
                {

                    if (execute == true && numbers[i] == numbers[i + 1])
                    {
                        sum = numbers[i] + numbers[i + 1];

                        numbers.RemoveAt(i);
                        numbers.RemoveAt(i);
                        numbers.Insert(i, sum);

                        execute = false;
                    }

                }

            }

            foreach (var number in numbers)
            {
                Console.Write(number + " ");
            }
        }
    }
}
