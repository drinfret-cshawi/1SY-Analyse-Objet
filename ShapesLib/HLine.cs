using SixLabors.ImageSharp;

namespace ShapesLib;

public class HLine : Line
{
    public int Width { get; set; }

    public HLine(Point start, int width, Color drawColor) 
        : base(start, new Point(start.X + width - 1, start.Y), drawColor)
    {
        Width = width;
    }

    public HLine(Point start, int width) : this(start, width, DefaultDrawColor)
    {
    }

    public HLine(HLine hLine) : this(hLine.Start, hLine.Width, hLine.DrawColor)
    {
    }
}