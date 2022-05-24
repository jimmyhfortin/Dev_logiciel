using System.Net.Security;
using System.Net.Sockets;
using DataRepoLib;
using PlayListLib;

namespace PlayListApp;

public class Program
{
    static int ReadInt(string message, int start, int end)
    {
        while (true)
        {
            Console.Write(message);
            try
            {
                int result = int.Parse(Console.ReadLine());
                if (result >= start && result <= end)
                {
                    return result;
                }

                Console.WriteLine($"Le nombre doit être entre {start} et {end} inclusivement");
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception ! " + e.Message);
            }
        }
    }

    static void Main(string[] args)
    {
        // Partie A PLayListLib && partie B DataRepoLib_________________________________________________________________
        // Insertion de donnees dans la base de donnees de type.json____________________________________________________
        string dir = Directory.GetParent(Environment.CurrentDirectory)?.Parent?.Parent?.FullName ?? "";

        var artistRepo = new JsonArtistRepo(Path.Combine(dir, "artists1.json"));
        var artists = artistRepo.SelectAll();

        // artistRepo.Insert(new Artist("Metallica","www.metallica.com"));
        // artistRepo.Insert(new Artist("Iron Maiden", "www.ironmaiden.com"));
        // artistRepo.Insert(new Artist("Dumas"));
        // artistRepo.Insert(new Artist("Paul Plamondon"));
        artists = artistRepo.SelectAll();
        //Console.WriteLine("Artistes :");
        //Console.WriteLine(string.Join("\n", artists));

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
        //Console.WriteLine("Chansons :");
        //Console.WriteLine(string.Join("\n", songs));


        var playListRepo = new JsonPlayListRepo(Path.Combine(dir, "playlists1.json"));
        // playListRepo.Insert(new PlayList("Metallica", songs[0], songs[1], songs[2], songs[3]));
        // playListRepo.Insert(new PlayList("Iron Maiden", songs[4], songs[5], songs[6], songs[7]));
        // playListRepo.Insert(new PlayList("Dumas", songs[8], songs[9],songs[10]));
        playListRepo.Songs.Add(songs[8]);
        var playLists = playListRepo.SelectAll();
        //Console.WriteLine("Listes :");
        //Console.WriteLine(string.Join("\n", playLists));

        // Fin de la partie A && B des insertions de donnees dans la base de donnees____________________________________
        // Partie C PlayListApp_________________________________________________________________________________________

        while (true)
        {
            int choix = 0;
            string choix1 = "";
            string choix2 = "";

            do
            {
                Board.Print("Choisissez le mode", "[1] *Artiste* [2] *Chanson* [3] *PlayList*", "[0] *Quitter*");
                choix = ReadInt("Entrer un nombre entre 0 & 3 ->>>>: ", 0, 3);
            } while (choix != 0 && choix != 1 && choix != 2 && choix != 3);

            if (choix == 0) break;
            if (choix == 1)
            {
                do
                {
                    Board.Print("Mode *ARTIST*", "[1] Afficher *Artiste* [2] Selection *Artist* Id [3] Creer *Artist* [4] supprimer *Artist*", "[0] *Quitter*");
                    choix = ReadInt("Entrer un nombre entre 0 & 4 ->>>>: ", 0, 4);
                } while (choix != 0 && choix != 1 && choix != 2 && choix != 3 && choix != 4);

                switch (choix)
                {
                    case 0:
                        break;
                    case 1:
                        
                        foreach (var artist in artists)
                        {
                            Console.WriteLine(artist);
                        }
                        Thread.Sleep(10000);

                        break;
                    case 2:
                        Console.WriteLine("Entrer l'Id de l'Artist :");
                        choix = int.Parse(Console.ReadLine());
                        foreach (var artist in artists)
                        {
                            if (choix == artist.Id)
                            {
                                Console.WriteLine(artist);
                            }
                        }
                        Thread.Sleep(10000);
                        break;
                    case 3:
                        artists = artistRepo.SelectAll();
                        Console.WriteLine("Entrer le nom de l'Artiste a ajouter");
                        choix1 = Console.ReadLine();
                        artistRepo.Insert(new Artist(choix1));
                        Thread.Sleep(10000);
                        break;

                    case 4:
                        artists = artistRepo.SelectAll();
                        Console.WriteLine("Entrer l'Id de l'artiste a supprimer");
                        choix = int.Parse(Console.ReadLine());
                        //artistRepo.Delete(artists(choix));
                        foreach (var artist in artists)
                        {
                            if (choix == artist.Id)
                            {
                                artistRepo.Delete(artist);
                            }
                        }
                        Thread.Sleep(10000);
                        break;
                }
            }

            else if (choix == 2)
            {
                do
                {
                    Board.Print("Mode *CHANSON*", "[1] Afficher *Chansons* [2] Selection *Id-Chanson* [3] Creer *Chanson* [4] suprimer *Chanson*", "[0] *Quitter*");
                    choix = ReadInt("Entrer un nombre entre 0 & 4 ->>>>: ", 0, 4);
                } while (choix != 0 && choix != 1 && choix != 2 && choix != 3 && choix != 4);

                switch (choix)
                {
                    case 0:
                        break;
                    case 1:
                        
                        Console.WriteLine(string.Join("\n", songs));
                        Thread.Sleep(10000);

                        break;
                    case 2:
                        songs = songRepo.SelectAll();
                        Console.WriteLine("Entrer l'Id de la Chanson :");
                        choix = int.Parse(Console.ReadLine());
                        foreach (var song in songs) // utiliser la methode find
                        {
                            if (choix == song.Id)
                            {
                                Console.WriteLine(song);
                            }
                        }
                        Thread.Sleep(10000);
                        break;
                    case 3: // plusieurs conditions a verifier manquante (si l'artist exisite et le chanson aussi)
                        songs = songRepo.SelectAll();
                        Console.WriteLine("Entrer le titre de la Chanson a ajouter");
                        choix1 = Console.ReadLine();
                        Console.WriteLine("Entrer l'Artist de la Chanson a ajouter");
                        choix2 = Console.ReadLine();
                        Console.WriteLine("Entrer la duree de la Chanson a ajouter en seconde");
                        choix = int.Parse(Console.ReadLine());
                        songRepo.Insert(new Song(choix1, new Artist(choix2), choix));
                        Thread.Sleep(10000);
                        break;
                    case 4:
                        songs = songRepo.SelectAll();
                        Console.WriteLine("Entrer l'Id de la Chanson a supprimer");
                        choix = int.Parse(Console.ReadLine());
                        foreach (var song in songs)
                        {
                            if (choix == song.Id)
                            {
                                songRepo.Delete(song);
                            }
                        }
                        Thread.Sleep(10000);
                        break;
                }
            }


            else if (choix == 3)
            {
                do
                {
                    Board.Print("Mode *PLAYLIST*", "[1] Afficher *PlayList* [2] Selection nom *PlayList* [3] Creer *PlayList* [4] suprimer *Chanson* [5] inserer *Chanson*","[0] *Quitter*");
                    choix = ReadInt("Entrer un nombre entre 0 & 4 : ", 0, 4);
                } while (choix != 0 && choix != 1 && choix != 2 && choix != 3 && choix != 4 && choix != 5);

                switch (choix)
                {
                    case 0:
                        break;
                    case 1:
                        Console.WriteLine(string.Join("\n", playLists));
                        Thread.Sleep(10000);
                        break;
                    case 2:
                        Console.WriteLine("Entrer le nom de la playList :");
                        choix1 = Console.ReadLine();
                        foreach (var playlist in playLists)
                        {
                            if (choix1 == playlist.Name)
                            {
                                Console.WriteLine(playlist);
                            }
                        }
                        Thread.Sleep(10000);
                        break;
                    case 3: // condition si une nouvelle playlist a le meme nom
                        playLists = playListRepo.SelectAll();
                        Console.WriteLine("Entrer le titre de la PlayList a ajouter");
                        choix1 = Console.ReadLine();
                        playListRepo.Insert(new PlayList(choix1));
                        Thread.Sleep(10000);
                        break;
                    case 4: // marche pas
                        playLists = playListRepo.SelectAll();
                        Console.WriteLine("Entrer le nom de la PlayList a supprimer");
                        choix1 = Console.ReadLine();
                        //playLists.Remove(choix1);
                        /*for (int i = 0; i < playLists.Count; i++)
                        {
                            if (choix == playLists[i].Songs)
                            {
                                playLists.Remove(choix);
                            }
                        }*/
                        
                        foreach (var playlist in playLists)
                        {
                            if (choix1 == playlist.Name)
                            {
                                playListRepo.Delete(playlist);
                                //choix.Delete(choix);
                                
                            }
                        }
                        Thread.Sleep(10000);
                        break;
                    case 5:
                        playLists = playListRepo.SelectAll();
                        Console.WriteLine("Entrer l'Id de la Chanson a ajouter");
                        choix = int.Parse(Console.ReadLine()); 
                        Console.WriteLine("Entrer le nom de la PlayList a lequel la Chanson va etre ajoute");
                        choix1 = Console.ReadLine();
                        foreach (var playlist in playLists)
                        {
                            if (choix1 == playlist.Name)
                            {
                                playListRepo.Insert(playlist.choix1, choix);
                                //choix.Delete(choix);
                                
                            }
                        }

                        Thread.Sleep(10000);
                        break;

                }
                
            }
            else break;


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
    }
}