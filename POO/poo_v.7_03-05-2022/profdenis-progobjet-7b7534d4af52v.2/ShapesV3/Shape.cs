using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Processing;

namespace ShapesV3;

public abstract class Shape // abstract car une methode est defini en abectratc ce qui rend la Class abstract. quand abstract ont peux pas faire new shapes
{
    public static Color DefaultDrawColor { get; set; } = Color.Black; //met une couleur par default. 
    public Color DrawColor { get; set; }

    protected Shape(Color drawColor) // protected = methode apperler juste par les sous-classe
    {
        DrawColor = drawColor;
    }
    
    protected Shape() : this(DefaultDrawColor) //constructeur par default (car il prend aucun argument) (si ont ne donne pas de couleur il en prend celui par deafault)
    {
    }

    public abstract void Draw(Canvas canvas); // abstract car va etre defini dans les sous-classe
}