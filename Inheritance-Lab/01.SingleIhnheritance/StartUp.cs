namespace _01.SingleIhnheritance
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var dog = new Dog();
            Console.WriteLine(dog.Eat());
            Console.WriteLine(dog.Bark());
        }
    }
}
