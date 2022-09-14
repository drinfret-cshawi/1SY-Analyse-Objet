using ShapesLib;
using SixLabors.ImageSharp;
using Point = ShapesLib.Point;

namespace ShapesApp;

class Program
{
    static void Main(string[] args)
    {
        string docs = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        string imageFile = "shapes.png";
        string filename = Path.Combine(docs, imageFile);

        Canvas canvas = new Canvas(500, 500, Color.White);

        Point p1 = new Point(25, 25);
        List<Shape> shapes = new List<Shape>();
        shapes.Add(new Line(p1, new Point(200, 300), Color.Lime));
        shapes.Add(new HLine(new Point(100, 150), 200, Color.Fuchsia));
        shapes.Add(new VLine(new Point(200, 250), 100, Color.Chartreuse));
        
        shapes.Add(new Polygon(Color.Aqua,
            new Point(50, 50),
            new Point(150, 75),
            new Point(125, 175),
            new Point(444, 266)
        ));
        
        shapes.Add(new Triangle(new Point(100, 100), new Point(150, 150), new Point(125, 250), Color.Gainsboro));
        shapes.Add(new Circle(new Point(200, 200), 150, Color.DarkRed));
        foreach (Shape shape in shapes)
        {
            shape.Draw(canvas);
        }

        // List<Polygon> polygons = new List<Polygon>();
        // polygons.Add(new Polygon());
        //
        // List<Rectangle> rectangles = new List<Rectangle>();
        // rectangles.Add(new Rectangle());
        // rectangles.Add(new Square());
        
        Console.WriteLine($"Writing image in file: {filename}");
        canvas.Save(filename);
    }
}