public class Student
{
    private string name;
    private int age;
    private double grade;

    public double Grade
    {
        get => grade;
        set => grade = value;
    }

    public int Age
    {
        get => age;
        set => age = value;
    }

    public string Name
    {
        get => name;
        set => name = value;
    }

    public Student(string name, int age, double grade)
    {
        this.Name = name;
        this.Age = age;
        this.grade = grade;
    }
}