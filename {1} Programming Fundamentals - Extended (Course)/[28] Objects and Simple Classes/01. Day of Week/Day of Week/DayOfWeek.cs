using System;
using System.Globalization;

namespace Day_of_Week
{
    public class DayOfWeek
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            DateTime date = DateTime.ParseExact(input, "d-M-yyyy", CultureInfo.InvariantCulture);

            Console.WriteLine(date.DayOfWeek);
        }
    }
}
