using System;

namespace Wormtest
{
    public class Wormtest
    {
        public static void Main()
        {
            int lengthInMeters = int.Parse(Console.ReadLine());
            decimal widthInCentimeters = decimal.Parse(Console.ReadLine());

            int lengthInCentimeters = lengthInMeters * 100;
            decimal firstResult = lengthInCentimeters * widthInCentimeters;

            if (lengthInMeters == 0 || widthInCentimeters == 0)
            {
                Console.WriteLine($"{firstResult:F2}");
                return;
            }

            decimal reminder = lengthInCentimeters % widthInCentimeters;
            decimal secondResult = (lengthInCentimeters / widthInCentimeters) * 100;

            if (reminder == 0)
                Console.WriteLine($"{firstResult:F2}");
            else
                Console.WriteLine($"{secondResult:F2}%");
        }
    }
}
