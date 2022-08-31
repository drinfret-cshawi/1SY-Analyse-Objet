using SixLabors.ImageSharp;

namespace ShapesLib;

public class Line : Shape
{
    public Point Start { get; set; }
    public Point End { get; set; }

    public Line(Point start, Point end, Color drawColor) : base(drawColor)
    {
        Start = start;
        End = end;
    }

    public Line(Point start, Point end)
    {
        Start = start;
        End = end;
    }

    public Line(Line line) : this(line.Start, line.End, line.DrawColor)
    {
    }

    public override void Draw(Canvas canvas)
    {
        // ligne verticale, il faut éviter une division par 0
        if (Start.X == End.X)
        {
            Point temp = new Point(Start.X, Math.Min(Start.Y, End.Y));
            int height = Math.Abs(End.Y - Start.Y) + 1;

            if (temp.X >= 0 && temp.X < canvas.Width)
            {
                for (int j = Math.Max(temp.Y, 0); j < temp.Y + height && j < canvas.Height; j++)
                {
                    canvas.SetPixel(temp.X, j, DrawColor);
                }
            }

            return;
        }

        // il faut éviter une division int/int qui nous donnerais une très grande imprécision dans le calcul de y
        // double m = (y2 - (double)y1) / (x2 - x1);
        // double m = (y2 - y1 + 0.0) / (x2 - x1);
        double m = Convert.ToDouble(End.Y - Start.Y) / (End.X - Start.X);
        double b = End.Y - m * End.X;

        // si la ligne est plus près d'une ligne horizontale que verticale, on fait la boucle sur les x
        // if (x2 - x1 > y2 - y1)
        if (Math.Abs(m) < 1)
        {
            int minX = Math.Min(Start.X, End.X);
            int maxX = Math.Max(Start.X, End.X);

            for (int x = minX; x <= maxX; x++)
            {
                int y = Convert.ToInt32(Math.Round(m * x + b, MidpointRounding.AwayFromZero));
                canvas.SetPixel(x, y, DrawColor);
            }
        }
        else // si la ligne est plus près d'une ligne verticale que horizontale, on fait la boucle sur les y
        {
            int minY = Math.Min(Start.Y, End.Y);
            int maxY = Math.Max(Start.Y, End.Y);

            for (int y = minY; y <= maxY; y++)
            {
                int x = Convert.ToInt32(Math.Round((y - b) / m, MidpointRounding.AwayFromZero));
                canvas.SetPixel(x, y, DrawColor);
            }
        }
    }
}