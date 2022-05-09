namespace PlayListLib;

public class PlayList
{
    public string Name { get; set; }
    public int Count { get; set; }
    public List<Song> song { get; set; }

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
    public PlayList(string name, Song song)
    {
        Name = name;
        this.song = new List<Song>();
    }

    public int Find(Song song)
    {
        for (int i = 0; i < ; i++)
        {
            
        }
        
        return [i]
    }
}