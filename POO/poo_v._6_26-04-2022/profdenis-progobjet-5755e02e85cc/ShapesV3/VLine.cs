using SixLabors.ImageSharp;

namespace ShapesV3;

public class VLine : Shape
{
    public Point Start { get; set; }
    public int Height { get; set; }

    public VLine(Point start, int height,Color drawColor) : base(drawColor) // construteur de shapes avec argument color
    {
        Start = start;
        Height = height;
    }

    public VLine(Point start, int height) // constructeur de shapes sans arguement (prend le default color)
    {
        Start = start;
        Height = height;
    }

    public VLine(VLine vLine) : this(vLine.Start, vLine.Height) // constructeur de copie pour creer une copie et appel le contructeur avant
    {
        
    }

    public override void Draw(Canvas canvas)
    {
        if (Start.X >= 0 && Start.X < canvas.Width)
        {
            for (int j = Math.Max(Start.Y, 0); j < Start.Y + Height && j < canvas.Height; j++)
            {
                canvas.SetPixel(Start.X, j, DrawColor);
            }
        }
    }
}