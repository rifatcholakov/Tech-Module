using System;

namespace Sweet_Dessert
{
    public class SweetDessert
    {
        public static void Main()
        {
            decimal cash = decimal.Parse(Console.ReadLine());
            int guestsCount = int.Parse(Console.ReadLine());
            decimal bananasPrice = decimal.Parse(Console.ReadLine());
            decimal eggsPrice = decimal.Parse(Console.ReadLine());
            decimal berriesPrice = decimal.Parse(Console.ReadLine());

            decimal portionsCount = Math.Ceiling(guestsCount / 6m);

            decimal singleProductsPrice = 2 * bananasPrice + 4 * eggsPrice + 0.2m * berriesPrice;
            decimal totalPrice = portionsCount * singleProductsPrice;

            if (cash >= totalPrice)
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {totalPrice:F2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivancho will have to withdraw money - he will need {totalPrice - cash:F2}lv more.");
            }
        }
    }
}
