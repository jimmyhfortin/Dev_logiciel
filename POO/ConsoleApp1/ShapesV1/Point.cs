namespace ShapesV1;

public class Point
{
    //ATTRIBUT
    private int _x; // controller les attribut que lon va mettre dans les valeurs.(encapsulation)
    private int _y;
    //public int x;
    //public int y;
    


    public Point(int x, int y)
    {
        //this.x = x; // refere a l'objet (this) l'objet qu'on est en train de creer (class Point)
        //this.y = y;
        _x = x;
        _y = y;
    }

    public override string ToString() // override= redefinir comment cest fait par defaut (namespace) Concole.Write va appeler le Tostring et faire cette sortie la
    {
        return $"({_x},{_y})"; // la sortie ici qui est redefinie 
    }
}

// ont va definri des classe et re definir des methode. (ogjet = donne + methode(private/public)(constructeur))