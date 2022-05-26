
using Question1Lib;

namespace Question1App
{
    public class Program
{
    static void AfficherMot(string mot, List<char> lettres)
    {
        for (int i = 0; i < mot.Length; i++)
        {
            char lettre = mot[i];
            if (lettres.Contains(lettre))
            {
                Console.WriteLine(lettre + " ");
            }
            else
            {
                Console.WriteLine("_ ");
            }
        }

        Console.WriteLine();
    }

    static bool ToutesLettresDevinees(string mot, List<char> lettres)
    {
        foreach (var lettre in lettres)
        {
            mot = mot.Replace(lettre.ToString(), "");
        }

        if (mot.Length == 0)
        {
            return true;
        }

        return false;
    }

    static char DemanderUneLettre(string message = "Enter a letter")
    {
        while (true)
        {
            Console.WriteLine(message);
            string reponse = Console.ReadLine();
            if (reponse.Length == 1)
            {
                reponse = reponse.ToUpper();
                return reponse[0];
            }

            Console.WriteLine("ERROR: you must enter a letter");
        }
    }

    static void DevinerMot(string mot)
    {
        var lettresDevinees = new List<char>();
        var lettresExclues = new List<char>();
        int nbVie = 7;
        int vieRestantes = nbVie;
        while (vieRestantes > 0)
        {
            Console.WriteLine(nbVie- vieRestantes);// a revoir avec l'autre
            Console.WriteLine();
            AfficherMot(mot, lettresDevinees);
            Console.WriteLine();
            var lettre = DemanderUneLettre();
            Console.Clear();
            if (mot.Contains(lettre))
            {
                Console.WriteLine("This letter is in the word");
                lettresDevinees.Add(lettre);
                if (ToutesLettresDevinees(mot, lettresDevinees))
                {
                    break;
                }
            }
            else
            {
                if (!lettresExclues.Contains(lettre))
                {
                    vieRestantes--;
                    lettresExclues.Add(lettre);
                }

                Console.WriteLine($"Remaining life : {vieRestantes}");
            }

            if (lettresExclues.Count > 0)
            {
                Console.WriteLine($"The word does not contain the letters : {string.Join(", ", lettresExclues)}" );
            }
            Console.WriteLine();
        }

        Console.WriteLine(nbVie-vieRestantes);// a revoir avec l'autre
        if (vieRestantes == 0)
        {
            Console.WriteLine($"Lost ! the was {mot}");
        }
        else
        {
            AfficherMot(mot, lettresDevinees);
            Console.WriteLine();
            Console.WriteLine("BRAVISSIMO!!!!!");
        }
    }
    
    static void Main(string[] args)
    {
        string line;
        try
        {
            //Pass the file path and file name to the StreamReader constructor
            StreamReader sr = new StreamReader("/home/jimmy/filename.txt");
            //Read the first line of text
            line = sr.ReadLine();
            //Continue to read until you reach end of file
            while (line != null)
            {
                //write the line to console window
                Console.WriteLine(line);
                //Read the next line
                line = sr.ReadLine();
            }

            //close the file
            sr.Close();
            Console.ReadLine();
        }
        catch (Exception e)
        {
            Console.WriteLine("Exception: " + e.Message);
        }
        finally
        {
            Console.WriteLine("Executing finally block.");
        }
        // string dir = Directory.GetParent(Environment.CurrentDirectory)?.Parent?.Parent?.FullName ?? "";
        // string filename = new (Path.Combine(dir, "filename.txt"));
        /*string text = File.ReadAllText("/home/jimmy/filename.txt");
        Console.WriteLine(text);
        WordList essai = new WordList("essai1");
        essai.GetRandomWord();*/
        
        /*string[] lineFileName = File.ReadAllLines("/home/jimmy/filename.txt");
        for (int i = 0; i < lineFileName.Length; i++)
        {
            Console.WriteLine(lineFileName[i]);
        }*/
        //List<string> lineDileName = File.ReadAllLines("/home/jimmy/filename.txt");
        WordList liste2 = new WordList("liste1", new List<string>()
        {
            "home", 
            "boat", 
            "chair", 
            "car", 
            "spoon"
        });
        var essaie = liste2;
        Console.WriteLine(liste2.GetRandomWord());
        
        
      
        



    }
}
}

