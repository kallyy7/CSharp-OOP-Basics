public class Rectangle
{
    public Point TopLeft { get; private set; }
    public Point BottomRight { get; private set; }

    public Rectangle(Point topLeft, Point bottomRight)
    {
        this.TopLeft = topLeft;
        this.BottomRight = bottomRight;
    }

    public bool Contains(Point inputCoordOfPoints)
    {
        bool isInHorizontal =
            this.TopLeft.X <= inputCoordOfPoints.X &&
            this.BottomRight.X >= inputCoordOfPoints.X;
        bool isInVertical =
            this.TopLeft.Y <= inputCoordOfPoints.Y &&
            this.BottomRight.Y >= inputCoordOfPoints.Y;
        bool isInRectangle = isInHorizontal && isInVertical;

        return isInRectangle;
    }
}
