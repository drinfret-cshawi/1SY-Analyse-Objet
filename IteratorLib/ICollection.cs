namespace IteratorLib;

public interface ICollection<T>
{
    public IIterator<T> CreateIterator();
    public void Add(T element);
}