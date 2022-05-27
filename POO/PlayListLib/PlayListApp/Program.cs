using System.Net.Security;
using System.Net.Sockets;

using DataRepoLib;
using PlayListLib;

namespace PlayListApp;

public class Program
{
    static bool DemanderRejourer()
    {
        Console.WriteLine("Voulez-vous recommencer (o/n) : ");
        char answer = Convert.ToChar(Console.ReadLine());
        if ((answer == 'o') || (answer == 'O'))
        {
            return true;
        }

        if ((answer == 'n') || (answer == 'N'))
        {
            return false;
        }
        else
        {
            Console.WriteLine($"You should enter the correct letter");
            return DemanderRejourer();
        }
    }

    public static int ReadInt(string message, int start, int end)
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

    public static List<Artist> SupprimerArtists(Artist artiste)
    {
        string dir = Directory.GetParent(Environment.CurrentDirectory)?.Parent?.Parent?.FullName ?? "";
        var artistRepo = new JsonArtistRepo(Path.Combine(dir, "artists1.json"));
        artistRepo.Delete(artiste);
        var artists = artistRepo.SelectAll();
        return artists;
    }

    public static List<Artist> AjouterArtists(Artist artiste)
    {
        string dir = Directory.GetParent(Environment.CurrentDirectory)?.Parent?.Parent?.FullName ?? "";
        var artistRepo = new JsonArtistRepo(Path.Combine(dir, "artists1.json"));
        artistRepo.Insert(artiste);
        var artists = artistRepo.SelectAll();
        return artists;
    }

    public static List<Song> SupprimerChanson(Song songe)
    {
        string dir = Directory.GetParent(Environment.CurrentDirectory)?.Parent?.Parent?.FullName ?? "";
        var songRepo = new JsonSongRepo(Path.Combine(dir, "songs1.json"));
        songRepo.Delete(songe);
        var songs = songRepo.SelectAll();
        return songs;
    }
   public static List<Song> AjouterChasnon(Song songe)
    {
        string dir = Directory.GetParent(Environment.CurrentDirectory)?.Parent?.Parent?.FullName ?? "";
        var songRepo = new JsonSongRepo(Path.Combine(dir, "songs1.json"));
        songRepo.Insert(songe);
        var songs = songRepo.SelectAll();
        return songs;
    }

    /*static bool chansonexistante()
    {
        if
    }*/
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
        //playListRepo.Update(playListRepo.FileName.Insert(Metallica,songs[0]));
        var playLists = playListRepo.SelectAll();
        //Console.WriteLine("Listes :");
        //Console.WriteLine(string.Join("\n", playLists));

