using System;

namespace Special_Numbers
{
    public class SpecilNumbers
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                int sum = 0;
                int residue = 0;

                do
                {
                    residue = i % 10;
                    residue /= 10;
                    sum += residue;
                } while (residue > 0);

                if (sum == 5 || sum == 7 || sum == 11)
                {
                    Console.WriteLine($"{i} -> True");
                }
                else
                {
                    Console.WriteLine($"{i} -> False");
                }
                sum = 0;
            }
        }
    }
}

