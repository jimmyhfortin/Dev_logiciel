using Ex3Lib;

namespace Ex3App2;

public class Program
{

    static void Main(string[] args)
    {
        // tableaux
        Console.WriteLine("Tableaux");
        Dice[] diceArray = new Dice[] { new Dice(6), new Dice(6), new Dice(6) };
        foreach (Dice dice in diceArray)
        {
            dice.Throw();
        }
        Console.WriteLine(String.Join<Dice>(" ",  diceArray));
        //fin .1
        DiceArray array = new DiceArray(3, 6);
        array.Throw();
        Console.WriteLine(array);
        Console.WriteLine($"Total = {array.Total()}");
        Console.WriteLine($"Min = {array.Min()}");
        Console.WriteLine($"Max = {array.Max()}");
        
        // listes
        Console.WriteLine("Listes");
        List<Dice> diceList = new List<Dice> { new Dice(12), new Dice(12), new Dice(12) };
        foreach (Dice dice in diceList)
        {
            dice.Throw();
        }
        Console.WriteLine(String.Join<Dice>(" ",  diceList));

        DiceList list = new DiceList(3, 12);
        list.Throw();
        Console.WriteLine(list);
        Console.WriteLine($"Total = {list.Total()}");
        Console.WriteLine($"Min = {list.Min()}");
        Console.WriteLine($"Max = {list.Max()}");
    }
}