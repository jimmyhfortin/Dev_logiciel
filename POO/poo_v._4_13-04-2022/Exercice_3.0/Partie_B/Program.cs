using DiceLib;

namespace Partie_B
{
    public class Program
    {
        static void Main(string[] args)
        {
            Dice[] dice = new Dice[5];
            dice[0] = new Dice(10);
            dice[1] = new Dice(20);
            dice[2] = new Dice(40);
            dice[3] = new Dice(60);
            dice[4] = new Dice(110);

            for (int i = 0; i < dice.Length; i++)
            {
                dice[i].Throw();
            }

            for (int i = 0; i < dice.Length; i++)
            {
                Console.WriteLine(dice[i].DiceValue);
            }

            var diceListe = new List<Dice>();
            diceListe.Add(new Dice(10));
            diceListe.Add(new Dice(20));
            diceListe.Add(new Dice(40));
            diceListe.Add(new Dice(60));
            diceListe.Add(new Dice(110));

            foreach (var dicel in diceListe)
            {
                dicel.Throw();
            }

            foreach (var diceli in diceListe)
            {
                Console.WriteLine(diceli);
            }


        }

    }
}    