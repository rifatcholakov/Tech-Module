using System;

namespace Hornet_Wings
{
    public class HornetWings
    {
        public static void Main()
        {
            long wingFlaps = long.Parse(Console.ReadLine());
            decimal distancePerThousandWingFlaps = decimal.Parse(Console.ReadLine());
            long endurance = long.Parse(Console.ReadLine());

            decimal totalDistance = (wingFlaps / 1000) * distancePerThousandWingFlaps;

            long movingTime = wingFlaps / 100;
            long restTime = (wingFlaps / endurance) * 5;

            Console.WriteLine($"{totalDistance:F2} m.");
            Console.WriteLine($"{movingTime + restTime} s.");
        }
    }
}
