using System;

namespace Min_Method
{
    public class MinMethod
    {
        public static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            GetMin(a, b, c);
        }
        public static void GetMin(int a, int b, int c)
        {
            int smallestNumber = Math.Min(a, b);
            Console.WriteLine(Math.Min(smallestNumber, c));
        }
    }
}
