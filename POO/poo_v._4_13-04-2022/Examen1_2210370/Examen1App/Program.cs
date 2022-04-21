using System.Threading.Channels;
using Examen1Lib;


namespace Examen1App
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            Song song = new Song("Memory Romain", "Metallica", 322);
            Console.WriteLine(song);
            Song song2 = new Song("Sad but true", "Metallica", 468);
            Console.WriteLine(song2);

        }
    }
}            