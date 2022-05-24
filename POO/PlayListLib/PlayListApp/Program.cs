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
                Console.WriteLine("---Choisissez le mode souhaite---");
                Console.WriteLine("----[1] pour le mode Artiste-----");
                Console.WriteLine("----[2] pour le mode Chanson-----");
                Console.WriteLine("----[3] pour le mode PlayList-------");
                Console.WriteLine("----[0] pour quitter le programme");
                choix = ReadInt("Entrer un nombre entre 0 & 3 : ", 0, 3);
            } while (choix != 0 && choix != 1 && choix != 2 && choix != 3);

            if (choix == 0) break;
            if (choix == 1)
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("-------------Choisissez votre option-------------");
                    Console.WriteLine("----[1] pour afficher tout les Artistes----------");
                    Console.WriteLine("----[2] pour selectionner un Artiste avec son Id-");
                    Console.WriteLine("----[3] pour inserer un nouvel Artiste-----------");
                    Console.WriteLine("----[4] pour supprimer un Artist-----------------");
                    Console.WriteLine("----[0] pour quitter le programme----------------");
                    choix = ReadInt("Entrer un nombre entre 0 & 4 : ", 0, 4);
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

                        break;
                    case 3:
                        artists = artistRepo.SelectAll();
                        Console.WriteLine("Entrer le nom de l'Artiste a ajouter");
                        choix1 = Console.ReadLine();
                        artistRepo.Insert(new Artist(choix1));
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

                        break;
                }
            }

            if (choix == 2)
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("---------------Choisissez votre option--------------");
                    Console.WriteLine("----[1] pour afficher tout les Chansons-------------");
                    Console.WriteLine("----[2] pour selectionner une Chanson avec son Id---");
                    Console.WriteLine("----[3] pour inserer une nouvelle Chanson-----------");
                    Console.WriteLine("----[4] pour supprimer une Chanson------------------");
                    Console.WriteLine("----[0] pour quitter le programme-------------------");
                    choix = ReadInt("Entrer un nombre entre 0 & 4 : ", 0, 4);
                } while (choix != 0 && choix != 1 && choix != 2 && choix != 3 && choix != 4);

                switch (choix)
                {
                    case 0:
                        break;
                    case 1:
                        Console.Clear();
                        Console.WriteLine(string.Join("\n", songs));

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
                        break;
                    case 4:
                        songs = songRepo.SelectAll();
                        Console.WriteLine("Entrer l'Id de la Chanson a supprimer");
                        choix = int.Parse(Console.ReadLine());
                        songRepo.Delete(choix);
                        foreach (var song in songs)
                        {
                            if (choix == song.Id)
                            {
                                songRepo.Delete(song);
                            }
                        }

                        break;
                }
            }


            if (choix == 3)
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("---------------Choisissez votre option--------------");
                    Console.WriteLine("----[1] pour afficher tout les PlayList-------------");
                    Console.WriteLine("----[2] pour selectionner une PlayList avec son Nom---");
                    Console.WriteLine("----[3] pour inserer une nouvelle PlayList-----------");
                    Console.WriteLine("----[4] pour supprimer une PlayList------------------");
                    Console.WriteLine("----[0] pour quitter le programme-------------------");
                    choix = ReadInt("Entrer un nombre entre 0 & 4 : ", 0, 4);
                } while (choix != 0 && choix != 1 && choix != 2 && choix != 3 && choix != 4);

                switch (choix)
                {
                    case 0:
                        break;
                    case 1:
                        Console.WriteLine(string.Join("\n", playLists));

                        break;
                    case 2:
                        Console.WriteLine("Entrer le nom de la playList :");
                        choix1 = Console.ReadLine();
                        foreach (var playlist in playLists)
                        {
                            if (choix1 == playlist.Name)
                            {
                                Console.WriteLine(playlist.Name);
                            }
                        }

                        break;
                    case 3:
                        playLists = playListRepo.SelectAll();
                        Console.WriteLine("Entrer le titre de la PlayList a ajouter");
                        choix1 = Console.ReadLine();
                        playListRepo.Insert(new PlayList(choix1));
                        break;
                    case 4:
                        playLists = playListRepo.SelectAll();
                        Console.WriteLine("Entrer le nom de la PlayList a suprimer");
                        choix = int.Parse(Console.ReadLine());
                        playLists.Remove(choix);
                        for (int i = 0; i < playLists.Count; i++)
                        {
                            if (choix == playLists[i].songs.)
                            {
                                choix1.Remove(i);
                            }
                        }
                        /*foreach (var playlist in playLists)
                        {
                            if (choix1 == playlist.Name)
                            {
                                playListRepo.Delete(choix1);
                            }
                        }*/

                        break;
                }
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
    }
}