//LABORATOIRE_02____________________________________________________________________________________________


//2.1
//Écrire un programme qui demande un nombre à l’utilisateur, puis qui calcule et affiche le carré de ce nombre.

/*int Nbdemander;
Console.Write("Entrez un nombre : ");
Nbdemander = int.Parse(Console.ReadLine());
Console.Write("Le carre de " + Nbdemander + " est ");
Console.WriteLine(Math.Pow(Nbdemander, 2));*/


//2.2
//Écrire un programme qui demande un prix d’achat à l’utilisateur et qui calcule ensuite le
//montant des taxes et le montant total. Vous aurez besoin de la fonction arrondir de C#, Math.Round(montant_ici, 2).

/*float prix;
Console.WriteLine("Quelle est le prix de vente :");
prix = float.Parse(Console.ReadLine());
float tmpTPS = prix * 0.05f;
float tmpTVQ = tmpTPS * 1.975f;
float total = prix + tmpTPS + tmpTVQ;
Console.WriteLine("Montant : " + prix + " $" + "\nTPS : " + tmpTPS + " $" + "\nTVQ : " + tmpTVQ + " $");
Console.WriteLine("Total : " +(Math.Round(total,2) + " $"));*/


//2.3
//Écrire un programme qui demande la température de l’eau et qui affiche son état (solide,
//liquide, gazeux). DÉFI : Ne pas répéter le texte « L’eau est dans un état » dans le code ! DRY !/*

/*float temperature;
Console.Write("Entrez la temperature de l'eau en celcius : ");
temperature = float.Parse(Console.ReadLine());
if (temperature > 0) // 
{
 if (temperature > 0 && temperature < 100) 
  Console.WriteLine("L'eau est dans un etat liquide");
 if (temperature > 100)
  Console.WriteLine("L'eau est dans un etat gazeux");
}
else
 Console.WriteLine("L'eau est dans un etat solide");*/


//2.4
//En utilisant une variable de type « double », écrire un programme qui demande le diamètre
//d’une petite sphère et qui retourne son volume en cm 3 . Recherches Google : « volume
//sphère » et fonctions suivantes : Math.PI, Math.Pow( valeur, puissance) et

/*
Math.Round(montant_ici, 2).
double diametre, volume, rayon;
Console.Write("Entrez le diametre de la sphere :");
diametre = double.Parse(Console.ReadLine());
rayon = diametre / 2d;
volume = (4 / 3d * Math.PI * Math.Pow(rayon, 3));
Console.Write("Le volume de la sphere de diametre " + diametre + " est de ");
Console.WriteLine(Math.Round(volume ,2) + " cm3");
*/


//2.5
//Écrire un programme qui demande un nombre à l’utilisateur. Le nombre sera valide s’il est
//divisible par 5 mais pas par 7. Afficher si le nombre est valide ou invalide.

/*int nombre;
Console.WriteLine("Entrez un nombre : ");
nombre = int.Parse(Console.ReadLine());
if (nombre % 5 == 0 && nombre % 7 != 0)
{
    Console.WriteLine("Le nombre " + nombre + " est valide");
}
else
{
    Console.WriteLine("Le nombre " + nombre + " est invalide");  
}*/


//Ex_2.6
//Écrire un programme qui demande une année à l’utilisateur et retourne si c’est une année
//bissextile ou pas. L’année est bissextile si elle est divisible par quatre mais pas par 100.
//Toutefois, les années divisibles par 400 sont bissextiles./*

/*
int annee;
Console.WriteLine("Entrez une annee : ");
annee = int.Parse(Console.ReadLine());
if (annee % 4 == 0 && annee % 100 != 0 || annee % 400 == 0)
{
    Console.WriteLine(annee + " est une annee bissextile");
}
else
{
    Console.WriteLine(annee + " est une annee reguliere");
}
*/


//2.7 En utilisant la structure de « switch », demandez un numéro de jour de semaine et affichez le
//nom de ce jour de semaine présumant que dimanche = 1, lundi 2, ... L’utilisateur entrera
//toujours un chiffre mais vous devez gérer le cas où il entre un chiffre invalide

/*int jour;
Console.WriteLine("Quel numero de jour sommes-nous ? ");
jour = int.Parse(Console.ReadLine());

switch (jour)
{
    case 1:
        Console.WriteLine("Bon dimanche a toi !");
        break;
    case 2:
        Console.WriteLine("Bon lundi a toi !");
        break;
    case 3:
        Console.WriteLine("Bon mardi a toi !");
        break;
    case 4:
        Console.WriteLine("Bon mercredi a toi !");
        break;
    case 5:
        Console.WriteLine("Bon jeudi a toi !");
        break;
    case 6:
        Console.WriteLine("Bon vendredi a toi !");
        break;
    case 7:
        Console.WriteLine("Bon samedi a toi !");
        break;
    default:
        Console.WriteLine("Tu es perdu dans l'espace toi !");
        break;
}*/


//Fin_lab_02____________________________________________________________________________________________________________

//Lab_02_bonus__________________________________________________________________________________________________________


//Ex_01 ecire un prog pour trouver un maximum entre trois nombres en utilisant if-else ou if imbriquee.

