namespace _01.MathOperation
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var mathOp = new MathOperations();
            Console.WriteLine(mathOp.Add(2, 3));
            Console.WriteLine(mathOp.Add(2.2, 3.3, 5.5));
            Console.WriteLine(mathOp.Add(2.2m, 3.3m, 4.4m));
        }
    }
}
