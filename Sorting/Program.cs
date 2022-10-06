namespace Sorting;

class Program
{
    static int CompareIntInverse(int x, int y)
    {
        return y.CompareTo(x);
    }

    static void Main(string[] args)
    {
        List<int> liste1 = new List<int>() { 4, 2, 8, 5, 1 };

        Console.WriteLine($"liste 1 = [{string.Join(", ", liste1)}]");
        liste1.Sort();
        Console.WriteLine($"liste 1 triée (ordre : defaut) = [{string.Join(", ", liste1)}]");

        Console.WriteLine("Comparaison : avec fonction =>");
        liste1.Sort((x, y) => y.CompareTo(x));
        Console.WriteLine($"liste 1 triée (ordre : inverse) = [{string.Join(", ", liste1)}]");

        Console.WriteLine("Comparaison : avec méthode statique");
        liste1.Sort(CompareIntInverse);
        Console.WriteLine($"liste 1 triée (ordre : inverse) = [{string.Join(", ", liste1)}]");

        Console.WriteLine("Comparaison : avec Comparer<int>.Default");
        liste1.Sort(Comparer<int>.Default);
        Console.WriteLine($"liste 1 triée (ordre : default) = [{string.Join(", ", liste1)}]");

        Console.WriteLine("Comparaison : avec Comparer<int>.Create()");
        var comp = Comparer<int>.Create((x, y) => y.CompareTo(x));
        liste1.Sort(comp);
        Console.WriteLine($"liste 1 triée (ordre : inverse) = [{string.Join(", ", liste1)}]");

        Console.WriteLine("Comparaison : avec IComparer<int>");
        liste1.Sort(new InverseIntComparer());
        Console.WriteLine($"liste 1 triée (ordre : inverse) = [{string.Join(", ", liste1)}]");

        var liste2 = new List<Point>() { new(4, 1), new(2, 6), new(6, 2), new(2, 3) };

        Console.WriteLine($"\n\nliste 2 = [{string.Join(", ", liste2)}]");
        liste2.Sort();
        Console.WriteLine($"liste 2 triée (ordre : defaut) = [{string.Join(", ", liste2)}]");
        
        Console.WriteLine("Comparaison : avec fonction =>");
        liste2.Sort((x, y) => y.CompareTo(x));
        Console.WriteLine($"liste 2 triée (ordre : inverse) = [{string.Join(", ", liste2)}]");
        
        Console.WriteLine("Comparaison : avec fonction =>");
        liste2.Sort((x, y) => x.Length.CompareTo(y.Length));
        Console.WriteLine($"liste 2 triée (ordre : longueur ASC) = [{string.Join(", ", liste2)}]");
        
        Console.WriteLine("Comparaison : avec Comparer<Point>.Default");
        liste2.Sort(Comparer<Point>.Default);
        Console.WriteLine($"liste 2 triée (ordre : default) = [{string.Join(", ", liste2)}]");
        
        Console.WriteLine("Comparaison : avec IComparer<Point>");
        liste2.Sort(new Point.InverseLengthComparer());
        Console.WriteLine($"liste 2 triée (ordre : longueur DESC) = [{string.Join(", ", liste2)}]");
    }

    class InverseIntComparer : IComparer<int>
    {
        public int Compare(int x, int y)
        {
            return y.CompareTo(x);
        }
    }

    public struct Point : IComparable<Point>
    {
        public double X { get; set; }
        public double Y { get; set; }

        public double Length => Math.Sqrt(X * X + Y * Y);
        
        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }
        
        public int CompareTo(Point other)
        {
            var xComparison = X.CompareTo(other.X);
            if (xComparison != 0) return xComparison;
            return Y.CompareTo(other.Y);
        }

        public override string ToString()
        {
            return $"({X}, {Y})";
        }

        public class InverseLengthComparer : IComparer<Point>
        {
            public int Compare(Point x, Point y)
            {
                return y.Length.CompareTo(x.Length);
            }
        }
    }
}