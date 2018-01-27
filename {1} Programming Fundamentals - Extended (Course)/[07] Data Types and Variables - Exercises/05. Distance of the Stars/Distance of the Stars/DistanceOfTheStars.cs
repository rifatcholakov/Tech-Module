using System;
using System.Numerics;

namespace Distance_of_the_Stars
{
    public class DistanceOfTheStars
    {
        public static void Main()
        {
            var eartStar = 4.22;
            var centerGalaxy = 26000;
            var milkyWay = 100000;
            decimal edgeUniverse = 46500000000;
            var lightYear = 9450000000000;


            Console.WriteLine("{0:e2}", eartStar * lightYear);
            Console.WriteLine("{0:e2}", centerGalaxy * lightYear);
            Console.WriteLine("{0:e2}", milkyWay * lightYear);
            Console.WriteLine("{0:e2}", edgeUniverse * (decimal)lightYear);
        }
    }
}
