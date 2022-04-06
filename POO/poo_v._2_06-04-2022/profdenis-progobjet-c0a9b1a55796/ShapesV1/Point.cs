namespace ShapesV1;

public class Point1
{
    public int x;
    public int y;

    public Point1(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    public override string ToString()
    {
        return $"({this.x}, {this.y})";
    }
}

public class Point2
{
    public int X { get; set; }
    public int Y { get; set; }

    public Point2(int x, int y)
    {
        X = x;
        Y = y;
    }

    public override string ToString()
    {
        return $"({X}, {Y})";
    }
}

public class Point3
{
    public int X { get; set; }
    public int Y { get; set; }

    public Point3(int x, int y)
    {
        X = x;
        Y = y;
    }

    public override string ToString()
    {
        return $"({X}, {Y})";
    }

    public int Length()
    {
        double length = Math.Sqrt(X * X + Y * Y);
        return (int)Math.Round(length);
    }
}

public class Point
{
    private int _x;
    private int _y;

    public int X
    {
        get => _x;
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("X cannot be negative");
            }

            _x = value;
        }
    }

    public int Y
    {
        get => _y;
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Y cannot be negative");
            }

            _y = value;
        }
    }

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    public Point(Point other) : this(other.X, other.Y)
    {
    }

    public override string ToString()
    {
        return $"({X}, {Y})";
    }

    public int Length()
    {
        double length = Math.Sqrt(X * X + Y * Y);
        return (int)Math.Round(length, MidpointRounding.AwayFromZero);
    }

    public void ScaleX(double factor)
    {
        X = (int)Math.Round(X * factor, MidpointRounding.AwayFromZero);
    }

    public void ScaleY(double factor)
    {
        Y = (int)Math.Round(Y * factor, MidpointRounding.AwayFromZero);
    }

    public void Scale(double factor)
    {
        ScaleX(factor);
        ScaleY(factor);
    }

    public Point MidPoint()
    {
        Point temp = new Point(this);
        temp.Scale(0.5);
        return temp;
    }
}