﻿
using Question1Lib;

namespace Question1App
{
    public class Program
{
    /*static string GetRandomWord(List<string> liste)
    {
        string[] listeArray = liste.ToArray();
        Random random = new Random();
        int randomNum = random.Next(1,listeArray.Length);
        //int index = liste.FindIndex(1 => 1);
        //int index = liste.IndexOf(randomNum);
        return listeArray[randomNum];
    }*/
    /*static string GetRandomWord(List<string> liste)
    {
        Random random = new Random();
        int randomNum = random.Next(1,liste.Count);
        return liste[randomNum];
    }*/
    static void Main(string[] args)
    {
        string line;
        try
        {
            //Pass the file path and file name to the StreamReader constructor
            StreamReader sr = new StreamReader("/home/jimmy/filename.txt");
            //Read the first line of text
            line = sr.ReadLine();
            //Continue to read until you reach end of file
            while (line != null)
            {
                //write the line to console window
                Console.WriteLine(line);
                //Read the next line
                line = sr.ReadLine();
            }

            //close the file
            sr.Close();
            Console.ReadLine();
        }
        catch (Exception e)
        {
            Console.WriteLine("Exception: " + e.Message);
        }
        finally
        {
            Console.WriteLine("Executing finally block.");
        }
        // string dir = Directory.GetParent(Environment.CurrentDirectory)?.Parent?.Parent?.FullName ?? "";
        // string filename = new (Path.Combine(dir, "filename.txt"));
        /*string text = File.ReadAllText("/home/jimmy/filename.txt");
        Console.WriteLine(text);
        WordList essai = new WordList("essai1");
        essai.GetRandomWord();*/
        
        /*string[] lineFileName = File.ReadAllLines("/home/jimmy/filename.txt");
        for (int i = 0; i < lineFileName.Length; i++)
        {
            Console.WriteLine(lineFileName[i]);
        }*/
        //List<string> lineDileName = File.ReadAllLines("/home/jimmy/filename.txt");
        WordList liste2 = new WordList("liste1", new List<string>()
        {
            "home", 
            "boat", 
            "chair", 
            "car", 
            "spoon"
        });
        var essaie = liste2;
        Console.WriteLine(liste2.GetRandomWord());
        
        
      
        



    }
}
}