/*int nombre1, nombre2, nombre3;
Console.WriteLine("Entrez trois nombres : ");
nombre1= int.Parse(Console.ReadLine());
nombre2= int.Parse(Console.ReadLine());
nombre3= int.Parse(Console.ReadLine());
if ((nombre1 > nombre2) && (nombre1 > nombre3))
{
    Console.WriteLine(nombre1);
}
else if ((nombre2 > nombre1) && (nombre2 > nombre3))
{
    Console.WriteLine(nombre2);
}
else if ((nombre3 > nombre1) && (nombre3 > nombre2))
{
    Console.WriteLine(nombre3);
}*/


//Ex_02 ecrire un prog pour verifier si un nombre es divisible par 3 et 13 ou non utilisant un if-else

/*int nombre;
Console.WriteLine("Veuillez entrer un nombre :" );
nombre = int.Parse(Console.ReadLine());
if (nombre % 3 == 0 && nombre % 13 == 0)
{
    Console.WriteLine(nombre + " est divisilbe par 3 et 13");
}
else
{
    Console.WriteLine("Veuillez entrer un nombre divisible par 3 et par 13");
}*/


//Ex_03 ecrire un prog pour verifier sir un nombre est pair ou impaire en utilisant ub if-else

/*int nombre;
Console.WriteLine("Veuillez entrer un nombre :");
nombre = int.Parse(Console.ReadLine());
if (nombre % 2 == 0)
{
    Console.WriteLine(nombre + " est une nombre pair");
}
else
{
    Console.WriteLine(nombre + " n'est pas un nombre pair");
}*/


//Ex_04 ecire un prog pour verifier su un alphabet est une voyelle ou une consone en utilisant un if-else. voyelle en
//en minuscule et maj. Les autres des consonnes

/*char lettre;
Console.WriteLine("Veuillez entrer une lettre de l'alphabet :");
lettre = char.Parse(Console.ReadLine());
if (lettre == 'a' || lettre == 'e' || lettre == 'i' || lettre == 'o' || lettre == 'u' || lettre == 'A' ||
    lettre == 'E' || lettre == 'I' || lettre == 'O' || lettre == 'U')
{
    Console.WriteLine(lettre + " est une voyelle");
}
else
{
    Console.WriteLine(lettre + " est une consonne");
}*/


//Ex_05 ecrire un prog pour netre le numero du jour de la semaine (1a7) et afficher le nom du jour de la semaine

/*int jour;
Console.WriteLine("Veuillez entrer un chiffre de 1 a 7 : ");
jour = int.Parse(Console.ReadLine());
if (jour == 1)
{
    Console.WriteLine("Lundi");
}
else if (jour == 2)
{
    Console.WriteLine("Mardi");
}
else if (jour == 3)
{
    Console.WriteLine("Mercredi");
}
else if (jour == 4)
{
    Console.WriteLine("Jeudi");
}
else if (jour == 5)
{
    Console.WriteLine("Vendredi");
}
else if (jour == 6)
{
    Console.WriteLine("Samedi");
}
else if (jour == 7)
{
    Console.WriteLine("Dimanche");
}
else
{
    Console.WriteLine("Vous ne savez pas lire ! ");
}*/


//Ex_06 ecire un prog pour entrer le numero de mois entre (1et12) et afficher le nombre de jours de ce mois en if-else 

/*int mois;
Console.WriteLine("Veuillez entrer un numero de mois de 1 a 12 :");
mois = int.Parse(Console.ReadLine());
if (mois == 1 || mois == 3 || mois == 5 || mois == 7 || mois == 10 || mois == 12)
{
    Console.WriteLine("31" + "\njours");
}
else if(mois == 2)
{
    Console.WriteLine("28/29" + "\njours");
}
else
{
    Console.WriteLine("30" + "\njours");
}*/


//Ex_07 ecrire un prog pour saisir le prix de fabrication et le prix de vente d'un produit et verifier le profit ou la 
// la perte. si le prix de fab et superieur au prix de vente. il y a perte sinon profit.

/*float prixF, prixV, profiP;
Console.Write("Veuillez entrer un prix de fabrication : ");
prixF = float.Parse(Console.ReadLine());
Console.Write("Veuillez entrer un prix de vente : ");
prixV = float.Parse(Console.ReadLine());
if (prixV < prixF)
{
    Console.WriteLine("perte");
}
else
{
    Console.WriteLine("profit");
}*/


//Ex_08 ecrire un prog pour verifier si l'annee donnee par l'utilisateur est bissextile ou non, en il-else. 

/*int annee;
Console.Write("Entrez une annee : ");
annee = int.Parse(Console.ReadLine());
if (annee % 4 == 0 && annee % 100 != 0 || annee % 400 == 0)
{
    Console.WriteLine(annee + " est une annee bissextile");
}
else
{
    Console.WriteLine(annee + " est une annee reguliere");
}*/


//Ex_09
//ecrire un programme pour saisir un caracetere de l’utilisateur et vrifier sir le caractere donne est un alphabe
//un chiffre ou un caractere special en utilisant un if-else.

/*char input;
Console.WriteLine("Entrer un caractere : ");
input = char.Parse(Console.ReadLine());
if (input >= 'a' && input <= 'z' || input >= 'A' && input <= 'Z')
{
    Console.WriteLine($"{input} est une lettre");
}
else if (input >= '0' && input <= '9')
{
    Console.WriteLine($"{input} est un chiffre");
}
else
{
    Console.WriteLine($"{input} est un symbole special");
}*/


//Fin du lab_02_bonus