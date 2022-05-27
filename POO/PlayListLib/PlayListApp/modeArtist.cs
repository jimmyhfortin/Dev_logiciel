using PlayListLib;

namespace PlayListApp;

public class modeArtist
{
    public List<Artist> ModeArtist(List<Artist> artists)
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
                    artists = Program.AjouterArtists(new Artist(selectionString1));
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
                        artists = Program.SupprimerArtists(artists[i]);
                        break;
                    }
                }

                Board.Endmessage("Artist", "supprimé");
                //Console.WriteLine($"Id invalide");/////////////////////////////////////////////
                Console.ReadKey();
                break;
        }

        return artists;
    }
}

