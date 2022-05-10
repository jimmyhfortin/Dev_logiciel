namespace PlayListLib;

public class PlayList
{
    public string Name { get; set; }

    public int Count 
    {
        get => song.Count;
        set
        {
            
        }
    }
    public List<Song> song { get; set; }

    public Duration TotalLength { get; set; }
    /*{
        get
        {
            for (int i = 0; i < song.Count; i++) //new duration 
            {
                TotalLength += song[i].Length;
            }
            
        } 
    }*/

    public PlayList()
    {
    }
    public PlayList(string name)
    {
        Name = name;
        song = new List<Song>();
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

    public void Add(Song NewSong)
    {
        this.song.Add(NewSong);
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
        if (obj == null || this.GetType() != obj.GetType())
        {
            return false;
        }

        PlayList other = (PlayList)obj;
        // return Name.Equals(other.Name) && Dob.Equals(other.Dob);
        return Name == other.Name;
    }

    public override int GetHashCode()
    {
        return Name.GetHashCode();
    }

    public override string ToString()
    {
        return $"PlayList({Name}, {TotalLength}, {string.Join("\n", song)})"; //count to add + {string.Join("\n", song)}
    }
}