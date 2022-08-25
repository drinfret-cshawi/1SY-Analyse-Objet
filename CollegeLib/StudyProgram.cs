
namespace CollegeLib;

public class StudyProgram
{
    public string Name { get; set; }
    public List<Course> CourseList { get; set; }

    public StudyProgram(string name)
    {
        Name = name;
        CourseList = new List<Course>();
    }
    
    public StudyProgram(string name, List<Course> courseList)
    {
        Name = name;
        CourseList = courseList;
    }

    public StudyProgram(string name, params Course[] courseArray)
    {
        Name = name;
        CourseList = new List<Course>(courseArray);
    }
    

}