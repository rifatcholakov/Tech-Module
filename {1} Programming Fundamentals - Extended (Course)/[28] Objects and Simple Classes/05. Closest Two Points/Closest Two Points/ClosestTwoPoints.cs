using System;
using System.Collections.Generic;
using System.Linq;

namespace Closest_Two_Points
{
    
    public class ClosestTwoPoints
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            List<Point> points = new List<Point>();

            for (int i = 0; i < n; i++)
            {
                Point currentPoint = ReadPoint();
                points.Add(currentPoint);
            }

            double minimumDistance = double.MaxValue;

            Point firstPointResult = null;
            Point secondPointResult = null;

            for (int first = 0; first < points.Count; first++)
            {
                for (int second = first + 1; second < points.Count; second++)
                {
                    Point firstPoint = points[first];
                    Point secondPoint = points[second];

                    double distance = Distance(firstPoint, secondPoint);

                    if(distance < minimumDistance)
                    {
                        minimumDistance = distance;

                        firstPointResult = firstPoint;
                        secondPointResult = secondPoint;
                    }
                }
            }

            Console.WriteLine($"{minimumDistance:F3}");
            Console.WriteLine(firstPointResult.Print());
            Console.WriteLine(secondPointResult.Print());
        }

        public static Point ReadPoint()
        {
            int[] pointParts = Console.ReadLine()
                    .Split(' ')
                    .Select(int.Parse)
                    .ToArray();

            return new Point
            {
                X = pointParts[0],
                Y = pointParts[1]
            };
        }

        public static double Distance(Point first, Point second)
        {
            double squareX = Math.Pow(first.X - second.X, 2);
            double squareY = Math.Pow(first.Y - second.Y, 2);

            double result = Math.Sqrt(squareX + squareY);

            return result;
        }
    }
}
