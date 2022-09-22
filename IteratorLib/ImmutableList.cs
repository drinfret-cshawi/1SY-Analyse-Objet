using System.Collections;

namespace IteratorLib;

public class ImmutableList<T> : IEnumerable<T>
{
    private readonly List<T> _data;

    public ImmutableList()
    {
        _data = new List<T>();
    }

    public void Add(T element)
    {
        _data.Add(element);
    }

    public T this[int i] => _data[i];

    public static ImmutableList<T> operator +(ImmutableList<T> a, ImmutableList<T> b)
    {
        ImmutableList<T> temp = new ImmutableList<T>();
        foreach (T x in a)
        {
            temp.Add(x);
        }
        foreach (T x in b)
        {
            temp.Add(x);
        }

        return temp;
    }

    public override string ToString()
    {
        return string.Join(", ", _data);
    }

    public IEnumerator<T> GetEnumerator()
    {
        return new Iterator(this);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public class Iterator : IEnumerator<T>
    {
        private readonly ImmutableList<T> _list;
        private int _current;

        public Iterator(ImmutableList<T> list)
        {
            _list = list;
            _current = -1;
        }

        public T Next()
        {
            return _list._data[_current++];
        }

        public bool Done()
        {
            return _current >= _list._data.Count;
        }

        public bool MoveNext()
        {
            _current++;
            return _current < _list._data.Count;
        }

        public void Reset()
        {
            _current = -1;
        }

        public T Current => _list[_current];

        object IEnumerator.Current => Current;

        public void Dispose()
        {
        }
    }
}