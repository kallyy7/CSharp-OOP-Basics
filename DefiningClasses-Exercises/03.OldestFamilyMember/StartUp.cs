﻿namespace DefiningClasses
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            Family member = new Family();

            for (int i = 0; i < input; i++)
            {
                string[] data = Console.ReadLine().Split();

                string name = data[0];
                int age = int.Parse(data[1]);
                Person person = new Person(name, age);
                member.AddMember(person);

            }

            Console.WriteLine(member.GetOldestMember());
        }
    }
}
