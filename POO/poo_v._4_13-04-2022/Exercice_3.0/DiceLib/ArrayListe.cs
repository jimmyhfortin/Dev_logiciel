namespace DiceLib;
using DiceLib;
public class ArrayListe
{

    public void ArrayDice(int num)
    {
        Random rand = new Random();
        Dice[] diceArray = new Dice[num];
        for (int i = 0; i < diceArray.Length; i++)
        {
            diceArray[i] = new Dice(rand.Next(1,120));
        }
        /*diceArray[0] = new Dice(10);
        diceArray[1] = new Dice(20);
        diceArray[2] = new Dice(40);
        diceArray[3] = new Dice(60);
        diceArray[4] = new Dice(110);*/
        for (int i = 0; i < diceArray.Length; i++)
        {
            diceArray[i].Throw();
            Console.WriteLine(diceArray[i].DiceValue);
        }
        
    }

    
}