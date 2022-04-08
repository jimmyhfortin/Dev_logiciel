using SixLabors.ImageSharp;

namespace ShapesV2;

public class Line
{
    public Point StartPoint { get; set; }
    public Point EndPoint { get; set; }
    public Color DrawColor { get; set; }
    

    public Line(Point startPoint, Point endPoint, Color drawColor)
    {
        StartPoint = startPoint;
        EndPoint = endPoint;
        DrawColor = drawColor;
    }

    /*public void Draw(Canvas canvas)
    {
        VLine line = new VLine(StartPoint, Math.Abs(EndPoint.Y-StartPoint.Y), DrawColor);
        // ligne verticale, il faut éviter une division par 0
        if (StartPoint.X == EndPoint.X)
        {
            
            //DrawVLine(canvas, x1, Math.Min(y1, y2), Math.Abs(y2 - y1) + 1, color);
            return;
        }

        // il faut éviter une division int/int qui nous donnerais une très grande imprécision dans le calcul de y
        // double m = (y2 - (double)y1) / (x2 - x1);
        // double m = (y2 - y1 + 0.0) / (x2 - x1);
        double m = Convert.ToDouble(y2 - y1) / (x2 - x1);
        double b = y2 - m * x2;

        // si la ligne est plus près d'une ligne horizontale que verticale, on fait la boucle sur les x
        // if (x2 - x1 > y2 - y1)
        if (Math.Abs(m) < 1)
        {
            int minX = Math.Min(x1, x2);
            int maxX = Math.Max(x1, x2);

            for (int x = minX; x <= maxX; x++)
            {
                int y = Convert.ToInt32(Math.Round(m * x + b, MidpointRounding.AwayFromZero));
                canvas.SetPixel(x, y, color);
            }
        }
    }*/
}