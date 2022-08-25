namespace CollegeLib;

public class Student : Person
{
    public int StudentId { get; set; }
    public StudyProgram Program { get; set; }
    public List<CourseOffering> CourseOfferingList { get; set; }
    
    public Student(int id, string name, DateOnly dob, 
        int studentId, StudyProgram program) 
        : base(id, name, dob)
    {
        StudentId = studentId;
        Program = program;
        CourseOfferingList = new List<CourseOffering>();
    }

    public Student(string name, DateOnly dob, 
        int studentId, StudyProgram program) 
        : base(name, dob)
    {
        StudentId = studentId;
        Program = program;
        CourseOfferingList = new List<CourseOffering>();
    }

    public Student(int id, string name, DateOnly dob, 
        int studentId, StudyProgram program, 
        List<CourseOffering> courseOfferingList) 
        : base(id, name, dob)
    {
        StudentId = studentId;
        Program = program;
        CourseOfferingList = courseOfferingList;
    }

    public Student(string name, DateOnly dob, 
        int studentId, StudyProgram program, 
        List<CourseOffering> courseOfferingList) 
        : base(name, dob)
    {
        StudentId = studentId;
        Program = program;
        CourseOfferingList = courseOfferingList;
    }
    
    public Student(int id, string name, DateOnly dob, 
        int studentId, StudyProgram program, 
        params CourseOffering[] courseOfferingArray)
    : base(id, name, dob)
    {
        StudentId = studentId;
        Program = program;
        CourseOfferingList = new List<CourseOffering>(courseOfferingArray);
    }

    public Student(string name, DateOnly dob, 
        int studentId, StudyProgram program, 
        params CourseOffering[] courseOfferingArray) 
        : base(name, dob)
    {
        StudentId = studentId;
        Program = program;
        CourseOfferingList = new List<CourseOffering>(courseOfferingArray);
    }
}