using System;

public class Startup
{
    public static void Main()
    {
        var students = new StudentSystem();
        var input = Console.ReadLine().Split();

        while (!input[0].Equals("Exit"))
        {
            ParseCommand(input, students);
            input = Console.ReadLine().Split();
        }
    }

    private static void ParseCommand(string[] input, StudentSystem students)
    {
        string command = input[0];

        if (command.Equals("Create"))
        {
            string name = input[1];
            int age = int.Parse(input[2]);
            double grade = double.Parse(input[3]);

            if (!students.Students.ContainsKey(name))
            {
                var student = new Student(name, age, grade);
                students.Students[name] = student;
            }
        }
        else if (command.Equals("Show"))
        {
            string name = input[1];

            if (students.Students.ContainsKey(name))
            {
                var student = students.Students[name];
                string output = $"{student.Name} is {student.Age} years old.";

                if (student.Grade >= 5.00)
                {
                    output += " Excellent student.";
                }
                else if (student.Grade < 5.00 && student.Grade >= 3.50)
                {
                    output += " Average student.";
                }
                else
                {
                    output += " Very nice person.";
                }

                Console.WriteLine(output);
            }
        }
    }
}