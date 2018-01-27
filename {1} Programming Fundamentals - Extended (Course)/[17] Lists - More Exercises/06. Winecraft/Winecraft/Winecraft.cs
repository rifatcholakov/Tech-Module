using System;
using System.Collections.Generic;
using System.Linq;

namespace Winecraft
{
    public class Winecraft
    {
        public static void Main()
        {
            List<int> grapes = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            int growthDays = int.Parse(Console.ReadLine());

            while (grapes.Count > growthDays)
            {
                for (int j = 0; j < growthDays; j++)
                {
                    NegativeGrapesToZero(grapes);

                    IncrementAllGrapes(grapes, growthDays);

                    for (int i = 0; i < grapes.Count; i++)
                    {
                        bool isFirstElement = i == 0;
                        bool isLastElement = i == grapes.Count - 1;

                        if (!isFirstElement && !isLastElement)
                            ProcessingGrapes(grapes, i);
                    }
                }

                RemoveUnnecessaryGarpes(grapes, growthDays);
            }
            
            Console.WriteLine(string.Join(" ", grapes));
        }

        public static void NegativeGrapesToZero(List<int> grapes)
        {
            for (int i = 0; i < grapes.Count; i++)
            {
                if (grapes[i] < 0)
                {
                    grapes[i] = 0;
                }
            }
        }

        public static void RemoveUnnecessaryGarpes(List<int> grapes, int growthDays)
        {
            for (int i = 0; i < grapes.Count; i++)
            {
                if (grapes[i] <= growthDays)
                {
                    grapes.RemoveAt(i);

                    i--;
                }
            }
        }

        public static void ProcessingGrapes(List<int> grapes, int i)
        {

            if (grapes[i] > grapes[i - 1] && grapes[i] > grapes[i + 1])
            {
                grapes[i]--;

                if (grapes[i - 1] > 0)
                {
                    grapes[i - 1] -= 2;
                    grapes[i]++;
                }

                if (grapes[i + 1] > 0)
                {
                    grapes[i + 1] -= 2;
                    grapes[i]++;
                }
            }

        }

        public static void IncrementAllGrapes(List<int> grapes, int growthDays)
        {
            for (int i = 0; i < grapes.Count; i++)
            {
                grapes[i]++;
            }
        }

    }
}
