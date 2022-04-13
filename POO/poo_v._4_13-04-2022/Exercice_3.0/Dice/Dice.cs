namespace Exercice_3;

public class Dice
{
    private int _NbFace;
    public int NbFace
    {
        get => _NbFace;
        private set
        {
            if (value < 2 || value > 120)
            {
                throw new ArgumentException("The number must be in a range of 2 to 250");
            }
            _NbFace = value;
        }
    }

    public int DiceValue { get; private set; }
    

    public Dice(int nbFace)
    {
        NbFace = nbFace;
        
    }

    public override bool Equals(object? obj)
    {
        if (obj == null || this.GetType() != obj.GetType())
        {
            return false;
        }

        Dice other = (Dice) obj;
        return NbFace.Equals(other.NbFace) && DiceValue.Equals(other.DiceValue);
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }

    public override string ToString()
    {
        if (NbFace == 6)
        {
            return $"\u2685";
        }
        return $"Dice {DiceValue}";
    }

    public void Throw()
    {
        Random rand = new Random();
        DiceValue = rand.Next(1, NbFace+1);
        Console.WriteLine($"{DiceValue}");
    }
}