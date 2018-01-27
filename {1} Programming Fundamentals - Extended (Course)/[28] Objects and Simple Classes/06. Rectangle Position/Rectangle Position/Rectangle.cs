namespace Rectangle_Position
{
    public class Rectangle
    {
        public int Top { get; set; }

        public int Left { get; set; }

        public int Width { get; set; }

        public int Height { get; set; }

        public int Bottom
        {
            get
            {
                return Top + Height;
            }
        }

        public int Right
        {
            get
            {
                return Left + Width;
            }
        }

        public int Area()
        {
            return Width * Height;
        }

        public bool IsInside(Rectangle rectangle)
        {
            bool leftIsValid = rectangle.Left <= Left;
            bool topIsValid = rectangle.Top <= Top;
            bool rightIsvalid = rectangle.Right >= Right;
            bool bottomIsvalid = rectangle.Bottom >= Bottom;

            return leftIsValid
                && topIsValid
                && rightIsvalid
                && bottomIsvalid;
        }
    }
}
