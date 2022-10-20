using CollegeLib;

namespace CollegeDataLib;

public enum SortOrder
{
    Asc,
    Desc
}

public static class Sorting
{
    public static void SortPersonByName(List<Person> data, SortOrder sortOrder = SortOrder.Asc)
    {
        if (sortOrder == SortOrder.Asc)
        {
            data.Sort((x, y) => String.Compare(x.Name, y.Name, StringComparison.Ordinal));    
        }
        else
        {
            data.Sort((x, y) => String.Compare(y.Name, x.Name, StringComparison.Ordinal));
        }
        
    }
}