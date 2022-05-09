namespace PlayListLib;

public class PlayList
{
    public string Name { get; set; }

    public int Count
    {
        get
        {
            int NumberOfSong = 0;
            for (int i = 0; i < song.Count; i++)
            {
                NumberOfSong += i+1;
            }

            return NumberOfSong;
        }
        set
        {
            
        }
    }
    public List<Song> song { get; set; }

    public Duration totalLength
    {
        get
        {
            for (int i = 0; i < song.Count; i++)
            {
                totalLength += song[i].Length;
            }
            
        } 
    }

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
    
    public Song Find(int Id)
    {
        for (int i = 0; i < song.Count; i++)
        {
            if (Id.Equals(song[i]))
            {
                return song[i];
            }
            
        }
        return song[-1];
    }

    public void Add(Song song)
    {
        this.song.Add(song);
    }

    public bool Remove(Song songUser) //song
    {
        for (int i = 0; i < this.song.Count; i++)
        {
            if (songUser.Equals(this.song[i]))
            {
                this.song.Remove(songUser);
                return true;
            }
        }
        return false;
    }
    public bool Remove(int songUserInt) //song
    {
        for (int i = 0; i < this.song.Count; i++)
        {
            if (songUserInt == song.Count)
            {
                this.song.Remove(song[i]);
                return true;
            }
        }
        return false;
    }

    public override bool Equals(object? obj)
    {
        return base.Equals(obj);
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }

    public override string ToString()
    {
        return base.ToString();
    }
}