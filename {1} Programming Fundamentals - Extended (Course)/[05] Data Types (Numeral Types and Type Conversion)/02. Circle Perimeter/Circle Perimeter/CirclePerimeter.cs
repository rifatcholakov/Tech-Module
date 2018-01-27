using System;

namespace Circle_Perimeter
{
    public class CirclePerimeter
    {
        public static void Main()
        {
            double radius = double.Parse(Console.ReadLine());

            double perimeter = 2 * Math.PI * radius;

            Console.WriteLine("{0:F12}", perimeter);
        }
    }
}
