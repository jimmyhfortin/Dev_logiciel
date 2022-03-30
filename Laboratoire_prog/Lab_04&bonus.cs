//Ex_4.1
//Écrire un programme en C# qui initialise un tableau de 10 variables de type byte avec les
//chiffres de 0 à 9 (0, 1, 2, 3, 4, 5, 6, 7, 8 et 9).

/*byte [] chiffres = new byte[10];
for (byte i = 0; i < 10 ; i++)
{
    Console.WriteLine();
}*/


//Ex_4.2
//Écrire un programme en C# qui demande à l’utilisateur 5 nombres. Il affiche finalement les
//nombres entrés. L’utilisation d’un tableau est obligatoire.

/*int [] tab1 = new int[5];
for (int i = 0; i <= tab1.Length - 1; i++)
{
    Console.Write($"Entrer nombre #{i+1}: ");
    tab1[i] = int.Parse(Console.ReadLine());
}
Console.Write("Les nombres sont :  ");
for (int i = 0; i < tab1.Length; i++)
{
    Console.Write($"{tab1[i]} ");
}*/

//Ex_4.3
//Reprendre l’algorithme précédent et affichez plutôt la moyenne des nombres entrés.

/*decimal moy, sum=0m;
int [] tab1 = new int[5];
for (int i = 0; i <= tab1.Length - 1; i++)
{
    Console.Write($"Entrer nombre #{i+1}: ");
    tab1[i] = int.Parse(Console.ReadLine());
}
Console.Write("La moyenne est de : ");
for (int i = 0; i < tab1.Length; i++)
{
    sum += tab1[i];
}
moy = sum / tab1.Length;
Console.Write(moy);*/


//Ex_4.4
//Écrire un programme C# qui demande à l’utilisateur 5 nombres. Il affiche ensuite la plus
//grande valeur entrée en précisant quelle position réelle (humaine) elle occupe dans le tableau.

/*int nb1, max1 =0, max2 =0;
int [] tab1 = new int[5];
for (int i = 0; i <= tab1.Length - 1; i++)
{
    Console.Write($"Entrer nombre #{i+1}: ");
    tab1[i] = int.Parse(Console.ReadLine());
}
for (int j = 0; j < tab1.Length; j++)
{
    nb1 = tab1[j];
    if (nb1 > max1)
    {
        max1 = nb1;
        if (max1 > max2)
        {
            max2 = j+1;
        }
    }
}
Console.WriteLine("Maximum = " + max1 + " Position =  "+ max2);*/

//Ex_4.5
//Écrire un programme C# qui remplis aléatoirement de chiffres (compris entre 0 et 9) deux
//tableaux de départ de 8 éléments. Il crée ensuite un troisième tableau composé de la
//multiplication des éléments des deux tableaux de même indice et affiche les résultats à l’écran comme suit :

/*Random random = new Random();
int[] tableau1 = new int[9];
int[] tableau2 = new int[9];
int[] tableau3 = new int[9];
Console.Write("Tableau 1 = ");
for (int i = 0; i < tableau1.Length; i++)
{
    tableau1[i] = random.Next(0,9);
    Console.Write($"{tableau1[i]} ");
}
Console.WriteLine("");
Console.Write("Tableau 2 = ");
for (int j = 0; j < tableau2.Length; j++)
{
    tableau2[j] = random.Next(0,9);
    Console.Write($"{tableau2[j]} ");
}
Console.Write("\nResultat = [ ");
for (int k = 0; k < tableau1.Length; k++)
{
    tableau3[k] = tableau1[k] * tableau2[k];
    Console.Write($"{tableau3[k]} ");
}
Console.Write("]");*/

//Ex_4.6
//Écrire un programme C# qui demande à l’utilisateur 9 notes à l’utilisateur (sur 100, non
//nécessaire de valider). Il retourne ensuite le nombre de notes supérieures à la moyenne de la
//classe. L’affichage doit être identique à celui-ci.

/*int sum = 0, moyenne, sup = 0;
int[] note = new int[9];
for (int i = 0; i < note.Length; i++)
{
    Console.Write($"Entrer votre note #{i + 1} :");
    note[i] = int.Parse(Console.ReadLine());
    sum = sum + note[i];
}

moyenne = sum / note.Length;
for (int j = 0; j < note.Length; j++)
{
    if (note[j] > moyenne)
    {
        sup = sup + 1;
    }
}
Console.WriteLine($"Nombre de notes > moyenne = {sup}");  */  
//Fin_Lab_04____________________________________________________________________________________________________________
//Lab_04_bonus__________________________________________________________________________________________________________
//7.1)
//Écrivez un programme pour déclarer un tableau, puis saisissez ses éléments par l'utilisateur
//et affichez tous les éléments négatifs.

