namespace IteratorApp;

using IteratorLib;

class Program
{
    static void Main(string[] args)
    {
        ICollection<int> col = new SimpleCollection<int>();
        col.Add(5);
        col.Add(2);
        col.Add(8);
        IIterator<int> iter = col.CreateIterator();
        while (!iter.Done())
        {
            Console.WriteLine(iter.Next());
        }

        Console.WriteLine("------------------------");

        ImmutableList<int> list = new ImmutableList<int>();
        list.Add(5);
        list.Add(2);
        list.Add(8);
        using (IEnumerator<int> iter2 = list.GetEnumerator())
        {
            while (iter2.MoveNext())
            {
                Console.WriteLine(iter2.Current);
            }
        }

        Console.WriteLine("------------------------");
        
        foreach (int x in list)
        {
            Console.WriteLine(x);
        }

        // list[1] = -5;
        Console.WriteLine("------------------------");

        Console.WriteLine($"All pos : {list.All(x => x >= 0)}");
        Console.WriteLine($"Any neg : {list.Any(x => x < 0)}");
        Console.WriteLine("Adding -5");
        list.Add(-5);
        Console.WriteLine($"All pos : {list.All(x => x >= 0)}");
        Console.WriteLine($"Any neg : {list.Any(x => x < 0)}");
        Console.WriteLine($"All neg : {list.All(x => x < 0)}");
        Console.WriteLine($"Any pos : {list.Any(x => x >= 0)}");

        Console.WriteLine("LINQ");
        IEnumerable<int> query =
            from x in list
            where x < 0
            select -x;
        Console.Write("Query with foreach : ");
        foreach (int x in query)
        {
            Console.WriteLine(x);
        }

        Console.Write("Full list with string.Join : ");
        Console.WriteLine(string.Join(", ", list));
        Console.Write("Query with string.Join : ");
        Console.WriteLine(string.Join(", ", query));
        
        Console.Write("Query with function notation and string.Join: ");
        Console.WriteLine(string.Join(", ", list.Where(x => x < 0).Select(x => -x)));
        
        Console.WriteLine("------------------------");
        ImmutableList<int> list2 = new ImmutableList<int>();
        list2.Add(12);
        list2.Add(22);
        list2.Add(20);
        Console.Write("List 1 : ");
        Console.WriteLine(list);
        Console.Write("List 2 : ");
        Console.WriteLine(list2);
        Console.Write("List concatenation with + : ");
        Console.WriteLine(list + list2);

        ImmutableList<int> list3 = list;
        list3 += list2;
        Console.Write("List concatenation with += : ");
        Console.WriteLine(list3);

        Console.Write("Original list : ");
        Console.WriteLine(list);
    }
}