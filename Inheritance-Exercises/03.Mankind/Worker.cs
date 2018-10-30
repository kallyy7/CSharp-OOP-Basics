namespace _Mankind
{
    using System;
    using System.Text;

    public class Worker : Human
    {
        public Worker(string firstName, string lastName, decimal weekSalary, double worksHoursPerDay) 
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorksHoursPerDay = worksHoursPerDay;
        }

        private decimal weekSalary;
        private double worksHoursPerDay;

        public virtual decimal WeekSalary
        {
            get => this.weekSalary;
            set
            {
                if (value < 10)
                {
                    throw  new ArgumentException("Expected value mismatch! Argument: weekSalary");
                }

                this.weekSalary = value;
            }
        }

        public virtual double WorksHoursPerDay
        {
            get => this.worksHoursPerDay;
            set
            {
                if (value <= 0 || value >= 12)
                {
                    throw new ArgumentException("Expected value mismatch! Argument: workHoursPerDay");
                }

                this.worksHoursPerDay = value;
            }
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            decimal salaryPerHour = this.WeekSalary / (decimal)(this.WorksHoursPerDay * 5); ;

            builder
                .AppendLine(base.ToString())
                .AppendLine($"Week Salary: {this.WeekSalary:f2}")
                .AppendLine($"Hours per day: {this.WorksHoursPerDay:f2}")
                .AppendLine($"Salary per hour: {salaryPerHour:f2}");

            return builder.ToString().TrimEnd();
        }
    }
}
