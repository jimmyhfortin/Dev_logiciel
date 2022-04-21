using SixLabors.ImageSharp;

namespace ShapesV2;

public class Triangle
{
    public Point Point1 { get; set; }
    public Point Point2 { get; set; }
    public Point Point3 { get; set; }
    public Color DrawColor { get; set; }

    public Triangle(Point point1, Point point2, Point point3, Color drawColor)
    {
        Point1 = point1;
        Point2 = point2;
        Point3 = point3;
        DrawColor = drawColor;
    }

    public void Draw(Canvas canvas)
    {
        Line line = new Line(Point1, Point2, DrawColor);
        line.Draw(canvas);
        line.EndPoint = Point3;
        line.Draw(canvas);
        line.StartPoint = Point2;
        line.Draw(canvas);
    }
}