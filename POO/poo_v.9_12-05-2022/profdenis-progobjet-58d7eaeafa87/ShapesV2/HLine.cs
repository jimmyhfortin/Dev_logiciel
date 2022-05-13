using SixLabors.ImageSharp;

namespace ShapesV2;

public class HLine
{
    public Point StartPoint { get; set; }
    public int Width { get; set; }
    public Color DrawColor { get; set; }

    public HLine(Point startPoint, int width, Color drawColor)
    {
        StartPoint = startPoint;
        Width = width;
        DrawColor = drawColor;
    }
    
    public void Draw(Canvas canvas)
    {
        if (StartPoint.Y >= 0 && StartPoint.Y < canvas.Height)
        {
            for (int i = Math.Max(StartPoint.X, 0); i < StartPoint.X + Width && i < canvas.Width; i++)
            {
                canvas.SetPixel(i, StartPoint.Y, DrawColor);
            }
        }
    }
}