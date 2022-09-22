namespace IteratorLib;

public class SimpleCollection<T> : ICollection<T>
{
    protected List<T> Elements { get; set; }

    public SimpleCollection()
    {
        Elements = new List<T>();
    }

    public IIterator<T> CreateIterator()
    {
        return new Iterator(this);
    }

    public void Add(T element)
    {
        Elements.Add(element);
    }
    
    class Iterator : IIterator<T>
    {
        private readonly SimpleCollection<T> _collection;
        private int _current = 0;

        public Iterator(SimpleCollection<T> collection)
        {
            _collection = collection;
        }

        public T Next()
        {
            return _collection.Elements[_current++];
        }

        public bool Done()
        {
            return _current >= _collection.Elements.Count;
        }
    }
}
