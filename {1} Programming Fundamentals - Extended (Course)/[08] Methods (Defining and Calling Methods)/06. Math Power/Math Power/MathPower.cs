using System;

namespace Math_Power
{
    public class MathPower
    {
        public static void Main()
        {
            double num = double.Parse(Console.ReadLine());
            Double pow = double.Parse(Console.ReadLine());

            Console.WriteLine(MathPow(num, pow));
        }
        public static double MathPow(double num, double pow)
        {
            double result = num;

            for (double i = 1; i < pow; i++)
            {
                result = result * num;
            }

            return result;
        }
    }
}
