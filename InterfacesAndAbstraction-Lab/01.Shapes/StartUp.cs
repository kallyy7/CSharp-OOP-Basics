namespace _01.Shapes
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int radius = int.Parse(Console.ReadLine());
            var circle = new Circle(radius);

            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            var rectangle = new Rectangle(width, height);

            circle.Draw();
            rectangle.Draw();
        }
    }
}
