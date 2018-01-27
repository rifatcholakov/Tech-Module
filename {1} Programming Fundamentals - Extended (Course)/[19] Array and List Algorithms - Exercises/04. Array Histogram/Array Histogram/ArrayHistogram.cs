using System;
using System.Collections.Generic;
using System.Linq;

namespace Array_Histogram
{
    class ArrayHistogram
    {
        static void Main()
        {
            List<string> input = Console.ReadLine()
                .Split(' ')
                .ToList();

            List<int> counts = new List<int>();
            List<string> words = new List<string>();
            List<string> percentage = new List<string>();

            CountOfElements(input, counts, words);

            bool swapped;
            swapped = Sort(counts, words);

            int sum = 0;
            sum = Sum(counts, sum);

            double onePercent = 100.0 / sum;
            Percentage(counts, percentage, onePercent);

            Output(counts, words, percentage);
        }

        public static void Output(List<int> counts, List<string> words, List<string> percentage)
        {
            for (int i = 0; i < counts.Count; i++)
            {
                Console.WriteLine(words[i] + " -> " + counts[i] + " times " + "(" + percentage[i] + "%)");
            }
        }

        public static void Percentage(List<int> counts, List<string> percentage, double onePercent)
        {
            for (int i = 0; i < counts.Count; i++)
            {
                double result = counts[i] * onePercent;
                 string result2 = String.Format("{0:0.00}", result);
                percentage.Add(result2);
            }
        }

        public static int Sum(List<int> counts, int sum)
        {
            for (int i = 0; i < counts.Count; i++)
            {
                sum += counts[i];
            }

            return sum;
        }

        public static bool Sort(List<int> counts, List<string> words)
        {
            bool swapped;
            do
            {
                swapped = false;

                for (int j = 0; j < counts.Count - 1; j++)
                {
                    if (counts[j] < counts[j + 1])
                    {
                        int tempCount = counts[j];
                        counts[j] = counts[j + 1];
                        counts[j + 1] = tempCount;

                        string tempWord = words[j];
                        words[j] = words[j + 1];
                        words[j + 1] = tempWord;

                        swapped = true;
                    }
                }

            } while (swapped);
            return swapped;
        }

        public static void CountOfElements(List<string> input, List<int> counts, List<string> words)
        {
            for (int i = 0; i < input.Count; i++)
            {
                if (!words.Contains(input[i]))
                {
                    words.Add(input[i]);

                    int count = 0;

                    for (int j = 0; j < input.Count; j++)
                    {
                        if (input[i] == input[j])
                        {
                            count++;
                        }
                    }

                    counts.Add(count);
                }
            }
        }
    }
}
