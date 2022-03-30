using System;
using System.Transactions;
using Project;

namespace Machine_bonbon 
{
    internal class Program
    {
        public static Candy[] LoadCandies() // Classe de type structuree. Type Candy.
        {
            Candy[] candies; //Declaration tableau candies[] de type Candy
            Data dataManager = new Data(); // Declaration de la variable dataManager de type Data avec affectation de la memoire.
            candies = dataManager.LoadCandies(); // Affectation des valeurs de la fonction LoadCandies() a la variable candies.
            return candies; // La fonction retourne le tableau candies avec les donnees de Data.cs
        }
        public static int GetSelection(int input=25) // Fonction GetSelection qui prend en parametre une variable de type int 
        {
            while (true) // tant que la condition est vrai elle va boucler.
            {
                Console.Write("->"); // Affichage sous Board.print. 
                input = int.Parse(Console.ReadLine()); // Nous donnons la mains.
                if (input <= 0 || input > 26) // Condition si l'utilisateur entre un choix qui n'est pas entre 1 et 25.
                {
                    Console.WriteLine("Entrer une selection entre 1 & 25 "); // Si la condition n'est pas respecte ont affiche ce message et ont reboucle car la condition est vrai
                }
                else // Si la condition d'entrer des nombres de 1 a 25 est respecte ont break; la condition while.
                {
                    break; // si l'utilisateur a entre un nombre entre 1 et 25 l'instruction break; nous fait sortir de la condition. 
                }
        
            }
            Board.Print(selection:input); // ont affiche le Board avec la fonction .Print avec les donnees que l'utilisateur a saisis.
            return input-1; // Nous retournons le choix de l'utilisateur avec -1 car sur un tableau la premiere case est [0]. (Nous allons nous servir de cette valeur pour indiquer la case du tableau).
        }
        public static Candy GetCandy(int input, Candy[] candies) // Fonction GetCandy prend en parametres le choix fait par l'utilisateur et le tableau precedament cree candies[] de type Candy. 
        {
            return candies[input]; // Fonction qui retourne seulement les donnees du tableau candies dependament du choix fait par l'utilisateur. 
        }
        public static decimal GetCoin(int input, int select, Candy bonbon, decimal sommeRecu) // Fonction GetCoin qui prend en parametres la selection fait dans le choix de 1 a 5(input), la selection du bonbon(select), 
        {                                                                                     //le bonbon (bonbon) et la sommes des choix en decimal(sommeRecu).
            do // Structure de condiiton do while pour recommencer si le choix fait par l'utilisateur n'est pas valide selon les conditions du while. 
            {
                Console.Write($"[0] = Annuler\n[1] = 5c\n[2] = 10c\n[3] = 25c\n[4] = 1$\n[5] = 2$\n->"); // Affiche le menu en bas du Board.Print
                input = int.Parse(Console.ReadLine()); // Nous donnons la mains.
                Board.Print(bonbon.Name, select+1, bonbon.Price, received:sommeRecu); // Affichage du Bord.Print avec les arguments des parametre de la fonction.
            } while ((input < 0 || input > 5) && bonbon.Stock > 0); // Tant que l'utilisateur n'entre pas un nombre entre 0 et 5 et que le bonbon est en stock ont re-boucle.
            switch(input)// structure de type switch qui retoune la choix fait entre 0 et 5. (1 a 5 en decimal) (0 en int) convertion implicite.
            {
                case 0:
                    return 0;
                case 1:
                    return 0.05m;
                case 2:
                    return 0.10m;
                case 3:
                    return 0.25m;
                case 4:
                    return 1.00m;
                case 5:
                    return 2.00m;
            }
            return input;
        }
        static void Main(string[] args)
        {
            Candy[] candies = LoadCandies(); //Declaration avec affectation d'un tableau de type Candy qui contient tous les donnees des bonbons fichier.data dans le main.
            while (true) // Condition toujours vraie pour garder la machine toujour en fonction. 
            {
                Board.Print(); // Respect du visuel attendu #1 Entree sans parametres cette fonction affiche la machine 
                int select = GetSelection(); // Declaration avec affectation a la variable select le retour de la fonction GetSelect
                Candy bonbon = GetCandy(select, candies); // Declaration avec affectation des donnees retoune de le la fonction GetCandy a la varible bonbon. Avec ses arguments. 
                while (bonbon.Stock >= 0) // Condition pour valider si les bonbon sont en stock dans les donnes du le fichier .data (que l'on va decrementer plus loin).
                {
                    if (bonbon.Stock == 0) // Condition si les stock sont a 0.
                    {
                        Board.Print(message:candies[select].Name + " VIDE", select+1); // Ont affiche le message VIDE avec la selection ainsi que le prix.
                        select = GetSelection(); // Nous redemandons a l'usager de refaire un choix valide
                        bonbon = GetCandy(select, candies); // re-affectation des donnees retounee de le la fonction GetCandy a la varible bonbon. si valide ont tombre dans le else sinon ont reboucle j'usqua ce que l'utilsateur fasse un choix en stock.
                        
                    }
                    else // Si bonbon en stock.
                    {
                        Board.Print(candies[select].Name, select+1, bonbon.Price);// Ont affiche le nom, la selection et le prix. Respect du visuel attendu #2
                        break; // Ont sort de la boucle.
                    }
                }
                decimal coin, sommeRecu=0; //Declaration de la variable coin, delcaration avec affectation de la varaible sommeRecu toute deux de type decimal que nous aurons besoin.
                int input=0; // Declaration avec affection d'une variable de type int que nous avons benoins pour la passer en parametre a notre fonction.
                while (true) // Condition toujours vrai.
                {
                    coin = GetCoin(input, select, bonbon, sommeRecu); // affecation de la valeur de retour de la fonction GetCoin avec ses arguments. 
                    sommeRecu = sommeRecu + coin; // Addition de la valeur coin a la varaible sommeRecu. Respect du visuel attendu #3
                    Board.Print(candies[select].Name, select+1, bonbon.Price, received:sommeRecu, returned:(sommeRecu-bonbon.Price)); //Affichage du Board avec ses parametres et en plus le montant retoune.
                    if (coin == 0) // Condition si l'utilisateur entre 0 comme nombre.
                    {
                        Board.Print(message:"ANNULEE", select+1, bonbon.Price, received:sommeRecu, returned:sommeRecu); // Nous lui retournerons les montants entrees. 
                        break; // ont sort de la condition et ont re-boucle avec le while (true) qui englobe tout le main. 
                    }
                    else if (sommeRecu < bonbon.Price) // Si la sommeRecu est plus petite le prix ont affiche et Board et ont recommance le while (true) j'usqu'a ce que le montant soit >= au prix.
                    {
                        Board.Print(candies[select].Name, select+1, bonbon.Price, received:sommeRecu); // Affichage du Board. avec le montant entree. 
                    }
                    else if (sommeRecu >= bonbon.Price) // Quand la sommeRecu est >= au prix ont affiche le Board. avec le message PRENNEZ VOTRE FRIANDISE... ainsi que le monnaie de retour et le bonbon choisi en relult. 
                    {
                        Board.Print("PRENNEZ VOTRE FRIANDISE...", select+1, bonbon.Price, received:sommeRecu, returned:(sommeRecu-bonbon.Price), result:candies[select].Name); // Respect du visuel attendu #4.
                        bonbon.Stock--; // Nous decrementon notre stock en lien avec le fichier .data
                        break; // instruction break; qui nous fait sortir de la boucle while
                    }
        
                }
                Console.WriteLine("Appuyer sur une touche pour recommencer"); // Apres la boucle while pour la fonction GetCoin ont affiche ce message.
                Console.ReadKey(); // Fonction .ReadKey pour recommencer la boucle du main. 
            }
            
            
            
        }
    }
}