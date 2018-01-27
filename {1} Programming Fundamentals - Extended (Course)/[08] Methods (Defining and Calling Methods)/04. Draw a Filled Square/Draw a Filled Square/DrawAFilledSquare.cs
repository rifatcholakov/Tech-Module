using System;

namespace Draw_a_Filled_Square
{
    public class DrawAFilledSquare
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            HeaderAndFooter(n);
            Body(n);
            HeaderAndFooter(n);
        }
        public static void HeaderAndFooter(int n)
        {
            for (int i = 0; i < n * 2; i++)
            {
                Console.Write("-");
            }

            Console.WriteLine();
        }
        public static void Body(int n)
        {
            for (int j = 0; j < n - 2; j++)
            {
                Console.Write("-");

                for (int i = 1; i < n; i++)
                {
                    Console.Write("\\/");
                }

                Console.Write("-");
                Console.WriteLine();
            }
        }
    }
}
