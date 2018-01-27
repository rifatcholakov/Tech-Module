using System;
using System.Linq;

namespace Count_of_Negative_Elements_in_Array
{
    public class CountOfNegativeElementsInArray
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int[] number = new int[n];

            int negativeNumbers = 0;

            for (int i = 0; i < n; i++)
            {
                number[i] = int.Parse(Console.ReadLine());

                if (number[i] < 0)
                {
                    negativeNumbers++;
                }
            }

            Console.WriteLine(negativeNumbers);
        }
    }
}
