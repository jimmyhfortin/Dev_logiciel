using SixLabors.ImageSharp;

namespace ShapesV2;

public class Carre
{
    public Point StartPoint { get; set; }
    public int width { get; set; }
    public Color Drawcolor { get; set; }

    public Carre(Point startPoint, int width, Color drawcolor)
    {
        StartPoint = startPoint;
        this.width = width;
        Drawcolor = drawcolor;
    }
    public void Draw(Canvas canvas)
    {
        Rectangle carre = new Rectangle(StartPoint, width, height:width, Drawcolor);
        carre.Draw(canvas);
    }
}