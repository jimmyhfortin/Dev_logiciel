namespace ShapesV3;

public class HLine : Shape
{
    public Point StartPoint { get; set; }
    public int Width { get; set; }
    
    public HLine(Point startPoint, int width)
    {
        StartPoint = startPoint;
        Width = width;
    }
    
    public override void Draw(Canvas canvas)
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