using System;
using System.Linq;

namespace Power_Plants
{
    public class PowerPlants
    {
        public static void Main()
        {
            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int day = -1;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] > 0)
                {
                    input[i]++;
                }

                for (int j = 0; j < input.Length; j++)
                {
                    if (input[j] != 0)
                    {
                        input[j]--;
                    }
                }

                day++;

                int sum = 0;

                for (int j = 0; j < input.Length; j++)
                {
                    sum += input[j];
                }

                if (sum > 0)
                {
                    if (i == input.Length - 1)
                    {
                        for (int k = 0; k < input.Length; k++)
                        {
                            if (input[k] > 0)
                            {
                                input[k]++;
                            }
                        }

                        i = -1;
                    }

                    continue;
                }
                else if (day / input.Length == 1)
                {

                    Console.WriteLine("survived {0} days ({1} season)", day + 1, day / input.Length);
                    return;
                }
                else
                {
                    Console.WriteLine("survived {0} days ({1} seasons)", day + 1, day / input.Length);
                    break;
                }

            }

            Console.WriteLine();
        }
    }
}
