namespace _01.SortPersonsByNameAndAge
{
    public class Person
    {
        private string firstName;

        private string lastName;

        private int age;

        public Person(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
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

        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName} is {this.Age} years old.";
        }
    }
}