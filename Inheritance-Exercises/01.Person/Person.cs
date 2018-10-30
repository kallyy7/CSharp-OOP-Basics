﻿namespace _Person
{
    using System;
    using System.Text;

    public class Person
    {
        private string name;
        private int age;

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public virtual string Name
        {
            get => name;
            private set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Name's length should not be less than 3 symbols!");
                }

                name = value;
            }
        }

        public virtual int Age
        {
            get => age;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Age must be positive!");
                }

                age = value;
            }
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            builder.Append($"Name: {this.Name}, Age: {this.Age}");

            return builder.ToString();
        }

    }
}
