namespace Cours1Lib;

public class Person
{
    private string _name;
    public int Id { get; private set; }
    public string Name { get => _name;
        set
        {
            _name = value;
        }
    }

    // public Person(string name, int id)
    // {
    //     _name = name;
    //     Id = id;
    // }
    public Person(int id, string name)
    {
        Name = name;
        Id = id;
    }

    public override bool Equals(object? obj)
    {
        if (obj is Person person)
        {
            return this.Id == person.Id && this.Name == person.Name;
        }
        return false;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Id, Name);
    }

    public override string ToString()
    {
        return $"({Id}) {Name}";
    }
}