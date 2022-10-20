namespace CollegeDataLib;

public class MockDataSource : IDataSource
{
    public bool Connect()
    {
        return true;
    }

    public void Close()
    {
    }
}