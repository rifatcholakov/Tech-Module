using System;
using System.Linq;

namespace Array_Symmetry
{
    public class ArraySymmetry
    {
        public static void Main()
        {
            string[] input = Console.ReadLine()
                .Split(' ');

            int lastIndex = 1;

            string answer = string.Empty;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i].Equals(input[input.Length - lastIndex]))
                {
                    answer = "Yes";
                } else
                {
                    answer = "No";
                    break;
                }

                lastIndex++;
            }

            Console.WriteLine(answer);
        }
    }
}
