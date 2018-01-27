using System;

namespace Multiply_Evens_by_Odds
{
    public class MultiplyEvensByOdds
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            int result = EvenDigits(number) * OddDigits(number);

            Console.WriteLine(result);
        }
        public static int EvenDigits(int number)
        {
            string numberLenght = number.ToString();
            int result = 0;

            for (int i = 0; i < numberLenght.Length; i++)
            {
                int residue = number % 10;

                if (residue % 2 == 0)
                {
                    result += residue;
                }

                number /= 10; 
            }

            return result;
        }
        public static int OddDigits(int number)
        {
            string numberLenght = number.ToString();
            int result = 0;

            for (int i = 0; i < numberLenght.Length; i++)
            {
                int residue = number % 10;

                if (residue % 2 != 0)
                {
                    result += residue;
                }

                number /= 10;
            }

            return result;
        }
    }
}
