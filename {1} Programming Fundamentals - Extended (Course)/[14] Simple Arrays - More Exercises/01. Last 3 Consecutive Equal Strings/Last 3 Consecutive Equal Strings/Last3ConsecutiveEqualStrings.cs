using System;

namespace Last_3_Consecutive_Equal_Strings
{
    public class Last3ConsecutiveEqualStrings
    {
        public static void Main()
        {
            string[] input = Console.ReadLine()
                .Split(' ');

            int index = input.Length;

            int firstDecreasing = 1;
            int secondDecreasing = 2;
            int thirdDecreasing = 3;

            for (int i = input.Length; i > 0; i--)
            {
                if (input[index - firstDecreasing].Equals(input[index - secondDecreasing]) && input[index - secondDecreasing].Equals(input[index - thirdDecreasing]))
                {
                    Console.WriteLine(input[index - firstDecreasing] + " " + input[index - secondDecreasing] + " " + input[index - thirdDecreasing]);
                    break;
                }
                else
                {
                    firstDecreasing++;
                    secondDecreasing++;
                    thirdDecreasing++;
                }
            }
        }
    }
}
