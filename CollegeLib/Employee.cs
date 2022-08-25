namespace CollegeLib;

public class Employee : Person
{
    public int EmployeeId { get; set; }
    public string Department { get; set; }
    public bool IsPermanent { get; set; }

    public Employee(int id, string name, DateOnly dob, int employeeId, string department, bool isPermanent) 
        : base(id, name, dob)
    {
        EmployeeId = employeeId;
        Department = department;
        IsPermanent = isPermanent;
    }

    public Employee(string name, DateOnly dob, int employeeId, string department, bool isPermanent) : base(name, dob)
    {
        EmployeeId = employeeId;
        Department = department;
        IsPermanent = isPermanent;
    }
    
    public override string ToString()
    {
        return $"Employee({Id}, {Name}, {Dob}, {EmployeeId}, {Department}, {IsPermanent})";
    }
}