using System;
using System.Collections.Generic;

namespace Sales_Report
{

    public class SalesReport
    {
        public static void Main()
        {
            int total = int.Parse(Console.ReadLine());

            SortedDictionary<string, decimal> result = new SortedDictionary<string, decimal>();

            for (int i = 0; i < total; i++)
            {
                string currentSaleAsString = Console.ReadLine();
                Sale currentSale = Sale.Parse(currentSaleAsString);

                if (!result.ContainsKey(currentSale.Town))
                {
                    result[currentSale.Town] = 0;
                }

                result[currentSale.Town] += currentSale.Quantity * currentSale.Price;
            }

            foreach (var item in result)
            {
                Console.WriteLine($"{item.Key} -> { item.Value:F2}");
            }
        }
    }
}
