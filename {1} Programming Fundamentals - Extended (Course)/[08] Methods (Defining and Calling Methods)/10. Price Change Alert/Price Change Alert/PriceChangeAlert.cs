using System;

namespace Price_Change_Alert
{
    public class PriceChangeAlert
    {
        public static void Main()
        {
            int numberOfPrices = int.Parse(Console.ReadLine());

            double significanceTreshold = double.Parse(Console.ReadLine());

            double last = double.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfPrices - 1; i++)
            {
                double prices = double.Parse(Console.ReadLine());
                double differece = Procentage(last, prices); bool isSignificantDifference = isThereDifference(differece, significanceTreshold);

                string message = Get(prices, last, differece, isSignificantDifference);
                Console.WriteLine(message);

                last = prices;
            }
        }

        public static string Get(double currentPrice, double lastPrice, double difference, bool etherTrueOrFalse)
        {
            string result = string.Empty;
            if (difference == 0)
            {
                result = string.Format("NO CHANGE: {0}", currentPrice);
            }
            else if (!etherTrueOrFalse)
            {
                result = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, difference * 100);
            }
            else if (etherTrueOrFalse && (difference > 0))
            {
                result = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, difference * 100);
            }
            else if (etherTrueOrFalse && (difference < 0))
                result = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, difference * 100);
            return result;
        }
        public static bool isThereDifference(double threshold, double difference)
        {
            if (Math.Abs(threshold) >= difference)
            {
                return true;
            }
            return false;
        }

        public static double Procentage(double lastPrice, double currentPrice)
        {
            double result = (currentPrice - lastPrice) / lastPrice;
            return result;
        }
    }
}
