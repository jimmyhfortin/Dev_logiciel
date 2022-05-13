using SixLabors.ImageSharp;

namespace ShapesV2;

public class Point
{
    public static Color DefaultDrawColor => Color.Black;
    
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

    public Color DrawColor { get; set; }

    public Point(int x, int y) : this(x, y, DefaultDrawColor)
    {
    }

    public Point(int x, int y, Color drawColor)
    {
        X = x;
        Y = y;
        DrawColor = drawColor;
    }

    public Point(Point other) : this(other.X, other.Y, other.DrawColor)
    {
    }
    
    public override bool Equals(object? obj)
    {
        if (obj == null || GetType() != obj.GetType())
        {
            return false;
        }
    
        Point other = (Point)obj;
        return X == other.X && Y == other.Y && DrawColor == other.DrawColor;
    }
    
    
    public override int GetHashCode()
    {
        return HashCode.Combine(X, Y, DrawColor);
    }

    public override string ToString()
    {
        return $"({X}, {Y})";
    }

    public int Length()
    {
        double length = Math.Sqrt(X * X + Y * Y);
        // return length;
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

    public void Draw(Canvas canvas)
    {
        // canvas[X, Y] = DrawColor;
        canvas.SetPixel(X, Y, DrawColor);
    }
}