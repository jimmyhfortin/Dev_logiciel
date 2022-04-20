using System.Data;

namespace Ex3Lib;

public class DiceList
{
    public List<Dice> List { get; private set; }

    public DiceList(int length, int nFaces)
    {
        List = new List<Dice>();
        for (int i = 0; i < length; i++)
        {
            List.Add(new Dice(nFaces));
        }
    }

    public void Throw()
    {
        foreach (Dice dice in List)
        {
            dice.Throw();
        }
    }

   
    public int Total()
    {
        int total = 0;
        foreach (Dice dice in List)
        {
            total += dice.Number;
        }

        return total;
    }

    public int Min()
    {
        int min = List[0].Number;
        for (int i = 1; i < List.Count; i++)
        {
            Dice dice = List[i];
            if (dice.Number < min)
            {
                min = dice.Number;
            }
        }

        return min;
    }

    public int Max()
    {
        int max = List[0].Number;
        for (int i = 1; i < List.Count; i++)
        {
            Dice dice = List[i];
            if (dice.Number > max)
            {
                max = dice.Number;
            }
        }

        return max;
    }
    
    public override string ToString()
    {
        return String.Join<Dice>(" ", List);
    }
}