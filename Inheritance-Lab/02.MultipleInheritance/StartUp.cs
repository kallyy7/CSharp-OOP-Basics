namespace _02.MultipleInheritance
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var puppy = new Puppy();
            Console.WriteLine(puppy.Eat());
            Console.WriteLine(puppy.Bark());
            Console.WriteLine(puppy.Weep());
        }
    }
}
