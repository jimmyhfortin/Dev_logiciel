using SixLabors.ImageSharp;

namespace ShapesV1;

public class Draw
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
        if (x >= 0 && x < canvas.Height)
        {
            for (int i = Math.Max(y, 0); i < y + height && i < canvas.Height; i++)
            {
                canvas.SetPixel(x, i, color);
            }
        }
    }

    public static void DrawLine(Canvas canvas, int x1, int y1, int x2, int y2, Color color)
    {
        //TODO: dessiner une ligne quelconque, du point (x1,y1) au point (x2,y2) /peux etre en angle.jim
        //boucle sur les x de x1 a x2 y=mx+b x=valeur de i (m*i+b) m=(y2-y1)/(x2-x1) b=(y-mx) soit b=(y2-mx2)set pixel(i,m*ib, couleur)
        //boucle sur les y de y1 a y2
        if (x1 - x2 != 0)
        {
            double m = ((y2 + 0.00) - y1) / (x2 - x1);
            double b = y2 - m * x2;
            for (int i = Math.Max(x1, 0); i < x2  && i < canvas.Width; i++)
            {
                canvas.SetPixel(i, Convert.ToInt32(m * i + b), color);
            }  
        }
        //else if (x1 - x2 !=0 && x1 + y1 > ?) Je ne comprend pas comment trouver la valeur qui fait boucler sur les y
        else
        {
            Console.WriteLine($"DrawLine: Veuillez entrer une valeur positive");
        }
        
    }

    public static void DrawRectangle(Canvas canvas, int x, int y, int width, int height, Color color)
    {
        //TODO: dessiner un rectangle avec les côtés parallèles aux axes, le point (x,y) est le coin en haut à gauche du rectangle 
        DrawHLine(canvas, x, y, width, color);
        DrawHLine(canvas, x, y+height, width, color);
        DrawVLine(canvas, x, y, height, color);
        DrawVLine(canvas, x+width, y, height, color);
    }

    public static void DrawSquare(Canvas canvas, int x, int y, int width, Color color)
    {
        //TODO: dessiner un carré avec les côtés parallèles aux axes, le point (x,y) est le coin en haut à gauche du carré 
        //appel drawRectangle
        DrawRectangle(canvas, x, y, width, width, color);
    }

    public static void DrawTriangle(Canvas canvas, int x1, int y1, int x2, int y2, int x3, int y3, Color color)
    {
        //TODO: dessiner un triangle, avec les trois sommets (x1,y1), (x2,y2), et (x3,y3)
        //DrawLigne appel 
        //DrawLinge(canevas,x2,y2,x3,y3,dessin) plusiseur comme cela
        DrawLine(canvas, x1 ,y1 ,x2 , y2, color);
        DrawLine(canvas, x2 ,y2 ,x3 , y3, color);
        DrawLine(canvas, x3 ,y3 ,x1 , y1, color);
    }
    
    public static void DrawCircle(Canvas canvas, int x, int y, int radius, Color color)
    {
        //TODO: dessiner un cercle, avec comme centre le point (x,y) 
    }
}