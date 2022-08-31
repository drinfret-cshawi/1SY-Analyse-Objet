using SixLabors.ImageSharp;

namespace ShapesLib;

public class VLine : Line
{
    public int Height { get; set; }

    public VLine(Point start, int height, Color drawColor)
        : base(start, new Point(start.X, start.Y + height - 1), drawColor)
    {
        Height = height;
    }

    public VLine(Point start, int height) : this(start, height, DefaultDrawColor)
    {
    }

    public VLine(VLine vLine) : this(vLine.Start, vLine.Height, vLine.DrawColor)
    {
    }
}