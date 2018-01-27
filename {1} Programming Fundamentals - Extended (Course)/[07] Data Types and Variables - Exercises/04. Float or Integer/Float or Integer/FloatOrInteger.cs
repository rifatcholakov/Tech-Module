using System;

namespace Float_or_Integer
{
    public class FloatOrInteger
    {
        public static void Main()
        {
            decimal number = decimal.Parse(Console.ReadLine());

            Console.WriteLine(Math.Round(number));
        }
    }
}
