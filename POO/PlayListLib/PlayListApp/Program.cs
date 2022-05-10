﻿using DataRepoLib;
using PlayListLib;

namespace PlayListApp;

public class Program
{

    static void Main(string[] args)
    {
        string dir = Directory.GetParent(Environment.CurrentDirectory)?.Parent?.Parent?.FullName ?? "";

        /*var artistRepo = new JsonArtistRepo(Path.Combine(dir, "artists1.json"));
        //artistRepo.Insert(new Artist("Patrice Michaud", "www.yoyoyyo.com"));
        //artistRepo.Insert(new Artist("Marie-Pier Arthur"));
        var artists = artistRepo.SelectAll();
        Console.WriteLine("Artistes :");
        Console.WriteLine(string.Join("\n", artists));

        var songRepo = new JsonSongRepo(Path.Combine(dir, "songs1.json"));
        //songRepo.Insert(new Song("Kamikaze", artists[0], 245));
        //songRepo.Insert(new Song("Mécaniques générales", "Quebecois", artists[0], new Duration(0, 3, 18)));
        //songRepo.Insert(new Song("Droit devant", artists[1], new Duration(0, 3, 38)));
        //songRepo.Insert(new Song("Pourquoi", artists[1], new Duration(0, 3, 8)));
        var songs = songRepo.SelectAll();
        Console.WriteLine("Chansons :");
        Console.WriteLine(string.Join("\n", songs));
        
        Console.WriteLine(songs[1].Length); // marche pas 
        Console.WriteLine(songs[1].Genre); // marche pas 
        Console.WriteLine(songs[1].artist); // marche pas
        Console.WriteLine(songs[1].Id);
        
        var playListRepo = new JsonPlayListRepo(Path.Combine(dir, "playlists1.json"));
        //playListRepo.Insert(new PlayList("Un", songs[0], songs[3], songs[2]));
        //playListRepo.Insert(new PlayList("Deux", songs[1], songs[0]));
        //playListRepo.Insert(new PlayList("Un", songs[3]));
        var playLists = playListRepo.SelectAll();
        Console.WriteLine("Listes :");
        Console.WriteLine(string.Join("\n", playLists));*/

        var artistes = new List<Artist>();
        artistes.Add(new Artist("Metallica","www.metallica.com"));
        artistes.Add(new Artist("IronMaiden","www.ironmaiden.com"));

        var song1 = new List<Song>();
        song1.Add(new Song("Heros Of The Day", artistes[0], 253));
        song1.Add(new Song("Master Of Puppet", artistes[0], 501));
        //Song songt = new Song()

        PlayList playList1 = new PlayList("Metallaica");
        playList1.Add(song1[0]);
        playList1.song.Add(song1[1]);
        playList1.song.Add(new Song("Title", new Artist("Hi-Lo"),225));
        

        Console.WriteLine(artistes);
        Console.WriteLine(song1);
        Console.WriteLine(playList1.song[0]);
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