using System;

namespace Multiply_Evens_by_Odds
{
    public class MultiplyEvensByOdds
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine(Multiply(number));
        }

        public static int Multiply(int num)
        {
            num = Math.Abs(num);

            int even = 0;
            int odd = 0;

            while (num > 0)
            {
                int residue = num % 10;
                num /= 10;
                if (residue % 2 == 0)
                {
                    even += residue; 
                } else
                {
                    odd += residue;
                }
            }

            int result = even * odd;

            return result;
        }
    }
}
