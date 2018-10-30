namespace _Animals
{
    using System;
    using System.Collections.Generic;

    class StartUp
    {
        private static string animalType;
        private static List<Animal> animals = new List<Animal>();

        static void Main(string[] args)
        {
            while (!(animalType = Console.ReadLine()).Equals("Beast!"))
            {
                try
                {
                    string[] animalData = Console.ReadLine().Split();
                    string name = animalData[0];
                    int age = int.Parse(animalData[1]);
                    string gender = animalData.Length == 3?
                        animalData[2] : string.Empty;

                    if (animalType.Equals("Cat"))
                    {
                        Cat cat = new Cat(name, age, gender);
                        animals.Add(cat);
                    }
                    else if (animalType.Equals("Dog"))
                    {
                        Dog dog = new Dog(name, age, gender);
                        animals.Add(dog);
                    }
                    else if (animalType.Equals("Frog"))
                    {
                        Frog frog = new Frog(name, age, gender);
                        animals.Add(frog);
                    }
                    else if (animalType.Equals("Kitten"))
                    {
                        Kitten kitten = new Kitten(name, age);
                        animals.Add(kitten);
                    }
                    else if (animalData.Equals("Tomcat"))
                    {
                        Tomcat tomcat = new Tomcat(name, age);
                        animals.Add(tomcat);
                    }
                    else
                    {
                        throw new ArgumentException("Invalid Input");
                    }

                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                }
            }

            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }
        }
    }
}
