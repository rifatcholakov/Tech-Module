using System;

namespace Boxes
{

    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public static double CalculateDistance(Point firstPoint, Point secondPoint)
        {
            int sideX = Math.Abs(firstPoint.X - secondPoint.X);
            int sideY = Math.Abs(firstPoint.Y - secondPoint.Y);

            return Math.Sqrt(Math.Pow((sideX), 2) + Math.Pow((sideY), 2));
        }
    }
}