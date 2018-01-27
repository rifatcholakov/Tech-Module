using System;

namespace Traveling_At_Light_Speed
{
    public class TravelingAtLightSpeed
    {
        public static void Main()
        {
             decimal lightYears = decimal.Parse(Console.ReadLine());

            decimal kilometers = lightYears * 9450000000000;
            decimal speedOfLight = 300000;
            decimal seconds = Math.Round(kilometers / speedOfLight);

            decimal minutes = seconds / 60;
            decimal hours = minutes / 60;
            decimal days = hours / 24;
            decimal weeks = days / 7;

            seconds %= 60;
            minutes %= 60;
            hours %= 24;
            days %= 7;

            Console.WriteLine($"{(int)weeks} weeks");
            Console.WriteLine($"{(int)days} days");
            Console.WriteLine($"{(int)hours} hours");
            Console.WriteLine($"{(int)minutes} minutes");
            Console.WriteLine($"{(int)seconds} seconds");
        }
    }
}
