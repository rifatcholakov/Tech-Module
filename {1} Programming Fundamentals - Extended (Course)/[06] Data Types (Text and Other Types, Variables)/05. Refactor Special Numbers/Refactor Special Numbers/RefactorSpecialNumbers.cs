using System;

namespace Refactor_Special_Numbers
{
    public class RefactorSpecialNumbers
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int total = 0; int num = 0; bool special = false;

            for (int i = 1; i <= n; i++)
            {
                num = i;

                while (i > 0)
                {
                    total += i % 10;
                    i = i / 10;
                }

                special = (total == 5) || (total == 7) || (total == 11);

                Console.WriteLine($"{num} -> {special}");

                total = 0;
                i = num;
            }
        }
    }
}
