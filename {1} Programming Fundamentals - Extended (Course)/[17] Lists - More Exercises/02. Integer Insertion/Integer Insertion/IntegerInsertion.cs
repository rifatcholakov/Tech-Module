using System;
using System.Collections.Generic;
using System.Linq;

namespace Integer_Insertion
{
    public class IntegerInsertion
    {
        public static void Main()
        {
            List<int> list = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            List<int> secondList = new List<int>();

            for (int i = 0; true; i++)
            {
                string input = Console.ReadLine();

                if (input.Equals("end"))
                {
                    break;
                }

                secondList.Add(int.Parse(input));
            }

            Position(secondList, list);

            Console.WriteLine(string.Join(" ", list));

        }
        public static void Position(List<int> input, List<int> list)
       {
            int residue = 0;

            for (int i = 0; i < input.Count; i++)
            {
                int item = input[i];

                while (input[i] > 10)
                {
                    input[i] /= 10;
                }

               residue = input[i] % 10;

                list.Insert(residue, item);
            }

        }
    }
}