/*int  nombre;
Console.Write("Saisir le nombre d'elements : ");
int[] array = new int[int.Parse(Console.ReadLine())];
for (int i = 0; i < array.Length; i++)
{
    Console.Write($"Elements {i+1} : ");
    array[i] = int.Parse(Console.ReadLine());
}

Console.Write("Les elementes negatifs sont : ");
int neg1 = array[0];
for (int i = 0; i < array.Length; i++)
{
    if (array[i] < 0)
    {
        neg1 = array[i];
    }
}
int neg2 = array[0];
for (int i = 0; i < array.Length; i++)
{
    if (array[i] < 0)
    {
        neg2 = array[i];
    }
}
Console.Write($"{neg1} et {neg2}");// ne fontionne pas a revoir*/

//7.2)Écrivez un programme pour déclarer un tableau, puis saisissez ses éléments à partir de
//l'utilisateur et recherchez l'élément le plus grand et le deuxième dans ce tableau

/*Console.Write("Entrer nombre d'element : ");
int[] array = new int[int.Parse(Console.ReadLine())];
for (int i = 0; i < array.Length; i++)
{
    Console.Write($"Entrer nombre # {i+1} : ");
    array[i] = int.Parse(Console.ReadLine());
}

int max1 = array[0], max2 = array[0];

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max1)
    {
        max2 = max1;
        max1 = array[i];
    }
    else if (array[i]>= max2 && max2< max1)
    {
        max2 = array[i];
    }
}
Console.Write($"Le premier grand nombre est {max2}\nLe deuxieme grand nombre est {max1}");*/

//7.3)
//Écrivez un programme pour déclarer un tableau, puis saisissez ses éléments à partir de
//l'utilisateur et comptez le nombre d'éléments pairs et impairs dans ce tableau.

/*Console.Write("Entrer nombre d'element : ");
int[] array = new int[int.Parse(Console.ReadLine())];
for (int i = 0; i < array.Length; i++)
{
    Console.Write($"Entrer nombre # {i+1} : ");
    array[i] = int.Parse(Console.ReadLine());
}

int pair=0, impaire=0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0)
    {
        pair++;
    }
    else if (array[i] % 2 != 0)
    {
        impaire++;
    }
}
Console.Write($"Nombre d'elements pair : {pair} \nNombre d'elements impaires : {impaire}");*/

//7.4)
//Écrivez un programme pour déclarer deux tableaux, puis entrez les éléments du premier
//tableau de l'utilisateur et copiez tous ses éléments dans le deuxième tableau

/*Console.Write("Entrer nombre d'element : ");
int taille = int.Parse(Console.ReadLine());
int[] array = new int[taille];
int[] array2 = new int[taille];
Console.WriteLine("Avant \nElements tableau 1");
for (int i = 0; i < array.Length; i++)
{
    Console.Write($"Entrer nombre # {i+1} : ");
    array[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine("\nElements tabelau 2");
for (int i = 0; i < array.Length; i++)
{
    Console.Write($"Entrer nombre # {i+1} : ");
    array2[i] = int.Parse(Console.ReadLine());
}

int tmp;
for (int i = 0; i < array.Length; i++)
{
    tmp = array[i];
    array[i] = array2[i];
    array2[i] = tmp;
}
Console.WriteLine("\nApres");
Console.WriteLine($"Element tableau 1 : ");
for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine($"Nombre # {i+1} : {array[i]}");
}
Console.WriteLine($"\nElement tableau 2 : ");
for (int i = 0; i < array2.Length; i++)
{
    Console.WriteLine($"Nombre # {i+1} : {array2[i]}");
}*/

//7.5) Reprenez l’exercice précédent et pour le cas de deux tableaux de tailles différentes. Lors de la
//copie des éléments, le tableau qui a plus d’éléments doit être complété par des zéros et les éléments
//restants qu’on n’a pas pu mettre dans le petit tableau doivent être placé dans un troisième tableau
//qui a la même taille que le nombre des éléments restants.
//fuck off
