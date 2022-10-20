using CollegeDataLib;

namespace CollegeLibDataTest;

public class MockPersonRepoTests

{
    private readonly MockPersonRepo _mock;

    public MockPersonRepoTests()
    {
        _mock = new MockPersonRepo();
    }

    [Fact]
    public void SelectTest()
    {
        var actual = _mock.Select();
        Assert.Equal(4, actual.Count);
    }

    [Fact]
    public void SelectByIdTest()
    {
        var actual = _mock.Select(2);
        Assert.Equal("Denis", actual?.Name);

        actual = _mock.Select(4);
        Assert.Equal("Bob", actual?.Name);

        actual = _mock.Select(0);
        Assert.Null(actual);

        actual = _mock.Select(-1);
        Assert.Null(actual);
    }

    [Fact]
    public void InsertTest()
    {
        Assert.Equal(4, _mock.Count);
        
        Assert.Throws<ArgumentException>(
            () => _mock.Insert(new(-1, "Abc", DateOnly.Parse("1900-01-09"))));
        Assert.Equal(4, _mock.Count);
        
        Assert.Throws<ArgumentException>(
            () => _mock.Insert(new(1, "Abc", DateOnly.Parse("1900-01-09"))));
        Assert.Equal(4, _mock.Count);
        
        Assert.Equal(5, _mock.Insert(new(0, "Zxc", DateOnly.Parse("1910-10-10"))));
        Assert.Equal(5, _mock.Count);
        
        Assert.Equal(8, _mock.Insert(new(8, "Asd", DateOnly.Parse("1912-12-12"))));
        Assert.Equal(6, _mock.Count);
    }
    
    [Fact]
    public void UpdateTest()
    {
        Assert.Equal(4, _mock.Count);

        Assert.False(_mock.Update(new(0, "Zxc", DateOnly.Parse("1910-10-10"))));
        Assert.Equal(4, _mock.Count);
        
        Assert.True(_mock.Update(new(1, "Asd", DateOnly.Parse("1912-12-12"))));
        Assert.Equal(4, _mock.Count);
        var person = _mock.Select(1);
        Assert.Equal(1, person?.Id);
        Assert.Equal("Asd", person?.Name);
        Assert.Equal(DateOnly.Parse("1912-12-12"), person?.Dob);
    }
    
    [Fact]
    public void DeleteTest()
    {
        Assert.Equal(4, _mock.Count);

        Assert.False(_mock.Delete(0));
        Assert.Equal(4, _mock.Count);
        Assert.False(_mock.Delete(5));
        Assert.Equal(4, _mock.Count);
        Assert.True(_mock.Delete(1));
        Assert.Equal(3, _mock.Count);
    }
}