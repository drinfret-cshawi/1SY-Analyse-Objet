namespace CollegeDataLib;

public interface IDataRepo<TData, TKey>
{
    public List<TData> Select();
    public TData? Select(TKey key);
    public TKey? Insert(TData data);
    public bool Update(TData data);
    public bool Delete(TData data);
    public bool Delete(TKey key);
}