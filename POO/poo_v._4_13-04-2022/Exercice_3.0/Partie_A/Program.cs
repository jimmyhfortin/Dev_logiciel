using DiceLib;
namespace Partie_A
{
    public class Program
    {
        static void Main(string[] args)
        {
            int choix;
            Dice dice5 = new Dice(5);
            Dice dice32 = new Dice(32);
            Dice dice105 = new Dice(105);
            while (true)
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("-----------------------------------------------------------");
                    Console.WriteLine($"-------Bienvenu a comment de dé voulez-vous jouer---------");
                    Console.WriteLine($"Vous pouvez choisir un nombre de face sur le dé (choix[1])");
                    Console.WriteLine($"----Ou vous pouvez choisir un dé deja crée (choix[2])-----");
                    Console.WriteLine("-----------------------------------------------------------");
                    Console.WriteLine("---------Si vous-voulez quitter faite le (choix[3])--------");
                    Console.WriteLine("-----------------------------------------------------------");
                    choix = int.Parse(Console.ReadLine());
                } while (choix != 1 && choix != 2 && choix != 3);

                if (choix == 3) break;
                if (choix == 1)
                {
                    Console.Clear();
                    Console.WriteLine("----------------------------------------------------------");
                    Console.WriteLine($"-Choisisser un nombre de face que vous desirez sur le dé-");
                    Console.WriteLine("----------------------------------------------------------");
                    choix = int.Parse(Console.ReadLine());
                    Dice dice2 = new Dice(choix);
                    dice2.Throw();
                    
                }
                else if (choix == 2)
                {
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("----------------------------------------------------------");
                        Console.WriteLine($"---------------Faite votre choix de dé-------------------");
                        Console.WriteLine("------------Dé a 5 faces faite le choix [1]---------------");
                        Console.WriteLine("------------Dé a 32 faces faite le choix [2]--------------");
                        Console.WriteLine("-----------Dé a 105 faces faite le choix [3]--------------");
                        Console.WriteLine("----------------------------------------------------------");
                        choix = int.Parse(Console.ReadLine());
                    } while (choix != 1 && choix != 2 && choix != 3);
                    
                }
                switch (choix)
                {
                    case 1:
                        dice5.Throw();
                        break;
                    case 2:
                        dice32.Throw();
                        break;
                    case 3:
                        dice105.Throw();
                        break;
                }

                Console.Clear();
                Console.WriteLine("----------------------------------------------------------");
                Console.WriteLine("--------Essayer de deviner le resultat obtenu-------------");
                Console.WriteLine("----------------------------------------------------------");

                while (true)
                {
                    choix = int.Parse(Console.ReadLine());
                    if (choix == dice5.DiceValue || choix == dice32.DiceValue || choix == dice105.DiceValue)
                    {
                        Console.Clear();
                        Console.WriteLine("---------------Felecitation !--------------------");
                        break;
                    }
                    else if (choix < dice5.DiceValue || choix < dice32.DiceValue || choix < dice105.DiceValue)
                    {
                        Console.Clear();
                        Console.WriteLine("-----------------Plus haut !----------------------");
                        
                    }
                    else if (choix > dice5.DiceValue || choix > dice32.DiceValue || choix > dice105.DiceValue)
                    {
                        Console.Clear();
                        Console.WriteLine("-----------------Plus bas !----------------------");
                    }

                        
                }
            }

            
        }
    }
}