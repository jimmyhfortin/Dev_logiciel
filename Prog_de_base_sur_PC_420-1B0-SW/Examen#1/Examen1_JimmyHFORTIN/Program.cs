using System;

namespace Examen1_JimmyHFORTIN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*//Exercice-1
            
            float chiffre;// declaration de la variable
            Console.WriteLine("Entrez une chiffre : ");//Ecriture du texte dans la console
            chiffre = float.Parse(Console.ReadLine()); // Input de la console
            Console.WriteLine($"{chiffre}   {chiffre}    {chiffre}"); // Affichage du resultat dans la console des donnees entree.
            Console.WriteLine($"{chiffre}        {chiffre}");
            Console.WriteLine($"{chiffre}        {chiffre}");
            Console.WriteLine($"{chiffre}        {chiffre}");
            Console.WriteLine($"{chiffre}   {chiffre}    {chiffre}");*/
            
            
            
            //Exercice-2________________________________________________________________________________________________
            
            /*int Nbdemander; //initialisation de la variable
            Console.Write("Entrez un nombre : "); //ecrirture du texte dans la console
            Nbdemander = int.Parse(Console.ReadLine()); // input de la console
            if (Nbdemander > 0 && Nbdemander <= 20) // condition si le nombre entrer dans la console est plus grand de 0 et plus petit ou egale a 20.
            {
                Console.Write("Le carre de " + Nbdemander + " est "); //ecirture du texte dans la console si la condition est rempli.
                Console.WriteLine(Math.Pow(Nbdemander, 2)); // affichage du resultat avec la formule Math.Pow.
            }
            else if (Nbdemander > 20 && Nbdemander <= 100) // condition si le nombre entrer dans la console est plus grand de 20 et plus petit ou egale a 100. 
            {
                Console.Write("La racine carrée de " + Nbdemander + " est ");//ecirture du texte dans la console si la condition est rempli.
                Console.WriteLine(Math.Sqrt(Nbdemander));// affichage du resultat avec la formule Math.Pow.
            }
            else
            {
                Console.Write("le nombre dépasse 100..."); // condition affichee dans la console si le nombre depasse 100. 
            }*/
            
            
            //Exercice-3________________________________________________________________________________________________

            /*int input; // declaration 
            do // Presente le menu ci-bas
            {
                Console.WriteLine(" 1 - Calcul de la somme de deux nombres entiers."); // menu
                Console.WriteLine(" 2 - Calcule de la facoriel de N (N!)");
                Console.WriteLine(" 3 - Vérifier si un nombre entier A divise un nombre entier B.");
                Console.WriteLine(" 4 - Calcul du quotient et du reste de la division entière de deux nombres entiers A et B.");
                Console.WriteLine(" 5 - Vérifier si un caractère donné est une voyelle (voyelles : 'a', 'e', 'i', 'o', 'u', 'y').");
                Console.WriteLine(" 6 - Permet de permuter (d’échanger) le contenu de deux variables réelles.");
                Console.WriteLine(" 7 - Étant donné un entier A, calcule sa valeur absolue. vous utilisez la fonction Math.Abs(nombre) pour avoir la valeur absolue d'un nombre.");
                
                Console.Write("Entrez votre choix [1 a 7] : "); // Affiche a la console les choix a faire
                input = int.Parse(Console.ReadLine());
                
            }while (input < 0+1 || input >7); // Tantque l'utilisateur ne rentre pas un nombre de 1 a 7 nous redemandons le ''do''

            switch (input) // sctuture de type switch pour les choix fait par l'utilisateur.
            {
                case 1:
                    int  nb1, nb2;
                    Console.WriteLine("Entrez deux nombres entiers : "); 
                    nb1 = int.Parse(Console.ReadLine()); 
                    nb2 = int.Parse(Console.ReadLine());
                    Console.WriteLine($"La somme des deux nombres est {nb1+nb2}"); // addition des deux nombres pour afficher la somme. 
                    break;
                case 2:
                    int input1, facto, i;
                    Console.WriteLine("Entrez un nombre entier : ");
                    input1 = int.Parse(Console.ReadLine());
                    facto = input1;
                    for (i = input1 - 1; i >= 1; i--) // boule for qui decremente 
                    {
                        facto = facto * i; //  calacule de la facto +=
                    }
                    Console.WriteLine($"La factorielle de  {input1}, est {facto}"); // Affiche sur la console le nombre entrer et sa factoriel.
                    break;
                case 3:
                    int nb3, nb4;
                    Console.WriteLine("Entrer deux nombres entiers : ");
                    nb3 = int.Parse(Console.ReadLine());
                    nb4 = int.Parse(Console.ReadLine());
                    if (nb3 % nb4 ==0) // Condition si le nombre divisible ne donne pas de modulo ex:6/3
                    {
                        Console.WriteLine("L'entier A divise un nombre entier B");
                    }
                    else // pour tout le reste qui donne un modulo
                    {
                        Console.WriteLine("L'entier A ne divise pas nombre entier B");
                    }
                    break;
                case 4:
                    int nb5, nb6;
                    Console.WriteLine("Entrer deux nombres entiers : ");
                    nb5 = int.Parse(Console.ReadLine());
                    nb6 = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Le quotient est {nb5 / nb6} et le reste est {nb5 % nb6}"); // Affichage sur la console du quotien et du reste 
                    break;
                case 5: 
                    char lettre;
                    Console.WriteLine("Veuillez entrer une lettre de l'alphabet :");
                    lettre = char.Parse(Console.ReadLine());
                    if (lettre == 'a' || lettre == 'e' || lettre == 'i' || lettre == 'o' || lettre == 'u') //Les majuscule n'ont pas ete demandee. Condition ou logique entre les voyelles
                    {
                        Console.WriteLine(lettre + " est une voyelle");
                    }
                    else // tout les autres cas
                    {
                        Console.WriteLine(lettre + " n'est pas une voyelle");
                    }
                    break;
                case 6:
                    float nba, nbb, tmp;
                    Console.Write("Entrez une varibale a : "); // affichage sur la meme ligne
                    nba = float.Parse(Console.ReadLine());
                    Console.Write("Entrez une varibale b : ");// affichage sur la meme ligne
                    nbb = float.Parse(Console.ReadLine());
                    tmp = nba; // permutation de deux variable de type rellee avec la variable tmp
                    nba = nbb;
                    nbb = tmp;
                    Console.WriteLine($"La valeur de la variable a est : {nba} \nEt celle de la variable b est : {nbb}"); // affichage des valeurs permutee avec saut de ligne.
                    break;
                case 7:
                    int nb7;
                    Console.WriteLine("Entrer un entier : ");
                    nb7 = int.Parse(Console.ReadLine());
                    Console.WriteLine($"La valeur absolue de {nb7} est {Math.Abs(nb7)}"); // affichage de la valeur et la valeur absolu avec la formule donnee. Ex; -4 = Abs 4.
                    break;
                    
                        
            }*/
            
            
            
           






















































































































































        }
    }
}