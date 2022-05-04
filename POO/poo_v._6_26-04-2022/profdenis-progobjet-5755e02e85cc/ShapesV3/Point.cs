using SixLabors.ImageSharp;

namespace ShapesV3;

public class Point : Shape // sa veux dire que c'est une extension ou sous Class. Autre language c'est Extend.
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
    
    public Point(int x, int y,Color drawColor) : base(drawColor)  // construteur de shapes avec argument color (base)
    {
        _x = x;
        _y = y;
    }

    public Point(int x, int y)
    {
        _x = x;
        _y = y;
    }

    public Point(Point p) : this(p.X, p.Y, p.DrawColor)
    {
        
    }
    
    public override void Draw(Canvas canvas) //Re-définision de la méthode. Ont veux que la méthode soit concrète. Elle est abstract dans la Class parent.
    {
        canvas.SetPixel(X, Y, DrawColor);
    }

    public int Length()
    {
        double length = Math.Sqrt(X * X + Y * Y);
        // return length;
        return (int)Math.Round(length, MidpointRounding.AwayFromZero);
    }

    
}