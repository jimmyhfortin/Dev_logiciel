namespace PersonLib;

public class Form
{
    private static int NumeroQuestions = 0;
    public string Enonce { get; set; }
    public string Reponse { get; set; }
    public string BonneReponse { get; set; }
    public int NbPoint { get; set; }
    public int NumQuestion { get; set; }

    public Form(string enonce, string reponse, string bonneReponse, int nbPoint)
    {
        Enonce = enonce;
        Reponse = reponse;
        BonneReponse = bonneReponse;
        NbPoint = nbPoint;
        NumeroQuestions++;
        NumQuestion = NumeroQuestions;
    }

    public override bool Equals(object? obj)
    {
        if (obj == null || this.GetType() != obj.GetType())
        {
            return false;
        }

        Form other = (Form) obj;
        return Enonce.Equals(other.Enonce) && Reponse.Equals(other.Reponse);
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }

    public override string ToString()
    {
        return $"Form {BonneReponse}";
    }

    public int AfficherQuestion()
    {
        string reponse;
        int nbpoint =0;
        Console.WriteLine($"Question # {NumQuestion}, {Enonce}");
        reponse = Console.ReadLine();
        if (reponse.Equals(BonneReponse))
        {
            Console.WriteLine($"Bravo vous avez eu la bonne reponse ! \nVous obtenez {NbPoint} points.");
            nbpoint = NbPoint;
        }
        else
        {
            Console.WriteLine($"Vous n'avez pas obtenu la bonne reponse veuillez recommancer");
            
        }

        Console.WriteLine($"Vous avez {nbpoint} points");
        return NbPoint;
    }
}