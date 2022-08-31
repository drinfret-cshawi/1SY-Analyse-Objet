using SixLabors.ImageSharp;

namespace ShapesLib;

public class Polygon : Shape
{
    public List<Point> Vertices { get; set; }

    public Polygon(List<Point> vertices, Color drawColor) : base(drawColor)
    {
        this.Vertices = vertices;
    }

    public Polygon(List<Point> vertices)
    {
        this.Vertices = vertices;
    }

    public Polygon(Color drawColor, params Point[] vertices) : base(drawColor)
    {
        this.Vertices = new List<Point>(vertices);
    }

    public Polygon(params Point[] vertices) : this(DefaultDrawColor, vertices)
    {
    }

    public Polygon(Polygon polygon) : this(polygon.Vertices, polygon.DrawColor)
    {
    }

    public override void Draw(Canvas canvas)
    {
        // ligne entre le premier point et le dernier point
        Line line = new Line(Vertices[0], Vertices[Vertices.Count - 1], DrawColor);
        line.Draw(canvas);
        for (int i = 1; i < Vertices.Count; i++)
        {
            line.Start = Vertices[i - 1];
            line.End = Vertices[i];
            line.Draw(canvas);
        }
    }
}