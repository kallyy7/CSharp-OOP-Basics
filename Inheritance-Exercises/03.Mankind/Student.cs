namespace _Mankind
{
    using System;
    using System.Text;

    public class Student : Human
    {
        public Student(string firstName, string lastName, string facultyNumber)
            : base(firstName, lastName)
        {
            this.FacultyNumber = facultyNumber;
        }

        private string facultyNumber;

        public string FacultyNumber
        {
            get => this.facultyNumber;
            set
            {
                if (value.Length < 5 || value.Length > 10)
                {
                    throw  new ArgumentException("Invalid faculty number!");
                }

                this.facultyNumber = value;
            }
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            builder
                .AppendLine(base.ToString())
                .AppendLine($"Faculty number: {this.FacultyNumber}");

            return builder.ToString().TrimEnd();
        }
    }
}
