﻿namespace _Mankind
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            try
            {
                string[] studentInput = Console.ReadLine().Split();

                string studentFirstName = studentInput[0];
                string studentLastName = studentInput[1];
                string facultyNumber = studentInput[2];

                Student student = new Student(studentFirstName, studentLastName, facultyNumber);

                string[] workerInput = Console.ReadLine().Split();

                string workerFirstName = workerInput[0];
                string workerLastName = workerInput[1];
                decimal weekSalary = decimal.Parse(workerInput[2]);
                double workHours = double.Parse(workerInput[3]);

                Worker worker = new Worker(workerFirstName, workerLastName, weekSalary, workHours);

                Console.WriteLine(student + Environment.NewLine);
                Console.WriteLine(worker);
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
        }
    }
}
