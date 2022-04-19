namespace DiceLib;
using DiceLib;
public class ArrayListe
{

    public Dice[] ArrayDice(int num)
    {
        Random rand = new Random();
        Dice[] diceArray = new Dice[num];
        for (int i = 0; i < diceArray.Length; i++)
        {
            diceArray[i] = new Dice(rand.Next(1,120));
        }
        /*diceArray[0] = new Dice(10); //If we do not want a random number of face
        diceArray[1] = new Dice(20);
        diceArray[2] = new Dice(40);
        diceArray[3] = new Dice(60);
        diceArray[4] = new Dice(110);*/
        for (int i = 0; i < diceArray.Length; i++)
        {
            diceArray[i].Throw();
            Console.WriteLine($"Value of {num} Dice array {diceArray[i].DiceValue}"); //Optional
        }

        //return ArrayDice(num);
        return diceArray;
    }

    public void SumArray(Dice[] diceArray)
    {
        int arrayvalue = 0;
        for (int i = 0; i < diceArray.Length; i++)
        {
            arrayvalue = diceArray[i].DiceValue;
        }
        Console.WriteLine($"Sum of the {diceArray} equal {arrayvalue}"); // optional
    }

    public void MaxValue(Dice[] diceArray)
    {
        int tmp = 0;
        for (int i = 0; i < diceArray.Length; i++)
        {
            if (diceArray[i].DiceValue > tmp)
            {
                tmp = i;
                if (diceArray[i].DiceValue > tmp)
                {
                    
                }
            }
        }
    }


}