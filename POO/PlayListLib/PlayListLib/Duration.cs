namespace PlayListLib;

public class Duration
{
    public int Hours { get; set; }
    public int Minutes { get; set; }
    public int Seconds { get; set; }
    public int TotalSeconds { get; }//prop calculer a partir des 3 autres

    public Duration()
    {
    }

    public Duration(int hours, int minutes, int seconds)
    {
        Hours = hours;
        Minutes = minutes;
        Seconds = seconds;
    }

    public Duration(int minutes)
    {
        Minutes = minutes;
    }

    public override bool Equals(object? obj)
    {
        if (obj == null || this.GetType() != obj.GetType())
        {
            return false;
        }

        Duration other = (Duration)obj;
        // return Name.Equals(other.Name) && Dob.Equals(other.Dob);
        return TotalSeconds == other.TotalSeconds;
    }

    public override int GetHashCode()
    {
        return TotalSeconds.GetHashCode();
    }

    public override string ToString()
    {
        return $"Duration({Hours}, {Minutes}, {Seconds}, {TotalSeconds})";
    }
}