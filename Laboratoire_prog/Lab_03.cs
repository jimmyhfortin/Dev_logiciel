
//Lab_03_______________________________________________________________________________________________________________

//Ex_01
/*Écrire un programme C# avec une boucle « do... while » et un « switch » qui demande à
l’utilisateur un nombre compris entre 1 et 3 jusqu’à ce que la réponse convienne. Il affiche
"Ajouter une note" pour le choix 1, "Modifier une note" pour le choix 2 et "Supprimer une
note" pour le choix 3.*/

/*byte input;
do
{
    Console.WriteLine("Faite votre choix de menu [1, 2 ou 3] :");
    input = byte.Parse(Console.ReadLine());
} while (input < 0 || input > 3);

switch (input)
{
    case 1:
        Console.WriteLine("Ajoute une note");
        break;
    case 2:
        Console.WriteLine("Modifier une note");
        break;
    case 3:
        Console.WriteLine("Supprime une note");
        break;
}*/

//Ex_ 02
/*Écrire un programme C# qui demande un nombre compris entre 10 et 20, jusqu’à ce que la
réponse convienne. En cas de réponse supérieure à 20, on fera apparaître un message : « Plus
petit ! », et inversement, « Plus grand ! » si le nombre est inférieur à 10.*/

/*
int input;
do
{
    Console.WriteLine("Entrer un nombre entre 10 et 20 inclusivement :");
    input = byte.Parse(Console.ReadLine());
    if (input > 20)
    {
        Console.WriteLine("Plus petit !");
    }
    if (input < 10)
    {
        Console.WriteLine("Plus grand !");
    }
} while (input < 10 || input > 20);

Console.WriteLine("Bravo !");
*/


//Ex_03
//Analysez le programme C# suivant et répondez aux questions suivantes :
//01- x2 = result;
//02- 6
//03- 1
//04- Il permet de permuter le modulo des deux entiers

/*int x1, x2, result;
Console.WriteLine("Entrez deux entier :");
x1 = int.Parse( Console.ReadLine() );
x2 = int.Parse( Console.ReadLine() );
do {
result = x1 % x2;
x1 = x2;
x2 = result;
} while( result != 0 );
Console.WriteLine($"Le résultat est { x1 }");*/


//Ex_04
//Écrire un programme C# qui demande un nombre à l'utilisateur et calcule sa factorielle.

/*int input, facto, i;
Console.WriteLine("Entrez un nombre entier : ");
input = int.Parse(Console.ReadLine());
facto = input;
for (i = input - 1; i >= 1; i--)
{
    facto = facto * i;
}
Console.WriteLine($"La factorielle de  {input}, est {facto}");*/

//Ex_05
//Écrivez un programme de type devinette qui tire un chiffre au hasard entre 0 et 9 et demande
//à l’utilisateur de deviner ce nombre jusqu’à-ce qu’il le trouve. Suivez le étapes suivantes :
//1. Tirer le nombre au hasard
//2. Demander un nombre à l’utilisateur
//3. Tant que le nombre lu est différent du nombre tiré au hasard
//    A) Demande un nombre à l’utilisateur
//    B) Compter le nombre de boucles (essaie) effectuées
//4. Afficher un message de réussite ainsi que le nombre d’essaies nécessaires
//5. N.B. Pour tirer un nombre aléatoire : new Random().Next(0,9)

/*int nombre, essai = 1, random = new Random().Next(0,9); 
Console.WriteLine("Entrez un nombre de 1 a 9 :");
nombre = int.Parse(Console.ReadLine());
while (random != nombre )
{
    Console.WriteLine("Entrez un nombre de 1 a 9 :");
    nombre = int.Parse(Console.ReadLine());
    essai++;
}
Console.WriteLine("Vous avez reussi et vous avez essayer " + essai + " fois");*/

//Ex_06
//Reprenez le programme précédent (3.5) mais :
//1. En faisant tirer au hasard un nombre entre 0 et 50
//2. Afficher « trop bas/haut » si la valeur devinée est trop petite/grande

/*int nombre, essai = 1, random = new Random().Next(0,50); 
Console.WriteLine("Entrez un nombre de 1 a 50 :");
nombre = int.Parse(Console.ReadLine());
while (random != nombre )
{
    if (nombre < random)
    {
        Console.WriteLine("trop bas");
    }

    if (nombre > random)
    {
        Console.WriteLine("trop haut");
    }
    Console.WriteLine("Entrez un nombre de 1 a 50 :");
    nombre = int.Parse(Console.ReadLine());
    essai++;
}
Console.WriteLine("Vous avez reussi et vous avez essayer " + essai + " fois");*/

