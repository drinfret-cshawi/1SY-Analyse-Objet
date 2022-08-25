namespace CollegeLib;

public class CourseOffering
{
    public int Year { get; set; }
    public string Semester { get; set; }
    public Course Course { get; set; }
    public Teacher? Teacher { get; set; }

    public CourseOffering(int year, string semester, 
        Course course, Teacher? teacher = null)
    {
        Year = year;
        Semester = semester;
        Course = course;
        Teacher = teacher;
    }

    // public CourseOffering(int year, string semester, 
    //     Course course) : this(year, semester, course, null)
    // {
    //     Year = year;
    //     Semester = semester;
    //     Course = course;
    // }
}