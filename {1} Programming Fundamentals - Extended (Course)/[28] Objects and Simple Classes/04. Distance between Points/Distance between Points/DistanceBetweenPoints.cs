using System;
using System.Linq;

namespace Distance_between_Points
{
    public class DistanceBetweenPoints
    {
        public static void Main()
        {
            Point firstPoint = ReadPoint();

            Point secondPoint = ReadPoint();

            double result = Distance(firstPoint, secondPoint);

            Console.WriteLine($"{result:F3}");
        }

        public static double Distance(Point first, Point second)
        {
            double squareX = Math.Pow(first.x - second.x, 2);
            double squareY = Math.Pow(first.y - second.y, 2);

            double result = Math.Sqrt(squareX + squareY);

            return result;
        }

        public static Point ReadPoint()
        {
            int[] pointParts = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            return new Point
            {
                x = pointParts[0],
                y = pointParts[1]
            };
        }
    }
}
