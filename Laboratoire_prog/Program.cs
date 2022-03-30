using System;
using System.ComponentModel.Design;
using System.Data;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace Laboratoire
{
    internal class Program
    {
        //Ex_6.1________________________________________________________________________________________________________
        public static float Accumulator(float sum, float total)
        {
            total = sum + total;
            return (total);
        }

        public static void E01()
        {
            float input= 0.0f;
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Veuillez entrer un nombre {i}:");
                input = Accumulator(float.Parse(Console.ReadLine()),input); // Entrer des nombres consecutif dans un appel 
            }
            Console.WriteLine($"La somme est de  {input}");

            
        }
        //Fin_6.1_______________________________________________________________________________________________________
        //Ex6.2_________________________________________________________________________________________________________
        public static float Sum(float []array1)
        {
            float sum = 0.0f;
            for (int i = 0; i < array1.Length; i++)
            {
                sum += array1[i];
            }

            return (sum);
        }
        public static void E02()
        {
            float[] array1 = new float [5];
            for (int i = 0; i < array1.Length; i++)
            {
                Console.Write($"Entrer un nombre # {i +1 } :");
                array1 [i] = float.Parse(Console.ReadLine());
            }
            Console.WriteLine($"La somme de ces 5 nombres est de {Sum(array1)}");
        }
        //Fin_6.2_______________________________________________________________________________________________________
        //6.3___________________________________________________________________________________________________________
        public static double Distance(double x1, double y1, double x2, double y2)
        {
            double distance;
            distance = Math.Sqrt(Math.Pow(y2-y1,2)+Math.Pow(x2-x1,2));
            return (distance);
        }

        public static void E03()
        {
            double input1, input2, input3, input4,tmp1, tmp2;
            Console.Write("Entrer le nombre x1 : ");
            input1 = double.Parse(Console.ReadLine());
            Console.Write("Entrer le nombre y1 : ");
            input2 = double.Parse(Console.ReadLine());
            Console.Write("Entrer le nombre x2 : ");
            input3 = double.Parse(Console.ReadLine());
            Console.Write("Entrer le nombre y2 : ");
            input4 = double.Parse(Console.ReadLine());
            Console.WriteLine($"La distance entre les points est de {Math.Round(Distance(input1, input2, input3, input4),2)}");
        }
        //Fin_6.3_______________________________________________________________________________________________________
        //6.4___________________________________________________________________________________________________________
        public static int RandomNumbers(int[] array)//qui retroune un tableau remplis de nombre
        {
            Random random = new Random();
            return (random.Next(0,100));
        }

        public static void E04()
        {
            int input = 0;
            Console.Write("Entrer une quantite de nombre : ");
            input = int.Parse(Console.ReadLine());
            int[] array = new int[input];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = RandomNumbers(array);
                Console.Write($"{array[i]} ");
            }
        }
        //Fin_6.4_______________________________________________________________________________________________________
        //6.5___________________________________________________________________________________________________________
        public static int Power(int x1, int x2)
        {
            int nb = x1, puissance = x2, result = 1;
            for (int i = 0; i < puissance; i++)
            {
                result = result * nb;
            }

            return (result);
        }

        public static void E05()
        {
            int nb, puissance, result;
            bool choix;
            while (true)
            {
                choix = AnotherPower();
                if (choix)
                {
                    Console.WriteLine($"Entrer nombre : ");
                    nb = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Entrer puissance : ");
                    puissance = int.Parse(Console.ReadLine());
                    
                    Console.WriteLine($"Resultat = {Power(nb, puissance)}");
                }
                else if (!choix)
                {
                    break;
                }
            }
        }

        public static bool AnotherPower()
        {
            char choix;
            Console.WriteLine($"Entrer un calcul (O/N) ?");
            choix = char.Parse(Console.ReadLine());
            if (choix == 'N' || choix == 'n')
            {
                return false;
            }
            else if (choix == 'O' || choix == 'o')
            {
                return true;
            }
            else
            {
                return true;
            }
        }
        //Fin_6.6_______________________________________________________________________________________________________
        //6.1_bonus_____________________________________________________________________________________________________
        public static bool EndsWith(string maChaine)
        {
            if (maChaine.EndsWith('s'))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void EB61()
        {
            string chaine;
            Console.Write("Entrer un mot : ");
            chaine = (Console.ReadLine());
            if (EndsWith(chaine))
            {
                Console.WriteLine("pluriel");
            }
            else 
            {
                Console.WriteLine("Singulier");
            }
        }
        //Fin_6.1_bonus_________________________________________________________________________________________________
        //6.2_bonus_____________________________________________________________________________________________________
        public static int GetSmall(int[] array1)
        {
            int array = array1[0];
            for (int i = 0; i < array1.Length; i++)
            {
                array = Math.Min(array1[i], array);
            }

            return array;
            
        }

        public static void EB62()
        {
            int[] array = new[] {10, 20, 30, 40, 50}; // tableau definis par nous
            Console.WriteLine($"Le plus petit nombre du tableau est : {GetSmall(array)}");
        }
        //Fin_6.2_bonus_________________________________________________________________________________________________
        //6.3_bonus_____________________________________________________________________________________________________
        public static int GetBigNbr(int[] array1)
        {
            int array = array1[0];
            for (int i = 0; i < array1.Length; i++)
            {
                array = Math.Max(array1[i], array);
            }

            return array;
        }

        public static void EB63()
        {
            Console.Write("Entrer nombre d'element : "); // nous demandons le nombre d'elements que va contenir le tableau 
            int[] array = new int[int.Parse(Console.ReadLine())];
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Entrer nombre # {i+1} : ");
                array[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"Le plus grand nombre du tableau est : {GetBigNbr(array)}");
        }

        public static double Carre(double carre)
        {
            carre = Math.Pow(carre ,2);
            return carre;
        }
        public static double Cube(double cube)
        {
            cube = Math.Pow(cube, 3);
            return cube;
        }
        
        public static void EB64() //manque le do while
        {
            double carre, cube;
            Console.Write("Entre un nombre que vous voulez elever au carre : ");
            carre = double.Parse(Console.ReadLine());
            Console.Write("Entre un nombre que vous voulez elever au cube : ");
            cube = double.Parse(Console.ReadLine());
            Console.WriteLine($"Le carre de {carre} est : {Carre(carre)} \nLe cube de {cube} est : {Cube(cube)}");
        }

        public static bool EstEgal(int[] array1, int[] array2)
        {
            if (array1.Length == array2.Length)
            {
                for (int i = 0; i < array1.Length; i++)
                {
                    if (array1[i] != array2[i])
                    {
                        return false;
                    }
                    
                }
            }
            else
            {
                return false;
            }

            return true;

        }

        public static void EB65()
        {
            int[] array1 = new[] {2, 4, 6, 8, 10};
            int[] array2 = new[] {2, 4, 6, 7, 10};
            if (EstEgal(array1, array2))
            {
                Console.WriteLine($"Les tableaux array1 et array2 sont egale.");
            }
            else
            {
                Console.WriteLine($"Les tableaux ne sont pas egale.");
            }
        }
        static void Main(string[] args)
        {
            //LABORATOIRE_06____________________________________________________________________________________________
            //6.1) Écrivez une fonction Accumulator() qui renvoie la somme de cinq nombres entrés par vous
            //et passés en paramètres individuellement dans la fonction (ne PAS utiliser de tableaux pour ce numéro).
            //E01();
            
            //6.2) Écrire une fonction Sum() ayant comme paramètres un tableau de nombre et qui retourne la
            //somme de tous les éléments du tableau. Le tableau contiendra 5 nombres.
            //E02();
            
            //6.3) Écrire une fonction Distance() ayant comme paramètres 4 nombres x1, y1 et x2, y2 qui
            //représentent les coordonnées de deux points 1 et 2 et qui renvoie la distance entre les points.
            //E03();
            
            //6.4) Écrire une fonction RandomNumbers() ayant en paramètre une quantité de nombre à entrer et
            //qui retourne un tableau remplis de nombre aléatoires en 0 et 100 qui sera ensuite affichés à l’écran à
            //partir de la fonction E04();. Il faut que l’algorithme ne génère l’objet Random() qu’une seule fois en mémoire
            //E04();
            
            //6.5) Écrivez une fonction Power() permettant de calculer la puissance de n’importe quel nombre.
            //Exemple 2 à la 4, 10 à la 5. Vous devez bien sur tout coder vous-même, pas le droit d’utiliser de
            //fonctions C#. L’algorithme se termine quand l’utilisateur ne veut plus faire de calcul ( N ).
            //E05();
            
            //6.6) Reprenez l’exercice précédent et, si ce n’est pas déjà le cas, transformer la demande de faire
            //d’autres calculs en fonction AnotherPower() Qui retourne une valeur booléenne (0 ou 1).
            //E05();
            
            //Lab06_bonus_______________________________________________________________________________________________
            
            //Créez une fonction qui prend un mot et détermine s’il est pluriel ou singulier. Un mot pluriel est celui
            //qui se termine par « s ». S’il est pluriel renvoyer TRUE sinon FALSE. Vous utilisez les fonction
            //EndsWith() qui vérifie si une chaine de caractère se termine par un caractère :
            //EB61();
            
            //6.2) Créez une fonction qui prend un tableau de nombres et renvoie le plus petit nombre.
            //EB62();
            
            //6.3) Créez une fonction qui prend un tableau de nombres et renvoie le plus grand nombre du tableau.
            //EB63();
            
            //6.4) Écrire un programme avec les fonctions carre et cube qui calculent respectivement le carré et le
            //cube (ou puissance 3) d’un nombre de type double. La méthode main doit tester ces deux fonctions
            //sur plusieurs exemples.
            //EB64();
            
            //6.5) Bien souvent, on veut comparer deux tableaux selon une égalité selon laquelle les deux tableaux
            //t1 et t2 sont égaux si et seulement si ils ont la même longueur et les éléments de même indice sont
            //égaux, c’est à dire que t1[i] == t2[i] pour tout indice i. Écrire une fonction appelée estEgal qui réalise
            //ce test d’égalité pour des tableaux de type int[].
            //EB65();
            int x =3;
            //x = int.Parse(Console.ReadLine());
            if (((x % 4 == 0) && (x + 3 <= 13)) != (x >= 5))
            {
                Console.WriteLine($"rouge {x}");
                
            }
            else
            {
                Console.WriteLine("orange");
            }



















































































































        }
    }
}

        
        
    
    
