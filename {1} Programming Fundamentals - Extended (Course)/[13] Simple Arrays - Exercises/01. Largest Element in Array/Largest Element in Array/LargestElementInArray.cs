using System;
using System.Linq;

namespace Largest_Element_in_Array
{
    public class LargestElementInArray
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int[] number = new int[n];

            for (int i = 0; i < n; i++)
            {
                number[i] = int.Parse(Console.ReadLine());
                
            }

            Console.WriteLine(number.Max());
        }
    }
}
