using System;
using System.Globalization;

namespace Softuni_Coffee_Orders
{
    public class SoftuniCoffeeOrders
    {
        public static void Main()
        {
            int countOfOrders = int.Parse(Console.ReadLine());

            decimal total = 0;

            for (int i = 0; i < countOfOrders; i++)
            {
                decimal pricePerCapsule = decimal.Parse(Console.ReadLine());
                DateTime orderDate = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);
                uint capsulesCount = uint.Parse(Console.ReadLine());

                decimal coffePrice = DateTime.DaysInMonth(orderDate.Year, orderDate.Month) * capsulesCount * pricePerCapsule;
                Console.WriteLine($"The price for the coffee is: ${coffePrice:F2}");

                total += coffePrice;               
            }

            Console.WriteLine($"Total: ${total:F2}");
        }
    }
}
