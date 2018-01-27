using System;
using System.Linq;

namespace Rectangle_Position
{

    public class RectanglePosition
    {
        public static void Main()
        {
            Rectangle firstRectangle = ReadRectangle();
            Rectangle secondRectangle = ReadRectangle();

            bool result = firstRectangle.IsInside(secondRectangle);

            string printResult = result ? "Inside" : "Not inside";

            Console.WriteLine(printResult);
        }

        public static Rectangle ReadRectangle()
        {
            int[] rectangleParts = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            return new Rectangle
            {
                Left = rectangleParts[0],
                Top = rectangleParts[1],
                Width = rectangleParts[2],
                Height = rectangleParts[3]
            };
        }
    }
}
