using SixLabors.ImageSharp;

namespace ShapesV2;

public class Rectangle
{
    public Point StartPoint { get; set; }
    
    public int Width { get; set; }
    public int Height { get; set; }
    public Color DrawColor { get; set; }

    public Rectangle(Point startPoint, int width, int height, Color drawColor)
    {
        StartPoint = startPoint;
        Width = width;
        Height = height;
        DrawColor = drawColor;
    }

    public void Draw(Canvas canvas)
    {
        HLine h1 = new HLine(StartPoint, Width, DrawColor);
        VLine v1 = new VLine(StartPoint, Height, DrawColor);
        h1.Draw(canvas);
        v1.Draw(canvas);
        h1.StartPoint.Y = Height+StartPoint.Y;
        h1.Draw(canvas);
        v1.StartPoint.X = StartPoint.X+Width;
        v1.StartPoint.Y = StartPoint.Y - Height;
        v1.Draw(canvas);
        
        
    }
}