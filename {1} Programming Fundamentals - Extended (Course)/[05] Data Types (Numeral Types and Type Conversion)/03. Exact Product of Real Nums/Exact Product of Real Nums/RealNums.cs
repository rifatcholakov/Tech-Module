using System;

namespace Exact_Product_of_Real_Nums
{
    public class RealNums
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            decimal product = 1;

            for (int i = 1; i <= n; i++)
            {
                product *= decimal.Parse(Console.ReadLine());
            }

           Console.WriteLine(product);
        }
    }
}
