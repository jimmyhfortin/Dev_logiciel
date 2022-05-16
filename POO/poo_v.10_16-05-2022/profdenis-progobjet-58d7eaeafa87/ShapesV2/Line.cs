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

    public void Draw(Canvas canvas)
    {
        // ligne verticale, il faut éviter une division par 0
        if (StartPoint.X == EndPoint.X)
        {
            Point temp = new Point(StartPoint.X, Math.Min(StartPoint.Y, EndPoint.Y));
            int height = Math.Abs(EndPoint.Y - StartPoint.Y) + 1;
            VLine vLine = new VLine(temp, height, DrawColor);
            vLine.Draw(canvas);
            // DrawVLine(canvas, StartPoint.X, Math.Min(StartPoint.Y, EndPoint.Y), 
            //     Math.Abs(EndPoint.Y - StartPoint.Y) + 1, color);
            return;
        }

        // il faut éviter une division int/int qui nous donnerais une très grande imprécision dans le calcul de y
        // double m = (y2 - (double)y1) / (x2 - x1);
        // double m = (y2 - y1 + 0.0) / (x2 - x1);
        double m = Convert.ToDouble(EndPoint.Y - StartPoint.Y) / (EndPoint.X - StartPoint.X);
        double b = EndPoint.Y - m * EndPoint.X;

        // si la ligne est plus près d'une ligne horizontale que verticale, on fait la boucle sur les x
        // if (x2 - x1 > y2 - y1)
        if (Math.Abs(m) < 1)
        {
            int minX = Math.Min(StartPoint.X, EndPoint.X);
            int maxX = Math.Max(StartPoint.X, EndPoint.X);

            for (int x = minX; x <= maxX; x++)
            {
                int y = Convert.ToInt32(Math.Round(m * x + b, MidpointRounding.AwayFromZero));
                canvas.SetPixel(x, y, DrawColor);
            }
        }
        else // si la ligne est plus près d'une ligne verticale que horizontale, on fait la boucle sur les y
        {
            int minY = Math.Min(StartPoint.Y, EndPoint.Y);
            int maxY = Math.Max(StartPoint.Y, EndPoint.Y);

            for (int y = minY; y <= maxY; y++)
            {
                int x = Convert.ToInt32(Math.Round((y - b) / m, MidpointRounding.AwayFromZero));
                canvas.SetPixel(x, y, DrawColor);
            }
        }
    }
}