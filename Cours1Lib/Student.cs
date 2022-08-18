namespace Cours1Lib;

public class Student : Person
{
    public int NoDA { get; set; }

    public Student(int id, string name, int noDa) : base(id, name)
    {
        NoDA = noDa;
    }

    public override string ToString()
    {
        return base.ToString() + $" {NoDA}";
    }
}