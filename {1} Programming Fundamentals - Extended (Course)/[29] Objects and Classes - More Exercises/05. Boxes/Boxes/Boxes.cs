using System;
using System.Collections.Generic;

namespace Boxes
{

    public class Boxes
    {
        public static void Main()
        {
            List<Box> boxesList = new List<Box>();

            string input = Console.ReadLine();

            while (!input.Equals("end"))
            {
                string[] inputParts = input.Split(" :|".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                Box currentBox = new Box();

                currentBox.upperLeft = ReadPoint(int.Parse(inputParts[0]), int.Parse(inputParts[1]));
                currentBox.upperRight = ReadPoint(int.Parse(inputParts[2]), int.Parse(inputParts[3]));
                currentBox.bottomLeft = ReadPoint(int.Parse(inputParts[4]), int.Parse(inputParts[5]));
                currentBox.bottomRight = ReadPoint(int.Parse(inputParts[6]), int.Parse(inputParts[7]));

                boxesList.Add(currentBox);

                input = Console.ReadLine();
            }

            foreach (var box in boxesList)
            {
                double width = Point.CalculateDistance(box.upperLeft, box.upperRight);
                double height = Point.CalculateDistance(box.upperLeft, box.bottomLeft);

                Console.WriteLine($"Box: {width}, {height}");
                Console.WriteLine($"Perimeter: {Box.CalculatePerimeter((int)width, (int)height)}");
                Console.WriteLine($"Area: {Box.CalculateArea((int)width, (int)height)}");
            }
        }

        public static Point ReadPoint(int x, int y)
        {
            return new Point
            {
                X = x,
                Y = y
            };
        }
    }
}
