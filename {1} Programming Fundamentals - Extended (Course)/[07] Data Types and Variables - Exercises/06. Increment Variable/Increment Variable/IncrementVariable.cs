using System;

namespace Increment_Variable
{
    public class IncrementVariable
    {
        public static void Main()
        {
            int incrementTimes = int.Parse(Console.ReadLine());
            int overFlowTimes = incrementTimes / (byte.MaxValue + 1);

            byte number = 0;

            for (int i = 0; i < incrementTimes; i++)
            {
                number++;
            }

            if (incrementTimes <= 255)
            {
                Console.WriteLine(number);
            } else
            {
                Console.WriteLine(number);
                Console.WriteLine("Overflowed " + overFlowTimes + " times");
            }
        }
    }
}
