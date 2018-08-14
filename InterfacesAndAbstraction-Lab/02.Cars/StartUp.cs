namespace _02.Cars
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string model = Console.ReadLine();
            string color = Console.ReadLine();
            var seat = new Seat(model, color);

            model = Console.ReadLine();
            color = Console.ReadLine();
            int batteries = int.Parse(Console.ReadLine());
            var tesla = new Tesla(model, color, batteries);

            Console.WriteLine(seat.ToString());
            Console.WriteLine(tesla.ToString());
        }
    }
}
