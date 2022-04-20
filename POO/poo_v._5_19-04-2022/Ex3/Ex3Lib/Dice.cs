namespace Ex3Lib;

public class Dice
{
    private Random _random = new Random();
    public int NFaces { get; }

    public int Number { get; private set; }

    public Dice(int nFaces)
    {
        if (nFaces < 2 || nFaces > 120)
        {
            throw new ArgumentException("The number of faces must be between 2 and 120 inclusive");
        }
        NFaces = nFaces;
        Number = 1;
    }

    public void Throw()
    {
        Number = _random.Next(1, NFaces + 1);
    }

    public override bool Equals(object? obj)
    {
        if (obj == null || this.GetType() != obj.GetType())
        {
            return false;
        }

        Dice other = (Dice)obj;
        return NFaces == other.NFaces && Number == other.Number;
        // return Number.GetHashCode(); // Optionel
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(NFaces, Number);
    }

    public override string ToString()
    {
        if (NFaces == 6)
        {
            char c = (char) (Number - 1 + '\u2680'); // \u=encodage d'une valeur unicode (hexdecimal)
            return c.ToString(); // Ont retroune un toString
        }
        return Number.ToString();
    }
}