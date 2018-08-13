namespace _04.FirstAndReserveTeam
{
    public class Person
    {
        private string firstName;

        private string lastName;

        private int age;

        private decimal salary;

        public Person()
        {
        }

        public Person(string firstName, string lastName, int age, decimal salary)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Salary = salary;
        }

        public string FirstName
        {
            get => this.firstName;
            private set
            {
                if (value.Length < 3)
                {
                    throw new System.ArgumentException("First name cannot contain fewer than 3 symbols!");
                }

                this.firstName = value;
            }
        }

        public string LastName
        {
            get => this.lastName;
            private set
            {
                if (value.Length < 3)
                {
                    throw new System.ArgumentException("Last name cannot contain fewer than 3 symbols!");
                }

                this.lastName = value;
            }
        }

        public int Age
        {
            get => this.age;
            private set
            {
                if (value <= 0)
                {
                    throw new System.ArgumentException("Age cannot be zero or a negative integer!");
                }

                this.age = value;
            }
        }

        public decimal Salary
        {
            get => this.salary;
            private set
            {
                if (value <= 460.0m)
                {
                    throw new System.ArgumentException("Salary cannot be less than 460 leva!");
                }

                this.salary = value;
            }
        }

        public void IncreaseSalary(decimal bonus)
        {
            if (this.age > 30)
            {
                this.salary += this.salary * bonus / 100;
            }
            else
            {
                this.salary += this.salary * bonus / 200;
            }
        }

        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName} receives {this.salary:f2} leva.";
        }
    }
}
