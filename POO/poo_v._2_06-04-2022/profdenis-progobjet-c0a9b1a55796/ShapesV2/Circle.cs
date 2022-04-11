using SixLabors.ImageSharp;

namespace ShapesV2;

public class Circle
{
    public Point Startpoint { get; set; }
    public int Radius { get; set; }
    public Color Drawcolor { get; set; }

    public Circle(Point startpoint, int radius, Color drawcolor)
    {
        Startpoint = startpoint;
        Radius = radius;
        Drawcolor = drawcolor;
    }

    public void Draw(Canvas canvas)
    {
        int cos45 = Convert.ToInt32(Math.Round(Radius * Math.Cos(Math.PI/4), MidpointRounding.AwayFromZero));        
                                                                                                                     
        for (int i = 0; i <= cos45; i++)                                                                             
        {                                                                                                            
            int j = Convert.ToInt32(Math.Round(Math.Sqrt(Radius * Radius - i * i), MidpointRounding.AwayFromZero));  
            canvas.SetPixel(Startpoint.X+i, Startpoint.Y+j, Drawcolor); // point 1                                                             
            canvas.SetPixel(Startpoint.X-i, Startpoint.Y+j, Drawcolor); // point 2: symétrie du point 1 par rapport à l'axe Y                  
                                                                                                                     
            canvas.SetPixel(Startpoint.X+i, Startpoint.Y-j, Drawcolor); // point 3: symétrie du point 1 par rapport à l'axe X                  
            canvas.SetPixel(Startpoint.X-i, Startpoint.Y-j, Drawcolor); // point 4: symétrie du point 3 par rapport à l'axe Y                  
                                                                                                                     
            canvas.SetPixel(Startpoint.X+j, Startpoint.Y+i, Drawcolor); // point 5: symétrie du point 1 par rapport à la diagonale 45°         
            canvas.SetPixel(Startpoint.X+j, Startpoint.Y-i, Drawcolor); // point 6: symétrie du point 5 par rapport à l'axe X                  
                                                                                                                     
            canvas.SetPixel(Startpoint.X-j, Startpoint.Y+i, Drawcolor); // point 7: symétrie du point 5 par rapport à l'axe Y                  
            canvas.SetPixel(Startpoint.X-j, Startpoint.Y-i, Drawcolor); // point 8: symétrie du point 7 par rapport à l'axe X                  
        }                                                                                                            
    }
}