namespace PersonLib;

public class Form
{
    public string Enonce { get; set; }
    public string Reponse { get; set; }
    public string BonneReponse { get; set; }
    public int NbPoint { get; set; }

    public Form(string enonce, string reponse, string bonneReponse, int nbPoint)
    {
        Enonce = enonce;
        Reponse = reponse;
        BonneReponse = bonneReponse;
        NbPoint = nbPoint;
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
        return $"Form{BonneReponse}";
    }
}