namespace _02.Salary
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var persons = new List<Person>();

            Add(n, persons);

            decimal bonus = decimal.Parse(Console.ReadLine());

            persons.ForEach(p => p.IncreaseSalary(bonus));
            persons.ForEach(p => Console.WriteLine(p.ToString()));
        }

        private static void Add(int n, List<Person> persons)
        {
            for (int i = 0; i < n; i++)
            {
                var inputData = Console.ReadLine().Split();
                string firstName = inputData[0];
                string lastName = inputData[1];
                int age = int.Parse(inputData[2]);
                decimal salary = decimal.Parse(inputData[3]);

                var person = new Person(firstName, lastName, age, salary);
                persons.Add(person);
            }
        }
    }
}