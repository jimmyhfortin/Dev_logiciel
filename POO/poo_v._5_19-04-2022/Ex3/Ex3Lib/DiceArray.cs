using System.Data;

namespace Ex3Lib;

public class DiceArray
{
    public Dice[] Array { get; private set; }

    public DiceArray(int length, int nFaces)
    {
        Array = new Dice[length];
        for (int i = 0; i < Array.Length; i++)
        {
            Array[i] = new Dice(nFaces);
        }
    }

    public void Throw()
    {
        foreach (Dice dice in Array)
        {
            dice.Throw();
        }
    }

   
    public int Total()
    {
        int total = 0;
        foreach (Dice dice in Array)
        {
            total += dice.Number;
        }

        return total;
    }

    public int Min()
    {
        int min = Array[0].Number;
        for (int i = 1; i < Array.Length; i++)
        {
            if (Array[i].Number < min)
            {
                min = Array[i].Number;
            }
        }

        return min;
    }

    public int Max()
    {
        int max = Array[0].Number;
        for (int i = 1; i < Array.Length; i++)
        {
            if (Array[i].Number > max)
            {
                max = Array[i].Number;
            }
        }

        return max;
    }
    
    public override string ToString()
    {
        return String.Join<Dice>(" ", Array);
    }
}