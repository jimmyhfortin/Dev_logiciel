namespace ShapesV3;

public class Point : Shape
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
    
    public override void Draw(Canvas canvas)
    {
        canvas.SetPixel(X, Y, DrawColor);
    }
}