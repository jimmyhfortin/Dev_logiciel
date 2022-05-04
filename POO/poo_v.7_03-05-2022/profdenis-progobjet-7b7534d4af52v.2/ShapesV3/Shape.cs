using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Processing;

namespace ShapesV3;

public abstract class Shape
{
    public static Color DefaultDrawColor { get; set; } = Color.Black;
    public Color DrawColor { get; set; }

    protected Shape(Color drawColor)
    {
        DrawColor = drawColor;
    }
    
    protected Shape() : this(DefaultDrawColor)
    {
    }

    public abstract void Draw(Canvas canvas);
}