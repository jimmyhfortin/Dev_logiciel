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
        //FileStream fileStream = File.OpenWrite(filename);
        //Words = new List<string>(fileStream);
        //FileStream fileStream = File.OpenWrite(filename);
        Words = new List<string> {File.ReadAllText(filename)};
    }

    public string GetRandomWord()
    {
        Random random = new Random();
        int randomNum = random.Next(1, 12);

        string line = null;
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
        }
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
        return line;
    }

    public override bool Equals(object? obj)
    {
        return base.Equals(obj);
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }

    public override string ToString()
    {
        return base.ToString();
    }
}