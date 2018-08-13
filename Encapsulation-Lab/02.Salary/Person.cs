namespace _02.Salary
{
    public class Person
    {
        private string firstName;

        private string lastName;

        private int age;

        private decimal salary;

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
            set => firstName = value;
        }

        public string LastName
        {
            get => this.lastName;
            set => lastName = value;
        }

        public int Age
        {
            get => this.age;
            set => age = value;
        }

        public decimal Salary
        {
            get => this.salary;
            set => salary = value;
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