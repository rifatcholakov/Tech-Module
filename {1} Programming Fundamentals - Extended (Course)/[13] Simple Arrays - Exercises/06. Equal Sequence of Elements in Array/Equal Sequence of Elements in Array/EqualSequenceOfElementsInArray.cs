using System;
using System.Linq;

namespace Equal_Sequence_of_Elements_in_Array
{
    public class EqualSequenceOfElementsInArray
    {
        public static void Main()
        {
            int[] input = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int currentNumber = 0;

            string answer = string.Empty;

            for (int i = 0; i < input.Length; i++)
            {
                if (i == 0)
                {
                    currentNumber = input[i + 1];
                }
                if (input[i] == currentNumber)
                {
                    answer = "Yes";
                } else
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
