using System;

namespace Charity_Marathon
{
    public class CharityMarathon
    {
        public static void Main()
        {
            int daysCount = int.Parse(Console.ReadLine());
            int participants = int.Parse(Console.ReadLine());
            int lapsPerRunner = int.Parse(Console.ReadLine());
            int trackLength = int.Parse(Console.ReadLine());
            int trackCapacity = int.Parse(Console.ReadLine());
            decimal moneyPerKilometer = decimal.Parse(Console.ReadLine());

            long maxRunners = trackCapacity * daysCount;
            long runners = participants;

            if (runners > maxRunners) runners = maxRunners;

            long totalMeters = runners * lapsPerRunner * trackLength;
            decimal totalKilometers = totalMeters / 1000m;
            decimal raisedMoney = totalKilometers * moneyPerKilometer;

            Console.WriteLine($"Money raised: {raisedMoney:F2}");
        }
    }
}
