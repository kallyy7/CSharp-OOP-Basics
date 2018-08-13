namespace _01.SortPersonsByNameAndAge
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var persons = new List<Person>();

            Add(n, persons);

            persons.OrderBy(p => p.FirstName)
                .ThenBy(p => p.Age)
                .ToList()
                .ForEach(p => Console.WriteLine(p.ToString()));
        }

        private static void Add(int n, List<Person> persons)
        {
            for (int i = 0; i < n; i++)
            {
                var inputData = Console.ReadLine().Split();
                string firstName = inputData[0];
                string lastName = inputData[1];
                int age = int.Parse(inputData[2]);

                var person = new Person(firstName, lastName, age);
                persons.Add(person);
            }
        }
    }
}