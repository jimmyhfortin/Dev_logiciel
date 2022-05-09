namespace PlayListLib;

public class PlayList
{
    public string Name { get; set; }
    public int Count { get; set; }
    public List<Song> song { get; set; }
    public Duration duration { get; set; }

    public PlayList()
    {
    }
    public PlayList(string name)
    {
        Name = name;
    }
    public PlayList(string name, List <Song> song)
    {
        Name = name;
        this.song = song;
    }
    public PlayList(string name, params Song[] song)
    {
        Name = name;
        this.song = new List<Song>(song);
    }
    
    public int Find(int Id)
    {
        for (int i = 0; i < song.Count; i++)
        {
            if (Id.Equals(song[i]))
            {
                return i;
            }
            
        }
        return -1;
    }
    
    
    
    
}