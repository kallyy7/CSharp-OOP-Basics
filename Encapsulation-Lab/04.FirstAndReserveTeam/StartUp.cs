namespace _04.FirstAndReserveTeam
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var persons = new List<Person>();
            var team = new Team("SoftUni");

            Add(n, persons, team);

            foreach (var p in persons)
            {
                team.AddPlayer(p);
            }

            Console.WriteLine("First team has {0} players.", team.FirstTeam.Count);
            Console.WriteLine("Reserve team has {0} players.", team.ReserveTeam.Count);
        }

        private static void Add(int n, List<Person> persons, Team team)
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
