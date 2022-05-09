using System.Security.Cryptography.X509Certificates;

namespace PlayListLib;

public class Artist
{
    public static int NextId { get; set; } = 1;
    public int Id { get; set; } // assurer que le id nest pas la 2 fois
    public string Name { get; set; }
    public string Website { get; set; }

    public Artist()
    {
    }
    public Artist(int id, string name, string website)
    {
        Id = id; //NextId = id ???
        Name = name;
        Website = website;
    }
    public Artist(string name, string website)
    {
        Name = name;
        Website = website;
        Id = NextId;
        NextId++;

    }

    public Artist(int id, string name)
    {
        Id = id;// Nextid = id ?????
        Name = name;
    }

    public Artist(string name)
    {
        Name = name;
    }

    public override bool Equals(object? obj)
    {
        if (obj == null || this.GetType() != obj.GetType())
        {
            return false;
        }

        Artist other = (Artist)obj;
        return Id == other.Id;
    }

    public override int GetHashCode()
    {
        return Id.GetHashCode();
    }

    public override string ToString()
    {
        return $"Artist({Id}, {Name}, {Website})";
    }
}