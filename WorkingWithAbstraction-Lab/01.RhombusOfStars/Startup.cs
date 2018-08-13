using System;

public class Startup
{
    public static void Main()
    {
        int inputSize = int.Parse(Console.ReadLine());

        for (int stars = 1; stars <= inputSize; stars++)
        {
            PrintRow(inputSize, stars);
        }

        for (int stars = inputSize - 1; stars >= 1; stars--)
        {
            PrintRow(inputSize, stars);
        }
    }

    private static void PrintRow(int inputSize, int stars)
    {
        for (int i = 0; i < inputSize - stars; i++)
        {
            Console.Write(" ");
        }

        for (int i = 1; i < stars; i++)
        {
            Console.Write("* ");
        }

        Console.WriteLine("*");
    }
}