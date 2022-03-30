
// outils.DemanderNombrePositifNonNul
namespace Boite;

public static class outils 
{
    public static int DemanderNombrePositifNonNul(string question) // fonciton demander nombre posiitf entre et entre...(juste a entrer "la question a l'utilsateur en argument");
    {
        return DemanderNombreEntre(question, 1, int.MaxValue);
    }

    public static int DemanderNombreEntre(string question, int min, int max) // fonction recursive qui s'appelle elle-meme, ont l'appel avec le fonction DemanderNombrePositifNonNul.
    {
        // nombre = DemanderNombre(question)
        // si le nombre n'est pas entre min et max -> ERREUR / boucler ...

        int nombre = DemanderNombre(question);
        if ((nombre >= min) && (nombre <= max))
        {
            // valide
            return nombre;
        }
        Console.WriteLine("ERREUR : Le nombre doit être compris entre " + min + " et " + max);

        return DemanderNombreEntre(question, min, max);
    }

    public static int DemanderNombre(string question) // fonction demander nombre a l'utilisateur avec un (try / catch).
    {
        // poser la question
        // récupérer la réponse
        // convertir
        // gérer l'erreur de conversion
        // boucler tant qu'on a pas recu une réponse valide (qui contient que des chiffres)
        while(true)
        {
            Console.Write(question);
            string reponse = Console.ReadLine();
            try
            {
                int reponseInt = int.Parse(reponse);
                return reponseInt;
            }
            catch
            {
                Console.WriteLine("ERREUR : Vous devez rentrer un nombre");
            }
        }
    }
}