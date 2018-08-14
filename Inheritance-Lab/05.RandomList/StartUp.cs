namespace _05.RandomList
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            List<string> input = Console.ReadLine()
                .Split()
                .ToList();

            var randomList = new RandomList();

            Console.WriteLine(string.Join(" ",
                randomList.RandomString(input)));
        }
    }
}