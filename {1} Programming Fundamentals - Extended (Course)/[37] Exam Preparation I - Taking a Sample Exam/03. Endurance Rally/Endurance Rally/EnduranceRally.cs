using System;
using System.Linq;

namespace Endurance_Rally
{
    public class EnduranceRally
    {
        public static void Main()
        {
            string[] participants = Console.ReadLine().Split();

            double[] trackIndices = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();

            double[] checkpointIndices = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();

            foreach (var participant in participants)
            {
                double fuel = participant[0];                

                for (int currentTrackIndex = 0; currentTrackIndex <= trackIndices.Length; currentTrackIndex++)
                {
                    bool outOfFuel = fuel <= 0;
                    bool rechedEndOfTrack = currentTrackIndex == trackIndices.Length;
                    bool raceEnded = outOfFuel || rechedEndOfTrack;

                    if (raceEnded)
                    {
                        if (outOfFuel)
                        {
                            Console.WriteLine($"{participant} - reached {currentTrackIndex - 1}");
                        }
                        else if (rechedEndOfTrack)
                        {
                            Console.WriteLine($"{participant} - fuel left {fuel:F2}");
                        }

                        break;
                    }

                    double fuelAtCheckPoint = trackIndices[currentTrackIndex];

                    bool isCheckPoint = checkpointIndices.Contains(currentTrackIndex);
                    if (isCheckPoint)
                    {
                        fuel += fuelAtCheckPoint;
                    }
                    else
                    {
                        fuel -= fuelAtCheckPoint;
                    }                    
                }
            }
        }
    }
}
