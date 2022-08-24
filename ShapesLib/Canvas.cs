using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Formats.Png;
using SixLabors.ImageSharp.PixelFormats;

namespace ShapesLib
{
    public class Canvas
    {
        public static int DefaultWidth => 100;
        public static int DefaultHeight => 100;
        public static Color DefaultBackgroundColor => Color.Black;

        public int Width { get; }
        public int Height { get; }
        public Color BackgroundColor { get; set; }
        public Image<Rgb24> Image { get; }

        public Color this[int x, int y]
        {
            get => GetPixel(x, y);
            set => SetPixel(x, y, value);
        }

        public Canvas() : this(DefaultWidth, DefaultHeight, DefaultBackgroundColor)
        {
        }

        public Canvas(int width) : this(width, width, DefaultBackgroundColor)
        {
        }

        public Canvas(int width, int height) : this(width, height, DefaultBackgroundColor)
        {
        }


        public Canvas(int width, int height, Color backgroundColor)
        {
            Width = width;
            Height = height;
            BackgroundColor = backgroundColor;
            Image = new Image<Rgb24>(width, height);
            Clear(BackgroundColor);
        }

        public void Clear(Color clearColor)
        {
            for (int i = 0; i < Width; i++)
            {
                for (int j = 0; j < Height; j++)
                {
                    Image[i, j] = clearColor;
                }
            }
        }

        public Color GetPixel(int x, int y)
        {
            if (x >= 0 && x < this.Width && y >= 0 && y < this.Height)
            {
                return Image[x, y];
            }
            // throw exception?
            return BackgroundColor;
        }

        public void SetPixel(int x, int y, Color drawColor)
        {
            if (x >= 0 && x < this.Width && y >= 0 && y < this.Height)
            {
                this.Image[x, y] = drawColor;
            }
        }

        public void Save(string filename)
        {
            this.Image.Save(filename, new PngEncoder());
        }
    }
}