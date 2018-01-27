using System;

namespace Sum_Array_Elements
{
    public class SumArrayElements
    {
        public static void Main()
        {
            int lenght = int.Parse(Console.ReadLine());

            int result = 0;

            for (int i = 0; i < lenght; i++)
            {
                int[] number = new int[lenght];

                number[i] = int.Parse(Console.ReadLine());

                result += number[i];
            }

            Console.WriteLine(result);
        }
    }
}
