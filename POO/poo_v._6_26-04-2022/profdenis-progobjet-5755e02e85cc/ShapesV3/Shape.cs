using SixLabors.ImageSharp;

namespace ShapesV3;

public abstract class Shape
{
    public static Color DefaultDrawColor { get; set; } = Color.Black; //Quand souligner dans diagrame = static
    public Color DrawColor { get; set; }

    protected Shape(Color drawColor)
    {
        DrawColor = drawColor;
    }
    
    protected Shape() : this(DefaultDrawColor) //constructeur par default (car il prend aucun argument) (si ont ne donne pas de couleur il en prend celui par deafault)
    {
    }

    public abstract void Draw(Canvas canvas); // signature de la methode (premiere ligne de la methode)
}