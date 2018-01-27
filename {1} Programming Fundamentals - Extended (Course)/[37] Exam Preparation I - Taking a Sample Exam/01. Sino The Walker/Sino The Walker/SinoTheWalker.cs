using System;
using System.Globalization;

namespace Sino_The_Walker
{
    public class SinoTheWalker
    {
        public static void Main()
        {
            TimeSpan timeSinoLeaves = TimeSpan.ParseExact(Console.ReadLine(), @"hh\:mm\:ss", CultureInfo.InvariantCulture);
            int numberOfSteps = int.Parse(Console.ReadLine());
            int stepPerSecound = int.Parse(Console.ReadLine());

            int secoundsInADay = 60 * 60 * 24;
            int totalSecoundsNeeded = (((double)numberOfSteps * stepPerSecound) % secoundsInADay);
            TimeSpan neededTimeToArrive = TimeSpan.FromSeconds(totalSecoundsNeeded);
            TimeSpan timeOfArrival = timeSinoLeaves + neededTimeToArrive;

            Console.WriteLine($"Time Arrival: {timeOfArrival.ToString(@"hh\:mm\:ss")}");
        }
    }
}
