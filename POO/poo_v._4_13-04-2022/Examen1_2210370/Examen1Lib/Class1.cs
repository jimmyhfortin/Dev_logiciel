namespace Examen1Lib;

public class Song
{
   public int Id { get; set; }
   public string Title { get; set; }
   public string Artist { get; set; }
   public int Seconds { get; set; }
   public double Minutes { get; set; }

   public Song(string title, string artist, int seconds)
   {
      Title = title;
      Artist = artist;
      Seconds = seconds;
   }
}