namespace _02.Animals
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string name = Console.ReadLine();
            string favouriteFood = Console.ReadLine();
            var cat = new Cat(name, favouriteFood);

            name = Console.ReadLine();
            favouriteFood = Console.ReadLine();
            var dog = new Dog(name, favouriteFood);

            Console.WriteLine(cat.ExplainSelf());
            Console.WriteLine(dog.ExplainSelf());
        }
    }
}