//Ex_07
//Écrire un programme C# qui demande un nombre de départ qui doit obligatoirement être pair
//(boucle « do... while ») sinon on redemande un nombre, et qui ensuite affiche les dix nombres
//suivants par saut de 2 (boucle « for »). Par exemple, si l'utilisateur entre le nombre 18, le
//programme affichera de 18 à 38.

/*int input, multi;
do
{
    Console.WriteLine("Entrez un nombre pair : ");
    input = int.Parse(Console.ReadLine()); 
    
}while (input % 2 != 0);
Console.WriteLine($"Resultat = {input}");
for (int i = 0; i < 10; i++)
{
    input = input + 2;
    Console.Write($"{input} ");
}*/

//Ex_08
//Écrire un programme C# qui demande successivement 5 nombres entier positif à l’utilisateur,
//et qui lui dit ensuite quel était le plus grand parmi ces 5 nombres.

/*int nb1, max1 =0, max2 =0;
for (int i = 1; i < 6; i++)
{
    Console.WriteLine("Entrer le nombre numero" + i, ":");
    nb1 = int.Parse(Console.ReadLine());
    if (nb1 > max1)
    {
        max1 = nb1;
        if (max1 > max2)
        {
            max2 = i;
        }
    }
}
Console.WriteLine("Le plus grand de ces nombre est : " + max1 + " c'etait le nombre : "+ max2);*/

//Ex_09
// Serie defis a faire plus tard


//Lab03_bonus___________________________________________________________________________________________________________
//Ex_3.1
//Écrire un programme C# qui demande un nombre de départ, et qui ensuite écrit la table de
//multiplication de ce nombre, présentée comme suit (cas où l'utilisateur entre le nombre 7) :
//Table de
//7 : 7 x 1 = 7
//7 x 2 = 14
//7 x 3 = 21
//    …
//7 x 10 = 70

/*int nombre, nb = 0;
Console.WriteLine("Table de");
nombre = byte.Parse(Console.ReadLine());
for (byte i = 0; i < 10; i++)
{
    Console.Write(nombre "X" + i + "=" + 2);
    Console.Write(nombre * 3);
    Console.Write(nombre * 4);#2#
    /*Console.Write((nombre) * 5);
    Console.Write((nombre) * 6);
    Console.Write((nombre) * 7);
    Console.Write((nombre) * 8);
    Console.Write((nombre) * 9);
    Console.Write((nombre) * 10);
}*/

/*do
{
    Console.WriteLine("Table de");
    nombre = int.Parse(Console.ReadLine());
    nombre = nombre * 1;
    Console.WriteLine(nombre);
}while (nb < 10);*/


//Ex_3.2 OK!
//Écrire un programme C# qui demande successivement 20 nombres à l’utilisateur, et qui lui dise
//ensuite quel était le plus grand parmi ces 20 nombres :
//Entrez le nombre numéro 1 : 12 Entrez le nombre numéro 2 : 14 etc. Entrez le nombre numéro
//20 : 6 Le plus grand de ces nombres est : 14 Modifiez ensuite l’algorithme pour que le
//programme affiche de surcroît en quelle position avait été saisie ce nombre : C’était le nombre numéro 2

/*int nb1, max1 =0, max2 =0;
for (int i = 1; i < 6; i++)
{
    Console.WriteLine("Entrer le nombre numero" + i, ":");
    nb1 = int.Parse(Console.ReadLine());
    if (nb1 > max1)
    {
        max1 = nb1;
        if (max1 > max2)
        {
            max2 = i;
        }
    }
}
Console.WriteLine("Le plus grand de ces nombre est : " + max1 + " c'etait le nombre : "+ max2);*/


//Ex_3.3 OK!
/*int nb1 = 1, max1 =0, max2 =0, i = 1;

while (nb1 ==0)
{
    Console.WriteLine("Entrer le nombre numero " + i, ":");
    nb1 = int.Parse(Console.ReadLine());
    if (nb1 > max1)
    {
        max1 = nb1;
        if (max1 > max2)
        {
            max2 = i;
        }
    }
}
Console.WriteLine("Le plus grand de ces nombre est : " + max1 + " c'etait le nombre : "+ max2);*/


//Ex_3.4

