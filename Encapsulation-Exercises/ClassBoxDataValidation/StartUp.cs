namespace _FootballTeamGenerator
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            try
            {
                Box box = new Box(length, width, height);

                Console.WriteLine(box.GetSurfaceArea());
                Console.WriteLine(box.GetLateralSurfaceArea());
                Console.WriteLine(box.GetVolume());
            }
            catch (ArgumentException argumentException)
            {
                Console.WriteLine(argumentException.Message);
            }
        }
    }
}

