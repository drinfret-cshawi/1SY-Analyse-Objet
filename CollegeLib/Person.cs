namespace CollegeLib;

public class Person : IComparable<Person>
{
    public static int NextId { get; set; } = 1;

    private string _name;
    public int Id { get; set;  }
    public string Name
    {
        get => _name;
        set
        {
            if (value.Length < 2)
            {
                throw new ArgumentException("the name must be at least 2 characters long");
            }
            _name = value;
        }
    }

    public DateOnly Dob { get; set; }

    // pas idéale comme formule, pas très précise
    // public int Age => Convert.ToInt32((DateTime.Today - Dob.ToDateTime(new TimeOnly(0,0))).Days / 365.25);
    public int Age
    {
        get
        {
            DateTime today = DateTime.Today; 
            int age = today.Year - Dob.Year;
            if (today.Month < Dob.Month || today.Month == Dob.Month && today.Day < Dob.Day)
            {
                age--;
            }

            return age;
        }
    }

    public Person(int id, string name, DateOnly dob)
    {
        Id = id;
        Name = name;
        Dob = dob;
    }
    
    public Person(string name, DateOnly dob)
    {
        Id = NextId;
        NextId++;
        Name = name;
        Dob = dob;
    }

    public override bool Equals(object? obj)
    {
        if (obj == null || this.GetType() != obj.GetType())
        {
            return false;
        }

        Person other = (Person)obj;
        // return Name.Equals(other.Name) && Dob.Equals(other.Dob);
        return Id == other.Id;
    }

    public override int GetHashCode()
    {
        // return HashCode.Combine(Name, Dob);
        return Id.GetHashCode();
    }

    public override string ToString()
    {
        return $"Person({Id}, {Name}, {Dob})";
    }

    public int CompareTo(Person? other)
    {
        if (ReferenceEquals(this, other)) return 0;
        if (ReferenceEquals(null, other)) return 1;
        return Id.CompareTo(other.Id);
    }
}