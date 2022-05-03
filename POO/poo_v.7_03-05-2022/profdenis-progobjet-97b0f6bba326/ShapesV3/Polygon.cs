using SixLabors.ImageSharp;

namespace ShapesV3;

public class Polygon : Shape
{
    public List<Point> Vertices;

    public Polygon(List<Point> vertices, Color drawColor) : base(drawColor)
    {
        this.Vertices = vertices;
    }

    public Polygon(List<Point> vertices)
    {
        this.Vertices = vertices;
    }

    public Polygon(Color drawColor, params Point[] vertices) : base(drawColor)
    {
        this.Vertices = new List<Point>(vertices);
    }

    public Polygon(params Point[] vertices) : this(DefaultDrawColor, vertices)
    {
    }

    public Polygon(Polygon polygon) : this(polygon.Vertices, polygon.DrawColor)
    {
    }

    public override void Draw(Canvas canvas)
    {
        Line line = new Line(Vertices[0], Vertices[^1], DrawColor);
        line.Draw(canvas);
        for (var i = 1; i < Vertices.Count; i++)
        {
            line.Start = Vertices[i - 1];
            line.End = Vertices[i];
            line.Draw(canvas);
        }
    }
}