using System;
using System.Linq;

namespace Ballistics_Training
{
    public class BallisticsTraining
    {
        public static void Main()
        {
            double[] target = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();

            string[] input = Console.ReadLine()
                .Split();

            double xCoordinate = 0;
            double yCoordinate = 0;

            for (int i = 0; i < input.Length - 1; i += 2)
            {
                string command = input[i];

                double manipulatorIndex = double.Parse(input[i + 1]);

                if (command.Equals("up"))
                {
                    yCoordinate += manipulatorIndex;
                }
                else if (command.Equals("down"))
                {
                    yCoordinate -= manipulatorIndex;
                }
                else if (command.Equals("left"))
                {
                    xCoordinate -= manipulatorIndex;
                }
                else
                {
                    xCoordinate += manipulatorIndex;
                }

            }

            Console.WriteLine($"firing at [{xCoordinate}, {yCoordinate}]");

            if (xCoordinate.Equals(target[0]) && yCoordinate.Equals(target[1]))
            {
                Console.WriteLine("got 'em!");
            }
            else
            {
                Console.WriteLine("better luck next time...");
            }

        }
    }
}
