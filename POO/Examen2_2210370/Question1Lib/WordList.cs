using System.Text.RegularExpressions;

namespace Question1Lib;


public class WordList
{
    public string Name { get; set; }
    public List<string> Words { get; set; }
    public int Count { get; set; }

    public WordList(String name)
    {
        Name = name;
    }

    public WordList(String name, List<string> words)
    {
        Name = name;
        Words = words;
    }

    public WordList(String name, params string[] words)
    {
        Name = name;
        Words = new List<string>(words);
    }

    public WordList(string name, List<string> words, int count)
    {
        Name = name;
        Words = words;
        Count = count;
    }

    public WordList(string name, string filename) 
    {
        Name = name;
        string[] lineFileName = File.ReadAllLines("filename.txt");
        string[] listeArray = lineFileName.ToArray();
        Words = new List<string>(listeArray);
    }

    public string GetRandomWord() // Lake of time for that method sorry...She's not perfect but not far at least I hope so.
    {
        
        string[] lineFileName = File.ReadAllLines("filename.txt");
        string[] listeArray = lineFileName.ToArray();
        List<string> words = new List<string>(listeArray);
        Random random = new Random();
        int randomNum = random.Next(1,words.Count);
        for (int i = 0; i < words.Count; i++)
        {
            if (words[randomNum] == words[i])
            {
                File.Delete(words[i]);
                words.Remove(words[i]);
            }
            else
            {
                Console.WriteLine(words[randomNum]);
                throw new ArgumentException("No more word in the list");
            }
        }
        //Regex.Replace(XML, @"\s+", "");
        
        return Words[randomNum];
        
        /*string line = null;
        int line_number = 0;

        using (StreamReader reader = new StreamReader("/home/jimmy/filename.txt"))
        {
            using (StreamWriter writer = new StreamWriter("/home/jimmy/filename.txt"))
            {
                while ((line = reader.ReadLine()) != null)
                {
                    line_number++;

                    if (line_number == randomNum)
                        continue;

                    writer.WriteLine(line);
                }
            }
        }*/
        // int[] numbers = File.ReadAllLines("/home/jimmy/filename.txt").Select(int.Parse).ToArray();
        // Console.WriteLine($"Read: [{string.Join(", ", numbers)}]");


        /*string[] lineFileName = File.ReadAllLines("/home/jimmy/filename.txt");
        List<string> fileNameList = new List<string>(lineFileName);
        for (int i = 0; i < fileNameList.Count; i++)
        {
            if (fileNameList[i] == randomNum)
            {
                
            }
            File.WriteAllLines("/home/jimmy/filename.txt", File.ReadLines("/home/jimmy/filename.txt").Where(l => l != "removeme").ToList());
            Console.WriteLine(fileNameList[i]);
        }*/
    }

    public override bool Equals(object? obj)
    {
        if (obj == null || this.GetType() != obj.GetType())
        {
            return false;
        }

        WordList other = (WordList)obj;
        return Name.Equals(other.Name) && Count.Equals(other.Count);
    }

    public override int GetHashCode()
    {
        return Name.GetHashCode();
    }

    public override string ToString()
    {
        return $"Person({Name}, {Count}, {string.Join("\n", Words)})";
    }
}