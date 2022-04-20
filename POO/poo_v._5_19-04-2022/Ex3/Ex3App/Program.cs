using Ex3Lib;

namespace Ex3App;

public class Program
{
    static int ReadInt(string message, int start, int end)
    {
        bool ok = false;
        int result = start - 1;
        while (!(ok && result >= start && result <= end))
        {
            Console.Write(message);
            ok = int.TryParse(Console.ReadLine(), out result);
        }

        return result;
    }

    static void Main(string[] args)
    {
        int nFaces = ReadInt("Entrez le nombre de faces du dé, entre 2 et 120 inclusivement: ", 2, 120);
        
        Dice dice = new Dice(nFaces);
        dice.Throw();
        Console.WriteLine(dice.Number);
        int guess = 0;
        while (guess != dice.Number)
        {
            guess = ReadInt($"Devinez un nombre entre 1 et {nFaces} inclusivement: ", 1, nFaces);
            if (guess < dice.Number)
            {
                Console.WriteLine("Trop bas!");
            }
            if (guess > dice.Number)
            {
                Console.WriteLine("Trop haut!");
            }
        }

        Console.WriteLine("Bravo!");
    }
}