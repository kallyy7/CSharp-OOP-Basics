namespace _03.Shapes
{
    public class Rectangle : Shape
    {
        public double height { get; private set; }
        public double width { get; private set; }

        public Rectangle(double height, double width)
        {
            this.height = height;
            this.width = width;
        }

        public override double CalculatePerimeter()
        {
            return 2 * this.width + 2 * this.height;
        }

        public override double CalculateArea()
        {
            return this.width * this.height;
        }

        public override string Draw()
        {
            return base.Draw() + " Rectangle";
        }
    }
}