        // Fin de la partie A && B des insertions de donnees dans la base de donnees____________________________________
        // Partie C PlayListApp_________________________________________________________________________________________
        /*Song song1 = new Song("Alors Alors", artists[2], new Duration(0, 3, 12));
        songRepo.Insert(song1);
        Console.ReadLine();*/
        while (true)
        {
            int selectionInt = 0;
            string selectionString1 = "";
            string selectionString2 = "";

            do
            {
                Board.Print("Choisissez le mode", "[1] *Artiste* [2] *Chanson* [3] *PlayList*", "[0] *Quitter*");
                selectionInt = ReadInt("Entrer un nombre entre 0 & 3 ->>>>: ", 0, 3);
            } while (selectionInt != 0 && selectionInt != 1 && selectionInt != 2 && selectionInt != 3);

            if (selectionInt == 0) break;
            if (selectionInt == 1)
            {
                modeArtist(artists);
            }
            /*if (selectionInt == 1)
            {
                do
                {
                    Board.Print("Mode *ARTIST*",
                        "[1] Afficher *Artiste* [2] Selection *Artist* Id [3] Creer *Artist* [4] supprimer *Artist*",
                        "[0] *Quitter*");
                    selectionInt = ReadInt("Entrer un nombre entre 0 & 4 ->>>>: ", 0, 4);
                } while (selectionInt != 0 && selectionInt != 1 && selectionInt != 2 && selectionInt != 3 &&
                         selectionInt != 4);

                switch (selectionInt)
                {
                    case 0:
                        break;
                    case 1: // Fonctionne

                        foreach (var artist in artists)
                        {
                            Console.WriteLine(artist);
                        }

                        Console.ReadKey();


                        break;
                    case 2: // Fonctionne
                        Console.WriteLine("Entrer l'Id de l'Artist :");
                        selectionInt = int.Parse(Console.ReadLine());

                        for (int i = 0; i < artists.Count; i++)
                        {
                            //if (selectionInt.Equals(artists[i].Id))

                            if (selectionInt == artists[i].Id)
                            {
                                Console.WriteLine(artists[i]);
                                break;
                            }
                        }

                        Console.ReadKey();
                        break;
                    case 3: // Fonctionne 
                        Console.WriteLine("Entrer le nom de l'Artiste a ajouter");
                        selectionString1 = Console.ReadLine();
                        bool existant = false;
                        for (int i = 0; i < artists.Count; i++)
                        {
                            if (selectionString1 == (artists[i].Name))
                            {
                                existant = true;
                                Console.WriteLine($"Artiste deja existant");
                                break;
                            }
                            
                        }
                        if (!existant)
                        {
                            artists = AjouterArtists(new Artist(selectionString1));
                            Board.Endmessage("Artist", "ajouté");
                            break;
                        }
                        
                        Console.ReadKey();
                        break;

                    case 4: // Fonctionne
                        Console.WriteLine("Entrer l'Id de l'artiste a supprimer");
                        selectionInt = int.Parse(Console.ReadLine());

                        for (int i = 0; i < artists.Count; i++)
                        {
                            if (selectionInt == artists[i].Id)
                            {
                                artists = SupprimerArtists(artists[i]);
                                break;
                            }
                        }

                        Board.Endmessage("Artist", "supprimé");
                        //Console.WriteLine($"Id invalide");/////////////////////////////////////////////
                        Console.ReadKey();
                        break;
                }
            }

            else if (selectionInt == 2)
            {
                do
                {
                    Board.Print("Mode *CHANSON*",
                        "[1] Afficher *Chansons* [2] Selection *Id-Chanson* \n|[3] Creer *Chanson* avec nouveau *Artiste* [4] Creer *Chanson* [5] suprimer *Chanson*",
                        "[0] *Quitter*");
                    selectionInt = ReadInt("Entrer un nombre entre 0 & 4 ->>>>: ", 0, 4);
                } while (selectionInt != 0 && selectionInt != 1 && selectionInt != 2 && selectionInt != 3 &&
                         selectionInt != 4 &&  selectionInt != 5);

                switch (selectionInt)
                {
                    case 0:
                        break;
                    case 1: // Fonctionne
                        Console.WriteLine(string.Join("\n", songs));
                        Console.ReadKey();
                        break;
                    case 2: // Fonctionne
                        Console.WriteLine("Entrer l'Id de la Chanson :");
                        selectionInt = int.Parse(Console.ReadLine());
                        foreach (var song in songs) // utiliser la methode find
                        {
                            if (selectionInt == song.Id)
                            {
                                Console.WriteLine(song);
                            }
                        }
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.WriteLine("Entrer le titre de la Chanson a ajouter");
                        selectionString1 = Console.ReadLine();
                        Console.WriteLine("Entrer le nouveau *Artist* de la Chanson a ajouter");
                        selectionString2 = Console.ReadLine();
                        Console.WriteLine("Entrer la duree de la Chanson a ajouter en seconde");
                        selectionInt = int.Parse(Console.ReadLine());
                        for (int i = 0; i < songs.Count; i++)
                        {
                            if (selectionString1 != songs[i].Title)
                            {
                                songs = AjouterChasnon(new Song(selectionString1, new Artist(selectionString2), selectionInt));
                                Board.Endmessage("Nouvelle chansson & nouvelle Artiste", "créé");
                                break;
                            }
                        }
                        //songRepo.Insert(new Song(selectionString1, new Artist(selectionString2), selectionInt));
                        //Board.Endmessage("Chanson", "cree");
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.WriteLine("Entrer le titre de la Chanson a ajouter");
                        selectionString1 = Console.ReadLine();
                        Console.WriteLine("Entrer l'Artist de la Chanson a ajouter");
                        selectionString2 = Console.ReadLine();
                        Console.WriteLine("Entrer la duree de la Chanson a ajouter en seconde");
                        selectionInt = int.Parse(Console.ReadLine());
                        for (int i = 0; i < songs.Count; i++)
                        {
                            if (selectionString2 != artists[i].Name)
                            {
                                Board.Endmessage("Artist", "invalide");
                                //songs = AjouterChasnon(new Song(selectionString1, new Artist(selectionString2), selectionInt));
                                break;
                            }
                            if (selectionString2 == artists[i].Name)
                            {
                                Console.ReadLine();
                                songs = AjouterChasnon(new Song(selectionString1, artists[i], selectionInt));
                                Board.Endmessage("Nouvelle chansson", "créé");
                                break;
                            }
                        }
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.WriteLine("Entrer l'Id de la Chanson a supprimer");
                        selectionInt = int.Parse(Console.ReadLine());
                        for (int i = 0; i < songs.Count; i++)
                        {
                            if (selectionInt == songs[i].Id)
                            {
                                songs = SupprimerChanson(songs[i]);
                                break;
                            }
                        }
                        Board.Endmessage("Chanson", "supprimé");
                        Console.ReadKey();
                        break;
                }
            }


            else if (selectionInt == 3)
            {
                do
                {
                    Board.Print("Mode *PLAYLIST*",
                        "[1] Afficher *PlayList* [2] Selection nom *PlayList* [3] Creer *PlayList* [4] suprimer *Chanson* [5] inserer *Chanson*",
                        "[0] *Quitter*");
                    selectionInt = ReadInt("Entrer un nombre entre 0 & 4 : ", 0, 4);
                } while (selectionInt != 0 && selectionInt != 1 && selectionInt != 2 && selectionInt != 3 &&
                         selectionInt != 4 && selectionInt != 5);

                switch (selectionInt)
                {
                    case 0:
                        break;
                    case 1:
                        Console.WriteLine(string.Join("\n", playLists));
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.WriteLine("Entrer le nom de la playList :");
                        selectionString1 = Console.ReadLine();
                        foreach (var playlist in playLists)
                        {
                            if (selectionString1 == playlist.Name)
                            {
                                Console.WriteLine(playlist);
                            }
                        }

                        Console.ReadKey();
                        break;
                    case 3: // condition si une nouvelle playlist a le meme nom
                        Console.WriteLine("Entrer le titre de la PlayList a ajouter");
                        selectionString1 = Console.ReadLine();
                        playListRepo.Insert(new PlayList(selectionString1));
                        Console.ReadKey();
                        break;
                    case 4: // marche pas
                        Console.WriteLine("Entrer le nom de la PlayList a supprimer");
                        selectionString1 = Console.ReadLine();
                        //playLists.Remove(choix1);
                        /*for (int i = 0; i < playLists.Count; i++)
                        {
                            if (choix == playLists[i].Songs)
                            {
                                playLists.Remove(choix);
                            }
                        }#1#

                        foreach (var playlist in playLists)
                        {
                            if (selectionString1 == playlist.Name)
                            {
                                playListRepo.Delete(playlist);
                                //choix.Delete(choix);
                            }
                        }

                        Console.ReadKey();
                        break;
                    case 5:
                        Console.WriteLine("Entrer l'Id de la Chanson a ajouter");
                        selectionInt = int.Parse(Console.ReadLine());
                        Console.WriteLine("Entrer le nom de la PlayList a lequel la Chanson va etre ajoute");
                        selectionString1 = Console.ReadLine();
                        //selectionString2 = existingSongs.Find(Console.ReadLine());
                        /*foreach (var playlist in playLists)
                        {
                            if (selectionString1.Equals(playlist.Name))
                            {
                                
                                playLists.Insert(songs[selectionInt],selectionInt);
                                playLists.Insert(selectionString1[selectionInt],);
                                playlist.Add(selectionInt);
                                //choix.Delete(choix);
                                
                            }
                        }#1#

                        Console.ReadKey();
                        break;
                }
            }

            if (!DemanderRejourer())
            {
                break;
            }*/

            Console.Clear();

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