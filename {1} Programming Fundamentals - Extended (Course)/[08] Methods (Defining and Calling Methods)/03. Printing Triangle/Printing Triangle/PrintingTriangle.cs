using System;

namespace Printing_Triangle
{
    public class PrintingTriangle
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            FirstHalf(n);

            for (int i = 1; i <= n; i++)
            {
                Console.Write($"{i} ");
            }

            Console.WriteLine();

            SecoundHalf(n);
        }
        public static void PrintLine(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();
        }
        public static void FirstHalf(int n)
        {
            for (int i = 0; i < n; i++)
            {
                PrintLine(1, i);
            }
        }
        public static void SecoundHalf(int n)
        {
            for (int i = n - 1; i >= 0; i--)
            {
                PrintLine(1, i);
            }
        }
    }
}
