namespace CollegeLib;

public class Course
{
    public string Code { get; set; }
    public string Name { get; set; }

    public Course(string code, string name)
    {
        Code = code;
        Name = name;
    }

    public override string ToString()
    {
        return $"{Code}: {Name}";
    }
}