using System.Drawing;
using SixLabors.ImageSharp;

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

public class Point //celle-ci
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

    public Point(int x, int y) // constructeur il a le meme nom
    {
        X = x; // maj comme le get set pour avoir une validation sur les nombres entrees.
        Y = y;
    }

    public Point(Point other) : this(other.X, other.Y) // deuxieme constructeur, constrcuteur de copie Point other
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

    public void ScaleX(double factor) // va modifier un point (c'est une mise a l'echelle).
    {
        X = (int)Math.Round(X * factor, MidpointRounding.AwayFromZero);
    }

    public void ScaleY(double factor)
    {
        Y = (int)Math.Round(Y * factor, MidpointRounding.AwayFromZero);
    }

    public void Scale(double factor) // methode qui appel d'autre methode
    {
        ScaleX(factor);
        ScaleY(factor);
    }

    public Point MidPoint() // creer un nouveau point comme le point millieu
    {
        Point temp = new Point(this); // nouveau point qui copie les valeurs
        temp.Scale(0.5);
        return temp;
    }

    /*public void Draw(Canvas canvas)
    {
        canvas.SetPixel(X, Y, Color.Blue);
    }*/
}