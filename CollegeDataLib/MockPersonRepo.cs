using CollegeLib;

namespace CollegeDataLib;

public class MockPersonRepo : IDataRepo<Person, int>
{
    private readonly List<Person> _persons;
    public int Count => _persons.Count;
    
    public MockPersonRepo()
    {
        _persons = new List<Person>()
        {
            new(1,"Catherine", DateOnly.Parse("2002-02-02")),
            new(2,"Denis", DateOnly.Parse("2000-01-01")),
            new(3,"Alice", DateOnly.Parse("2012-12-12")),
            new(4,"Bob", DateOnly.Parse("1999-09-09"))
        };
    }

    public List<Person> Select()
    {
        return _persons;
    }

    public Person? Select(int id)
    {
        return _persons.Find(p => p.Id == id);
    }

    public int Insert(Person data)
    {
        if (data.Id < 0)
        {
            throw new ArgumentException("Id cannot be negative.");
        }

        if (data.Id > 0)
        {
            if (_persons.Contains(data))
            {
                throw new ArgumentException("Duplicate Id. Cannot insert.");
            }
            

        }
        else // data.Id == 0
        {
            var max = _persons.Select(p => p.Id).Max();
            data.Id = max + 1;
        }

        _persons.Add(data);
        return data.Id;
    }

    public bool Update(Person data)
    {
        for (int i = 0; i < _persons.Count; i++)
        {
            if (_persons[i].Equals(data))
            {
                _persons[i] = data;
                return true;
            }
        }

        return false;
    }

    public bool Delete(Person data)
    {
        return Delete(data.Id);
    }

    public bool Delete(int key)
    {
        for (int i = 0; i < _persons.Count; i++)
        {
            if (_persons[i].Id == key)
            {
                _persons.RemoveAt(i);
                return true;
            }
        }

        return false;
    }
}