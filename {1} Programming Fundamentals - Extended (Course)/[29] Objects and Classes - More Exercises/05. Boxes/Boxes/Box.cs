namespace Boxes
{
    public class Box
    {
        public Point upperLeft { get; set; }

        public Point upperRight { get; set; }
        
        public Point bottomLeft { get; set; }

        public Point bottomRight { get; set; }

        public static int CalculatePerimeter(int width, int height)
        {
            return ((2 * width) + (2 * height));
        }

        public static int CalculateArea(int width, int height)
        {
            return (width * height);
        }
    }
}
