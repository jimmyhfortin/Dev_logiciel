using System.Threading.Channels;
using Examen1Lib;


namespace Examen1App
{
    public class Program
    {
        static int ReadInt(string message)
    {
        bool ok = false;
        int result = -1;
        while(true)
        {
            Console.Write(message);
            string reponse = Console.ReadLine();
            try
            {
                int reponseInt = int.Parse(reponse);
                return reponseInt;
            }
            catch
            {
                Console.WriteLine("ERREUR : Vous devez rentrer un nombre");
            }
        }
        /*while (result != 0)
        {
            Console.Write(message);
            ok = int.TryParse(Console.ReadLine(), out result);
        }*/

        return result;
    }
        static void Main(string[] args)
        {
            //PartA_____________________________________________________________________________________________________ 
            Song song = new Song("Memory Romain", "Metallica", 322);
            Console.WriteLine(song);
            Song song2 = new Song("Sad but true", "Metallica", 468);
            Console.WriteLine(song2);
            Console.WriteLine(song.Equals(song2));


            //PartB_____________________________________________________________________________________________________


            //### Partie C : l'application______________________________________________________________________________
            var metallica1 = new PlayList("Metallica");
            metallica1.SongList.Add(new Song("Fuel", "Metallica", 258));
            metallica1.SongList.Add(new Song("Heros Of The Day", "Metallica", 253));
            metallica1.SongList.Add(new Song("Kall of kluklu", "Metallica", 512));
            metallica1.SongList.Add(new Song("Master Of Puppet", "Metallica", 501));
            Console.WriteLine($"{metallica1.SongList}");

            var metallica2 = new PlayList("Symphonique Metallica");
            metallica2.SongList.Add(new Song("Master Of Puppet", "Metallica", 501));
            metallica2.SongList.Add(new Song("Of Wolf And Man", "Metallica", 287));
            metallica2.SongList.Add(new Song("No Leaf Clover", "Metallica", 326));
            metallica2.SongList.Add(new Song("Nothing Else Matters", "Metallica", 388));

            var tomorrowland = new PlayList("Tomorrowland Belgium 2018");
            tomorrowland.SongList.Add(new Song("Balearic Mornings", "Hi-LO", 270));
            tomorrowland.SongList.Add(new Song("Element Of A New Life", "VerWest", 195));
            tomorrowland.SongList.Add(new Song("Si Soy Fuego", "Paul Kalkbrenner", 312));
            tomorrowland.SongList.Add(new Song("Stars", "Luke Bond", 205));
            Console.WriteLine($"{metallica1.TotalLength()}");
            while (true)
            {
                int choice = 0;
                do
                {
                    Console.WriteLine($"Make a choice between these *play list*");
                    Console.WriteLine($"Choice [1] for ({metallica1.Name})");
                    Console.WriteLine($"Choice [2] for ({metallica2.Name})");
                    Console.WriteLine($"Choice [3] for ({tomorrowland.Name})");
                    Console.WriteLine($"Choice [0] for (quit)");
                    choice = int.Parse(Console.ReadLine());
                } while (choice != 0 && choice != 1 && choice != 2 && choice != 3);

                if (choice == 0) break;
                if (choice == 1)Console.WriteLine($"{metallica1.SongList} \n{metallica1.TotalLength()}");
                else if (choice == 2)Console.WriteLine($"{metallica2.SongList} \n{metallica2.TotalLength()}");
                else if (choice == 3)Console.WriteLine($"{tomorrowland.SongList} \n{tomorrowland.TotalLength()}");
                Console.WriteLine("Press any key to restart");
                Console.ReadKey();
            }
           

            


           
        }
    }
}