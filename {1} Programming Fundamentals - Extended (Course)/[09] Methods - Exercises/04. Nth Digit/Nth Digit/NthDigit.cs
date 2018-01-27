using System;

namespace Nth_Digit
{
    public class NthDigit
    {
        public static void Main()
        {
            long number = long.Parse(Console.ReadLine());
            int index = int.Parse(Console.ReadLine());

            FindNthDigit(number, index);
        }
        public static void FindNthDigit(long number, int index)
        {
            for (int i = 0; i < index; i++)
            {
                if (i == index - 1)
                {
                    number %= 10;
                } else
                {
                    number /= 10; 
                }
            }
            Console.WriteLine(number);
        }
    }
}
