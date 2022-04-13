namespace Exercice_3;

public class Dice
{
    //private static Random NbFace = new Random();
    //private static int Face = 
    private int _NbFace;
    private int _DiceValue;
    public int NbFace
    {
        get => _NbFace;
        set
        {
            if (value < 2 || value > 120)
            {
                throw new ArgumentException("The number must be in a range of 2 to 250");
            }
            _NbFace = NbFace;
        }
    }

    public int DiceValue { get; set; }
    /*{
        get => _DiceValue;
        set
        {
            DiceValue = _NbFace;
        }
    }*/

    public Dice(int nbFace)
    {
        _NbFace = nbFace;
        
    }

    public override bool Equals(object? obj)
    {
        return base.Equals(obj);
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }

    public override string ToString()
    {
        return $"Dice {_DiceValue}";
    }

    public void Throw()
    {
        Random diceValue = new Random();
        DiceValue = diceValue.Next(1, this._NbFace);
        Console.WriteLine($"{DiceValue}");
    }
}