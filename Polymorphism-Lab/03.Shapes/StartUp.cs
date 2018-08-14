namespace _03.Shapes
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            double height = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            var rectangle = new Rectangle(height, width);

            double radius = double.Parse(Console.ReadLine());
            var circle = new Circle(radius);

            Console.WriteLine(circle.CalculateArea());
            Console.WriteLine(circle.CalculatePerimeter());
            Console.WriteLine(circle.Draw());

            Console.WriteLine(rectangle.CalculateArea());
            Console.WriteLine(rectangle.CalculatePerimeter());
            Console.WriteLine(rectangle.Draw());
        }
    }
}
