using System.Collections.Generic;

public class StudentSystem
{
    public Dictionary<string, Student> Students { get; private set; }

    public StudentSystem()
    {
        this.Students = new Dictionary<string, Student>();
    }
}