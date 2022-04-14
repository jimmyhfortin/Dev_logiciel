using Exercice_3;


namespace Exercice_3
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            var Array5Dice = new Dice[5];
            Array5Dice[0] = new Dice(5);
            Array5Dice[1] = new Dice(18);
            Array5Dice[2] = new Dice(32);
            Array5Dice[3] = new Dice(64);
            Array5Dice[4] = new Dice(105);
            int choix;
            
            
            Dice dice1 = new Dice(90);
            Console.WriteLine(dice1.NbFace);
            dice1.Throw();
            do
            {
                Console.WriteLine($"Bienvenu a comment de dee voulez-vous jouer");
                Console.WriteLine($"Vous pouvez choisir un nombre de face sur le dee (choix #1)\nOu vous pouvez choisir un dee deja cree (choix #2)");
                choix = int.Parse(Console.ReadLine());
            } while (choix != 1 && choix != 2);

            if (choix == 1)
            {
                Console.WriteLine($"Choisisse un nombre de face que vous desirez sur le dee");
                choix = int.Parse(Console.ReadLine());
                Dice dice2 = new Dice(choix);
                dice2.Throw();
            }
            else
            {
                Console.WriteLine($"Faite votre choix de dee");
                for (int i = 0; i < Array5Dice.Length; i++)
                {
                    Console.Write($"Dee #{i+1}, ");
                    Console.WriteLine($"{Array5Dice[i].NbFace} face");
                    choix = int.Parse(Console.ReadLine());
                }

                choix = int.Parse(Console.ReadLine());
                //Array5Dice[] = choix;
            }










        }
    }
}