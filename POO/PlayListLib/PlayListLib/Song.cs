namespace PlayListLib;

public class Song
{
    public static int NextId { get; set; } = 1; // a revoir pour le -set
    public static int IndexOf(Song[] data, Song target)
    {
        for (int i = 0; i < data.Length; i++)
        {
            if (target.Equals(data[i]))
                // if (data[i].Equals(target))
            {
                return i;
            }
        }
        return -1;
    }
    public int Id { get; set; }
}