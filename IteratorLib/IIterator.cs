namespace IteratorLib;

public interface IIterator<T>
{
    public T Next();
    public bool Done();
}