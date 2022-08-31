using SixLabors.ImageSharp;

namespace ShapesLib;

public class Point : Shape
{
    private int _x;
    private int _y;

    public int X
    {
        get => _x;
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("X cannot be negative");
            }

            _x = value;
        }
    }

    public int Y
    {
        get => _y;
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Y cannot be negative");
            }

            _y = value;
        }
    }

    public Point(int x, int y, Color drawColor) : base(drawColor)
    {
        X = x;
        Y = y;
    }

    // public Point(int x, int y) : base()
    // {
    //     X = x;
    //     Y = y;
    // }

    public Point(int x, int y) : this(x, y, DefaultDrawColor)
    {
    }

    public Point(Point p) : this(p.X, p.Y, p.DrawColor)
    {
    }
    
    public override void Draw(Canvas canvas)
    {
        canvas.SetPixel(X, Y, DrawColor);
    }
}