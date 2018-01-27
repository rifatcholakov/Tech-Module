using System;

namespace Calculate_Triangle_Area
{
    public class CalculateTriangleArea
    {
        public static void Main()
        {
            double b = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            Console.WriteLine(Area(b, h));
        }
        public static double Area(double b, double h)
        {
            double area = b * h / 2;

            return area;
        }
    }
}