//Ex_3.5 ok! 
//Écrire un programme C# qui vérifie si un nombre entier X est un nombre premier. Un nombre
//premier est un entier naturel, qui se divise seulement par 1 et lui-même.
/*int nombre, entier1, entier2 = 0;
Console.WriteLine("Entrez un nombre : ");
nombre = int.Parse(Console.ReadLine());
entier1 = nombre / 2;
for (int i = 2; i <= entier1; i++)
{
    if (nombre % i == 0)
    {
        Console.WriteLine("le nombre n'est pas un nombre permier");
        entier2 = 1;
        break;
    }
}

if (entier2 == 0)
{
    Console.WriteLine("Nombre est un nombre premier");
}/*

//Ex_3.6

//Ex_3.7
/*/
/*int input, nb1, nb2 = 0, somme, n;
do
{
    Console.WriteLine("--------------------------------");
    Console.WriteLine("| [1] - Calcul de la somme. |");
    Console.WriteLine("| [2] - Recherche du minimum et du maximum. |");
    Console.WriteLine("| [3] - Calcul du quotient et reste de la division. |");
    Console.WriteLine("| [4] - Le calcul du produit des deux entiers. |");
    Console.WriteLine("| [5] - Determination si A est divisible par B. |");
    Console.WriteLine("| [6] - Determiner si le nombre est un entier. |");
    Console.WriteLine("| [8] - Calcule la somme des chiffres qui composent un entier naturel N. |");
    Console.WriteLine("| [9] - Quitter le programme. |");
    Console.WriteLine("--------------------------------");
    do
    {
        Console.Write("Entrez votre choix [1..9] : ");
        input = int.Parse(Console.ReadLine());
    } while (input < 0 || input > 9);

    switch (input)
    {
        case 1:
            Console.WriteLine("Entrer les nombers entiers :");
            nb1 = int.Parse(Console.ReadLine());
            nb2 = int.Parse(Console.ReadLine());
            for (int i = 1; i < 12; i++) ;
        {
            nb1 = nb1*(nb1+1)/2;
            nb2 = nb2*(nb2 + 1) / 2;
            somme = nb1 + nb2;
            Console.WriteLine($"La somme des deux nombre entier est : {somme}");
        }
            break;
        case 2:
            int nb, max1 =0;
            for (int i = 1; i < 6; i++) // a revoir car nous ne devons pas connairtre la fin de n nombre 
            {
                Console.WriteLine("Entrer le nombre numero" + i, ":");
                nb = int.Parse(Console.ReadLine());
                if (nb > max1)
                {
                    max1 = nb;
                }
            }
            Console.WriteLine("Le plus grand de ces nombre est : " + max1 + " c'etait le nombre : ");
            break;
        case 3:
            int quotien1, quotien2, quotien, reste;
            Console.WriteLine("Entrer les 2 nombers entiers :");
            quotien1 = int.Parse(Console.ReadLine());
            quotien2 = int.Parse(Console.ReadLine());
            quotien = Math.DivRem(quotien1, quotien2, out reste);
            Console.WriteLine($"Le quotien est : {quotien} le reste est : {reste}");
            break;
        case 4:
            int produit1, produit2, boucle1 =0, produit3 = 0;
            Console.WriteLine("Entrer les 2 nombers entiers :");
            produit1 = int.Parse(Console.ReadLine());
            produit2 = int.Parse(Console.ReadLine());
            for ( int i = 0; i < produit2; i++)
            {
                produit3 = produit3 + produit1;
                Console.WriteLine($"La produit des deux nombre entier est : {produit3}");
            }
            Console.WriteLine($"La produit des deux nombre entier est : {produit3}");
            break;
        case 5:
            Console.WriteLine("Entrer les nombers entiers :");
            nb1 = int.Parse(Console.ReadLine());
            nb2 = int.Parse(Console.ReadLine());
            somme = nb1 + nb2;
            Console.WriteLine($"La somme des deux nombre entier est : {somme}");
            break;
        case 6:
            Console.WriteLine("Entrer les nombers entiers :");
            nb1 = int.Parse(Console.ReadLine());
            nb2 = int.Parse(Console.ReadLine());
            somme = nb1 + nb2;
            Console.WriteLine($"La somme des deux nombre entier est : {somme}");
            break;
        case 7:
            Console.WriteLine("Entrer les nombers entiers :");
            nb1 = int.Parse(Console.ReadLine());
            nb2 = int.Parse(Console.ReadLine());
            somme = nb1 + nb2;
            Console.WriteLine($"La somme des deux nombre entier est : {somme}");
            break;
        case 8:
            Console.WriteLine("Entrer les nombers entiers :");
            nb1 = int.Parse(Console.ReadLine());
            nb2 = int.Parse(Console.ReadLine());
            somme = nb1 + nb2;
            Console.WriteLine($"La somme des deux nombre entier est : {somme}");
            break;
    }

}while (input != 9);*/