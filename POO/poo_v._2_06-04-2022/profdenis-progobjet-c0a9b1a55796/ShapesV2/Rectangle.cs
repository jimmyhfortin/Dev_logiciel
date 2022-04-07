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
        HLine v1 = new HLine(StartPoint, Width, DrawColor);
        v1.StartPoint.X = Width+StartPoint.X;
        DrawHLine(canvas, x, y + height - 1, width, color);
        DrawVLine(canvas, x, y, height, color);
        DrawVLine(canvas, x + width - 1, y, height, color);
        
    }
}