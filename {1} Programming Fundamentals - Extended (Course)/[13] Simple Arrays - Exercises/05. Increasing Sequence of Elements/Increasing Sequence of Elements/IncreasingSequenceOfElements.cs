using System;
using System.Linq;

namespace Increasing_Sequence_of_Elements
{
    public class IncreasingSequenceOfElements
    {
        public static void Main()
        {
            int[] input = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int currentNumber = int.MinValue;

            string answer = string.Empty;

            for (int i = 0; i < input.Length; i++)
            {

                if (input[i] > currentNumber)
                {
                    answer = "Yes";
                }
                else
                {
                    answer = "No";
                    break;
                }

                currentNumber = input[i];
            }

            Console.WriteLine(answer);
        }
    }
}

