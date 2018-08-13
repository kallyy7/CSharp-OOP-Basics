using System;
using System.Linq;

public class Startup
{
    public static void Main()
    {
        var coordinates = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();
        int topLeftX = coordinates[0];
        int topLeftY = coordinates[1];
        int bottomRightX = coordinates[2];
        int bottomRightY = coordinates[3];

        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            var topLeft = new Point(topLeftX, topLeftY);
            var bottomRight = new Point(bottomRightX, bottomRightY);
            var rectangle = new Rectangle(topLeft, bottomRight);

            var inputCoordOfPoints = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int x = inputCoordOfPoints[0];
            int y = inputCoordOfPoints[1];
            var currentPoints = new Point(x, y);

            Console.WriteLine(rectangle.Contains(currentPoints));
        }
    }
}