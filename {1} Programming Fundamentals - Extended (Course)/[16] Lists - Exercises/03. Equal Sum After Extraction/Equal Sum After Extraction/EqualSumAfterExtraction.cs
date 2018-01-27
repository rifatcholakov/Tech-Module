using System;
using System.Collections.Generic;
using System.Linq;

namespace Equal_Sum_After_Extraction
{
    public class EqualSumAfterExtraction
    {
        public static void Main()
        {
            List<int> firstList = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            List<int> secontList = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            for (int i = 0; i < firstList.Count; i++)
            {
                if (secontList.Contains(firstList[i]))
                { 
                    secontList.RemoveAll(j => j == firstList[i]);
                }
            }

            int firstListResult = 0;
            int seondListResult = 0;

            foreach (var number in firstList)
            {
                firstListResult += number;
            }

            foreach (var number in secontList)
            {
                seondListResult += number;
            }

            if (firstListResult == seondListResult)
            {
                Console.WriteLine("Yes. Sum: " + firstListResult);
            } else
            {
                Console.WriteLine("No. Diff: " + Math.Abs(firstListResult - seondListResult));
            }
        }
    }
}
