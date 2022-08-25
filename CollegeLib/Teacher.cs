namespace CollegeLib;

public class Teacher : Employee
{
    public string Title { get; set; }

    public Teacher(int id, string name, DateOnly dob, 
        int employeeId, string department, bool isPermanent, 
        string title) 
        : base(id, name, dob, employeeId, department, isPermanent)
    {
        Title = title;
    }

    public Teacher(string name, DateOnly dob, int employeeId, 
        string department, bool isPermanent, string title) 
        : base(name, dob, employeeId, department, isPermanent)
    {
        Title = title;
    }
}