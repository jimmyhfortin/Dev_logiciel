using SixLabors.ImageSharp;

namespace ShapesV2;

public class VLine
{
    public Point StartPoint { get; set; }
    public int Height { get; set; }
    public Color DrawColor { get; set; }

    public VLine(Point startPoint, int height, Color drawColor)
    {
        StartPoint = startPoint;
        Height = height;
        DrawColor = drawColor;
    }
    
    public void Draw(Canvas canvas)
    {
        if (StartPoint.X >= 0 && StartPoint.X < canvas.Width)
        {
            for (int j = Math.Max(StartPoint.Y, 0); j < StartPoint.Y + Height && j < canvas.Height; j++)
            {
                canvas.SetPixel(StartPoint.X, j, DrawColor);
            }
        }
    }
}