using System;
using System.Collections.Generic;
using System.Linq;

namespace Batteries
{
    class Batteries
    {
        static void Main(string[] args)
        {
            double[] capacities = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();

            double[] usagePerHour = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();

            int hours = int.Parse(Console.ReadLine());

            for (int i = 0; i < capacities.Length; i++)
            {
                if(capacities[i] / usagePerHour[i] >= hours)
                {
                    int batteryNumber = i + 1;

                    double leftCapacity = capacities[i] - (hours * usagePerHour[i]);

                    double percentage = leftCapacity / (capacities[i] / 100.0);

                    Console.WriteLine("Battery " + batteryNumber + ": " + String.Format("{0:0.00}", leftCapacity) + " mAh " + "(" + String.Format("{0:0.00}", percentage) + ")%");
                }
                else
                {
                    int batteryNumber = i + 1;

                    int lastedHours = (int)(Math.Ceiling(capacities[i] / usagePerHour[i]));

                    Console.WriteLine("Battery " + batteryNumber + ": " + "dead" + " (lasted " + lastedHours + " hours)" );
                }

            }
        }
    }
}
