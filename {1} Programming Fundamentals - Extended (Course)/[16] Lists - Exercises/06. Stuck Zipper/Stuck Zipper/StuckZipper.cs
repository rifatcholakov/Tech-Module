using System;
using System.Collections.Generic;
using System.Linq;

namespace Stuck_Zipper
{
    public class StuckZipper
    {
        public static void Main()
        {
            List<int> firstList = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> secondList = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int minCount = 0;

            if (Math.Abs(firstList.Min(element => Math.Abs(element))) < Math.Abs(secondList.Min(element => Math.Abs(element))))
            {
                int lowestNumber = Math.Abs(firstList.Min(element => Math.Abs(element)));

                while (lowestNumber > 0)
                {
                    minCount++;

                    lowestNumber /= 10;
                }

            }
            else if (Math.Abs(firstList.Min(element => Math.Abs(element))) == 0 || Math.Abs(secondList.Min(element => Math.Abs(element))) == 0)
            {
                minCount = 1;
            }
            else
            {
                int lowestNumber = Math.Abs(secondList.Min(element => Math.Abs(element)));

                while (lowestNumber > 0)
                {
                    minCount++;

                    lowestNumber /= 10;
                }

            }

            for (int i = 0; i < firstList.Count; i++)
            {
                int currentNumber = Math.Abs(firstList[i]);
                int count = 0;

                while (currentNumber > 0)
                {
                    count++;

                    currentNumber /= 10;
                }

                if (count > minCount)
                {
                    firstList.RemoveAt(i);
                    i--;
                }
            }

            for (int i = 0; i < secondList.Count; i++)
            {
                int currentNumber = Math.Abs(secondList[i]);
                int count = 0;

                while (currentNumber > 0)
                {
                    count++;

                    currentNumber /= 10;
                }

                if (count > minCount)
                {
                    secondList.RemoveAt(i);
                    i--;
                }
            }

            for (int i = 0, j = 0; i < secondList.Count; i++, j += 2)
            {
                if (firstList.Count == 0)
                {
                    firstList = secondList;
                    break;
                }
                try
                {
                    firstList.Insert(j, secondList[i]);
                }
                catch (System.ArgumentOutOfRangeException)
                {
                    j--;
                    firstList.Insert(j, secondList[i]);
                }

            }

            Console.WriteLine(string.Join(" ", firstList));

        }

    }
}
