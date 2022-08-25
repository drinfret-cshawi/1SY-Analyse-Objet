using CollegeLib;

namespace CollegeApp;

public class Program
{
    static void Main(string[] args)
    {
        Course course1 = new Course("1SY", "Analyse objet");
        Course course2 = new Course("1SS", "Sujets spéciaux");
        Course course3 = new Course("0Q2", "Algorithmes");
        
        StudyProgram prog1 = new StudyProgram("Info1");
        Console.WriteLine(string.Join(" - ", prog1.CourseList));
        
        StudyProgram prog2 = new StudyProgram("Info2", new List<Course>(){course1, course2, course3});
        Console.WriteLine(string.Join(" - ", prog2.CourseList));

        StudyProgram prog3 = new StudyProgram("Info3", course1, course2, course3);
        Console.WriteLine(string.Join(" - ", prog3.CourseList));
    }


}