
using Question1Lib;

namespace Question1App
{
    public class Program
{
    static void ShowWord(string word, List<char> letter)
    {
        for (int i = 0; i < word.Length; i++)
        {
            char letters = word[i];
            if (letter.Contains(letters))
            {
                Console.Write(letters + " ");
            }
            else
            {
                Console.Write("_ ");
            }
        }
        
    }

    static bool ShowLetterGuess(string word, List<char> letter)
    {
        foreach (var letters in letter)
        {
            word = word.Replace(letters.ToString(), "");
        }

        if (word.Length == 0)
        {
            return true;
        }

        return false;
    }

    static char AskForLetter(string message = "Enter a letter")
    {
        while (true)
        {
            Console.Write($"{message} \n->> ");
            string answer = Console.ReadLine();
            if (answer.Length == 1)
            {
                answer = answer.ToLower(); // changer pour to lower
                return answer[0];
            }

            Console.WriteLine("ERROR: you must enter a letter");
        }
    }

    static void guessWord(string word)
    {
        var guessLetter = new List<char>();
        var excludedLetter = new List<char>();
        int nbLife = 7;
        int lifeRemainig = nbLife;
        while (lifeRemainig > 0)
        {
            Console.WriteLine(nbLife- lifeRemainig);
            Console.WriteLine();
            ShowWord(word, guessLetter);
            Console.WriteLine();
            var letter = AskForLetter();
            Console.Clear();
            if (word.Contains(letter))
            {
                Console.WriteLine("This letter is in the word");
                guessLetter.Add(letter);
                if (ShowLetterGuess(word, guessLetter))
                {
                    break;
                }
            }
            else
            {
                if (!excludedLetter.Contains(letter))
                {
                    lifeRemainig--;
                    excludedLetter.Add(letter);
                }

                Console.WriteLine($"Remaining life : {lifeRemainig}");
            }

            if (excludedLetter.Count > 0)
            {
                Console.WriteLine($"The word does not contain the letters : {string.Join(", ", excludedLetter)}" );
            }
            Console.WriteLine();
        }

        Console.WriteLine(nbLife-lifeRemainig);
        if (lifeRemainig == 0)
        {
            Console.WriteLine($"Lost ! the word was {word}");
        }
        
        else
        {
            ShowWord(word, guessLetter);
            Console.WriteLine();
            Console.WriteLine("BRAVISSIMO!!!!!");
        }
    }

    static bool AskeForReplay()
    {
        char answer = AskForLetter("Do you want tu replay (o/n) : ");
            if ((answer == 'o') || (answer == 'O'))
            {
                return true;
            }

            if ((answer == 'n') || (answer == 'N'))
            {
                return false;
            }
            else
            {
                Console.WriteLine($"You should enter the correct letter");
                return AskeForReplay();
            }
    }

    static string[] LoadFile(string nomFichier)
    {
        try
        {
            return File.ReadAllLines(nomFichier);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error file : {nomFichier} {ex.Message}");
        }

        return null;
    }
    
    static void Main(string[] args)
    {
        
        /*WordList liste2 = new WordList("liste1", new List<string>()
        {
            "home", 
            "boat", 
            "chair", 
            "car", 
            "spoon"
        });*/
        
        
        
        
        
        //var essaie = liste2;
        //Console.WriteLine(liste2.GetRandomWord());
        var mots = LoadFile("filename.txt");
        
        if((mots == null) || (mots.Length == 0))
        {
            Console.WriteLine("The word List is empty");
        }
        else
        {
            while (true)
            {
                Random randomWord = new Random(); //As my function GetRandomWord does not work correctly I make the selection in the Main without removing the word from the list.
                int i = randomWord.Next(mots.Length);
                string TrimedWord = mots[i].Trim().ToLower();
                guessWord(TrimedWord);
                if (!AskeForReplay())
                {
                    break;
                }
                Console.Clear();
            }
        }
        
        // WordList liste1 = new WordList("essai1","filename");
        // liste1.GetRandomWord();
        // liste1.Words.Add("house");
        
        









    }
}
}

