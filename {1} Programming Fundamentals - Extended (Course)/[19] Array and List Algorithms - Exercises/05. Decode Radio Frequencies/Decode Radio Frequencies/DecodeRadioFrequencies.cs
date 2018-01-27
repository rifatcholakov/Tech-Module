using System;
using System.Collections.Generic;
using System.Linq;

namespace Decode_Radio_Frequencies
{
    public class DecodeRadioFrequencies
    {
        public static void Main()
        {
            string[] input = Console.ReadLine()
                .Split(' ')
                .ToArray();

            List<char> result = new List<char>();

            for (int i = 0; i < input.Length; i++)
            {
                LeftPart(input, result, i);

                RightPart(input, result, i);

            }

            Console.WriteLine(string.Join("", result));
        }

        public static void RightPart(string[] input, List<char> result, int i)
        {
            string[] rightPath = input[i].Split('.').ToArray();

            if (rightPath[1] != "0")
            {
                char rightPathChar = (char)(int.Parse(rightPath[1]));

                result.Insert(result.Count - i, rightPathChar);
            }
        }

        public static void LeftPart(string[] input, List<char> result, int i)
        {
            int leftPartNum = ((int)(double.Parse(input[i])));

            if (leftPartNum != 0)
            {
                char leftPartChar = (char)leftPartNum;

                result.Insert(i, leftPartChar);
            }
        }
    }
}
