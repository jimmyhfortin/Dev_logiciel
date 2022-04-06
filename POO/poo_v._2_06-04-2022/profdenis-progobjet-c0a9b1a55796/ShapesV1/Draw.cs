using SixLabors.ImageSharp;

namespace ShapesV1;

public static class Draw
{
    public static void DrawHLine(Canvas canvas, int x, int y, int width, Color color)
    {
        if (y >= 0 && y < canvas.Height)
        {
            for (int i = Math.Max(x, 0); i < x + width && i < canvas.Width; i++)
            {
                canvas.SetPixel(i, y, color);
            }
        }
    }

    public static void DrawVLine(Canvas canvas, int x, int y, int height, Color color)
    {
        //TODO: dessiner un ligne verticale
    }

    public static void DrawLine(Canvas canvas, int x1, int y1, int x2, int y2, Color color)
    {
        //TODO: dessiner une ligne quelconque, du point (x1,y1) au point (x2,y2)
    }

    public static void DrawRectangle(Canvas canvas, int x, int y, int width, int height, Color color)
    {
        //TODO: dessiner un rectangle avec les côtés parallèles aux axes, le point (x,y) est le coin en haut à gauche du rectangle 
    }

    public static void DrawSquare(Canvas canvas, int x, int y, int width, Color color)
    {
        //TODO: dessiner un carré avec les côtés parallèles aux axes, le point (x,y) est le coin en haut à gauche du carré 
    }

    public static void DrawTriangle(Canvas canvas, int x1, int y1, int x2, int y2, int x3, int y3, Color color)
    {
        //TODO: dessiner un triangle, avec les trois sommets (x1,y1), (x2,y2), et (x3,y3)
    }
    
    public static void DrawCircle(Canvas canvas, int x, int y, int radius, Color color)
    {
        //TODO: dessiner un cercle, avec comme centre le point (x,y) 
    }
}