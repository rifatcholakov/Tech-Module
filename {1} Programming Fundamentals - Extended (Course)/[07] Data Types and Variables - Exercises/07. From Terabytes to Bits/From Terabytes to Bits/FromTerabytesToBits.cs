using System;
using System.Numerics;

namespace From_Terabytes_to_Bits
{
    public class FromTerabytesToBits
    {
        public static void Main()
        {
            double terabytes = double.Parse(Console.ReadLine());

            double bites = (((((terabytes * 1024) * 1024) * 1024) * 1024) * 8);

            Console.WriteLine(bites);
        }
    }
}
