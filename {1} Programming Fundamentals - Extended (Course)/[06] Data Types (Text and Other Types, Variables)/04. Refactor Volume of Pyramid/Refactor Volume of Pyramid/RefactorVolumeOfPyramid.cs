using System;

namespace Refactor_Volume_of_Pyramid
{
    public class RefactorVolumeOfPyramid
    {
        public static void Main()
        {
            double lengh, width, height, v = 0;

            Console.Write("Length: ");
            lengh = double.Parse(Console.ReadLine());

            Console.Write("Width: ");
            width = double.Parse(Console.ReadLine());

            Console.Write("Height: ");
            height = double.Parse(Console.ReadLine());

            v = (lengh * width * height) / 3;

            Console.WriteLine("Pyramid Volume: {0:F2}", v);
        }
    }
}
