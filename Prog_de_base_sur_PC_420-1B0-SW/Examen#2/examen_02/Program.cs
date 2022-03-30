using System;
using System.Xml.Schema;

namespace jimmyH 
{
    internal class Program
    {
        public static int GetChoice() // declaration de la fonction sans parametre pour faire le traitement du choix entre 1 et 10
        {
            int choix = 0;
            Console.Write("Choisisez un nombre entre 1 et 10 : "); // affichage de la question
            choix = int.Parse(Console.ReadLine());
            return choix; // retour du int choix
        }

        public static int GetQuestion(int question) // declaration de la fonction avec parametre (int question) qui prend le retour choix pour selection une question.
        {
            
            switch (question) // structure de type switch. J'ai essayer de le faire avec un tableau de string mais quelque chose m'echape et je ne me souvriens pas en avoir fait dans les exercices. 
            {
                case 1:
                    Console.WriteLine("Quelle est la plus grande ville de Cuba ?");
                    break;
                case 2:
                    Console.WriteLine("Quelle est la plus grande ville du Canada ? ");
                    break;
                case 3:
                    Console.WriteLine("Quelle est la capitale du Maroc ?");
                    break;
                case 4:
                    Console.WriteLine("Quel est le pays d'hexagone ?");
                    break;
                case 5:
                    Console.WriteLine("Quel est le plus grand continent du monde ? ");
                    break;
                case 6:
                    Console.WriteLine("Quelle est la langue officielle du Brésil ? ");
                    break;
                case 7:
                    Console.WriteLine("Quelle est la monnaie de l'Argentine ? ");
                    break;
                case 8:
                    Console.WriteLine("Quelles sont les trois villes les plus propres au monde ? ");
                    break;
                case 9:
                    Console.WriteLine("Quelle est la ville appelée 'ville ocre' ? ");
                    break;
                case 10:
                    Console.WriteLine("Quelle est la capitale de Seychelles ? ");
                    break;
            }

            return question; // retour du choix de la questions
        }

        public static void GetResponse() // declaration de la fonction du traitement et de l'affichge de la reponse. Elle devrai prendre un retour de la fonction GetQuestion mais je n'ai pas reussi.
        {
            string reponse;
            string[] tableaureponse = new string[10];
            tableaureponse[0] = ("La Havane"); 
            tableaureponse[1] = ("toronto"); 
            tableaureponse[2] = ("Rabat"); 
            tableaureponse[3] = ("France"); 
            tableaureponse[4] = ("Asie"); 
            tableaureponse[5] = ("Portugais"); 
            tableaureponse[6] = ("Peso Argentin"); 
            tableaureponse[7] = ("Calgary (Canada), Wellington (Nouvelle-Zélande) et Ifrane (Maroc)"); 
            tableaureponse[8] = ("Marrakech"); 
            tableaureponse[9] = ("Victoria"); 
            Console.WriteLine("Votre reponse : ");
            reponse = Console.ReadLine();
            for (int i = 0; i < tableaureponse.Length; i++) // boucle for que je crois inutile , je dois utiliser des tableaux dans mes autre fontions. Mais je dois arreter par manque de temps...
            {
                if (reponse == tableaureponse[i])
                {
                    
                    Console.WriteLine("Vous avec la bonne reponse !");
                    break;
                }
                else
                {
                    Console.WriteLine($"La bonne reponse est : {tableaureponse[i]}");
                    
                }
            }
            
        }
            
        static void Main(string[] args)
        {
            //Examen_02_JimmyHFortin____________________________________________________________________________________
            //Exercice_01_______________________________________________________________________________________________
            /*int note, nbEtudiant; // Declaration de nos variables
            double sum = 0.0, moy;
            string nom;
            char sortie;
            do // do while pour recommencer le programme a la fin si besoins
            {
                Console.Write("Combien d'etudiant avez-vous dans votre classe ? : ");
                nbEtudiant = int.Parse(Console.ReadLine()); // nombre d'etudiant dans la classe
                Console.WriteLine("   --->>>>> Saisie des noms <<<<<---   ");
                string[] array1 = new string[nbEtudiant]; // Quantite de nom contenant le tableau
                for (int i = 0; i < nbEtudiant; i++) // boucle qui boucle sur le nombre d'etudiant et qui demande le nom de chacun
                {
                    Console.Write($"Entrer le nom de votre etudiant.e # {i + 1} : ");
                    array1[i] = Console.ReadLine();
                }

                Console.WriteLine("   --->>>>> Saisie des notes <<<<<---   ");
                int[] array2 = new int[nbEtudiant]; // declaration du tableau des notes avec le nombre d'etudiant entrer precedament 
                for (int i = 0; i < nbEtudiant; i++) // boucle qui boule sur la quantite de notes a entrer dependament du nombre d'etudiant
                {
                    Console.Write($"Entrer la note/100 de {array1[i]} : ");
                    array2[i] = int.Parse(Console.ReadLine());
                }

                for (int i = 0; i < nbEtudiant; i++) // boucle qui calcul la somme 
                {
                    sum += array2[i];
                }

                moy = sum / nbEtudiant;// variable moyenne necessaire pour calculer les eleve qui sont en haut de la moyenne
                Console.WriteLine($"La moyenne de la classe est : {sum/nbEtudiant}");
                Console.WriteLine($"Les etudiants qui ont plus que {moy} sont : ");
                string moysup = array1[0]; // declaration de la variable moyenne superieur qui est egale au premier nom entrer dans le tableau de string array1
                for (int i = 0; i < nbEtudiant; i++) // boucle qui boucle sur le nombre d'etudiant
                {
                    if (array2[i] > moy) // condition pour filtrer les notes superieure a la variable moyenne
                    {
                        moysup = array1[i]; // si les notes entrer precedament dans le tableau array2 sont superieur a la moyenne elles sont stocker dans la varible moysup
                        Console.Write($"{moysup} ,");
                    }
                }
                Console.WriteLine("");
                Console.Write("\nVoulez-vous faire un nouvel calcul de moyenne ? [Tapez O pour oui et N pour N] :");
                sortie = char.Parse(Console.ReadLine());
            } while (sortie != 'N'); // Si utilisateur entre 'O' le programe recommence. */
            //Fin de l'exercice 01______________________________________________________________________________________
            //Exercice_02_______________________________________________________________________________________________
            string bonjour;
            Console.Write($"Bienvenu a questions reponses, dites Bonjour :) ");
            bonjour = Console.ReadLine();
            Console.WriteLine("");
            Console.Write($"Question # ");
            Console.Write($"{GetQuestion(GetChoice())}");
            GetResponse();
            
            //J'ai manque de temps. J'ai eu de la difficulte a comprendre la question et a l'appliquer en code.
            //Je suis certain qu'avec des explications supplementaires et plus de temps je pourrais refaire tout mon code. 





















































        }
    }
}