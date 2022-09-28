namespace Labo3Lib;

public interface IPriorityQueue<T> : IEnumerable<T> where T : IComparable<T>
{
    // Add an element to the priority queue, using their CompareTo method to find its correct location
    // a higher value gives a higher priority
    public void Add(T element);
    // Remove and return the element at the front of the queue
    public T Remove();
    // return the element at the front of the queue (but don't remove it)
    public T Peek();
}