using System;
using System.Collections.Generic;
using System.Linq;

namespace Min__Max__Sum__Average
{
    public class MinMaxSumAverage
    {
        public static void Main()
        {
            List<int> nums = new List<int>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                nums.Add(num);
            }

            int sum = nums.Sum();

            int min = nums.Min();

            int max = nums.Max();

            double average = nums.Average();

            Console.WriteLine("Sum = " + sum);
            Console.WriteLine("Min = " + min);
            Console.WriteLine("Max = " + max);
            Console.WriteLine("Average = " + average);
        }
    }
}
