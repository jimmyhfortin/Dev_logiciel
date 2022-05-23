using DataRepoLib;
using PlayListLib;

namespace PlayListApp;

public class Program
{

    static void Main(string[] args)
    {
        string dir = Directory.GetParent(Environment.CurrentDirectory)?.Parent?.Parent?.FullName ?? "";
        

        var artistRepo = new JsonArtistRepo(Path.Combine(dir, "artists1.json"));
        var artists = artistRepo.SelectAll();
        
        // artistRepo.Insert(new Artist("Metallica","www.metallica.com"));
        // artistRepo.Insert(new Artist("Iron Maiden", "www.ironmaiden.com"));
        // artistRepo.Insert(new Artist("Dumas"));
        artists = artistRepo.SelectAll();
        Console.WriteLine("Artistes :");
        Console.WriteLine(string.Join("\n", artists));

        var songRepo = new JsonSongRepo(Path.Combine(dir, "songs1.json"));
        // songRepo.Insert(new Song("Enter Sandman", artists[0], 331));
        // songRepo.Insert(new Song("Sad But True", "Metal", artists[0], new Duration(0, 5, 24)));
        // songRepo.Insert(new Song("The Uniforgiven", artists[0], new Duration(0, 3, 47)));
        // songRepo.Insert(new Song("Of Wolf and Man", artists[0], new Duration(0, 4, 16))); 
        // songRepo.Insert(new Song("Caught Somewhere in Time", artists[1], new Duration(0, 7, 27)));
        // songRepo.Insert(new Song("Wasted Years", artists[1], new Duration(0, 5, 09)));
        // songRepo.Insert(new Song("Sea of Madness", artists[1], new Duration(0, 3, 52)));
        // songRepo.Insert(new Song("The Loneliness of the Long Distance Runner", artists[1], new Duration(0, 6, 33)));
        // songRepo.Insert(new Song("J'erre", artists[2], new Duration(0, 2, 48)));
        // songRepo.Insert(new Song("Ne me dis pas", artists[2], new Duration(0, 3, 23)));
        // songRepo.Insert(new Song("Alors Alors", artists[2], new Duration(0, 3, 12)));
        
        var songs = songRepo.SelectAll();
        Console.WriteLine("Chansons :");
        Console.WriteLine(string.Join("\n", songs));
        
       
        var playListRepo = new JsonPlayListRepo(Path.Combine(dir, "playlists1.json"));
        // playListRepo.Insert(new PlayList("Metallica", songs[0], songs[1], songs[2], songs[3]));
        // playListRepo.Insert(new PlayList("Iron Maiden", songs[4], songs[5], songs[6], songs[7]));
        // playListRepo.Insert(new PlayList("Dumas", songs[8], songs[9],songs[10]));
        var playLists = playListRepo.SelectAll();
        Console.WriteLine("Listes :");
        Console.WriteLine(string.Join("\n", playLists));
        
    }
    
    /* exemple de sortie de cette méthode :
Artistes :
(1) Patrice Michaud
(2) Marie-Pier Arthur
Chansons :
(1) Kamikaze (Patrice Michaud) 00:04:05
(2) Mécaniques générales (Patrice Michaud) 00:03:18
(3) Droit devant (Marie-Pier Arthur) 00:03:38
(4) Pourquoi (Marie-Pier Arthur) 00:03:08
Listes :
Un 00:10:51
(1) Kamikaze (Patrice Michaud) 00:04:05
(4) Pourquoi (Marie-Pier Arthur) 00:03:08
(3) Droit devant (Marie-Pier Arthur) 00:03:38
Deux 00:07:23
(2) Mécaniques générales (Patrice Michaud) 00:03:18
(1) Kamikaze (Patrice Michaud) 00:04:05     
     */
}