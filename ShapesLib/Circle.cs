using SixLabors.ImageSharp;

namespace ShapesLib;

public class Circle : Shape
{
    public Point Centre { get; set; }
    public int Radius { get; set; }
    public Color DrawColor { get; set; }

    public Circle(Point centre, int radius, Color drawColor)
    {
        Centre = centre;
        Radius = radius;
        DrawColor = drawColor;
    }

    public override void Draw(Canvas canvas)
    {
        int cos45 = Convert.ToInt32(Math.Round(Radius * Math.Cos(Math.PI/4), MidpointRounding.AwayFromZero));
        
        for (int i = 0; i <= cos45; i++)
        {
            int j = Convert.ToInt32(Math.Round(Math.Sqrt(Radius * Radius - i * i), MidpointRounding.AwayFromZero));
            canvas.SetPixel(Centre.X+i, Centre.Y+j, DrawColor); // point 1
            canvas.SetPixel(Centre.X-i, Centre.Y+j, DrawColor); // point 2: symétrie du point 1 par rapport à l'axe Y 
            
            canvas.SetPixel(Centre.X+i, Centre.Y-j, DrawColor); // point 3: symétrie du point 1 par rapport à l'axe X
            canvas.SetPixel(Centre.X-i, Centre.Y-j, DrawColor); // point 4: symétrie du point 3 par rapport à l'axe Y
            
            canvas.SetPixel(Centre.X+j, Centre.Y+i, DrawColor); // point 5: symétrie du point 1 par rapport à la diagonale 45°
            canvas.SetPixel(Centre.X+j, Centre.Y-i, DrawColor); // point 6: symétrie du point 5 par rapport à l'axe X
            
            canvas.SetPixel(Centre.X-j, Centre.Y+i, DrawColor); // point 7: symétrie du point 5 par rapport à l'axe Y
            canvas.SetPixel(Centre.X-j, Centre.Y-i, DrawColor); // point 8: symétrie du point 7 par rapport à l'axe X
        }
    }
}