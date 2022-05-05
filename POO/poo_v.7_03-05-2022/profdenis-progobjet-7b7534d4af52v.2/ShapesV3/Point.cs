using SixLabors.ImageSharp;

namespace ShapesV3;

public class Point : Shape // extension ou sous-class. 
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

   //generate - implement missing members-
   //generate contructor-
    public Point(int x, int y, Color drawColor) : base(drawColor) //base fait reference au constructeur de shapes avec argument color
    {
        X = x;
        Y = y;
    }

    // public Point(int x, int y) : base() // constructeurde shapes sans augument (prend le default color)
    // {
    //     X = x;
    //     Y = y;
    // }

    public Point(int x, int y) : this(x, y, DefaultDrawColor)
    {
    }

    public Point(Point p) : this(p.X, p.Y, p.DrawColor) // constructeur de copie pour creer une copie et appel le contructeur de la class
                                                        // ont pourrais enlever le Drawcolor et il prenderai le contructeur par default sans color.
    {
    }
    
    public override void Draw(Canvas canvas) //Re-définision de la méthode. Ont veux que la méthode soit concrète. Elle est abstract dans la Class parent.
                                                // ont a pas le choix de faire un override sur la methode Draw. 
    {
        canvas.SetPixel(X, Y, DrawColor);
    }
}