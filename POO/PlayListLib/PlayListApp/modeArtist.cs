using DataRepoLib;
using PlayListLib;

namespace PlayListApp;

public class modeArtist
{
    public static List<Artist> ModeArtist(List<Artist> artists)
    {
        int selectionInt = 0;
        string selectionString1 = "";
        string selectionString2 = "";


        do
        {
            Board.Print("Mode *ARTIST*",
                "[1] Afficher *Artiste* [2] Selection *Artist* Id [3] Creer *Artist* [4] supprimer *Artist*",
                "[0] *Quitter*");
            selectionInt = Program.ReadInt("Entrer un nombre entre 0 & 4 ->>>>: ", 0, 4);
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
        /*if (!Program.DemanderRejourer())
        {
            break;
        }*/

        Console.Clear();
        return artists;
        
        
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
    
}

