namespace Question2Lib;

public class Character
{
    public static int NextId { get; set; } = 1;
    public int Id { get; set; }
    public string Name { get; set; }
    public int Strength { get; set; }
    public int Dexterity { get; set; }
    public int Constitution { get; set; }
    public int Intelligence { get; set; }
    public int Wisdom { get; set; }
    public int Charisma { get; set; }

    public Character(int id, string name, int strength, int dexterity, int constitution, int intelligence, int wisdom, int charisma)
    {
        Id = id;
        Name = name;
        Strength = strength;
        Dexterity = dexterity;
        Constitution = constitution;
        Intelligence = intelligence;
        Wisdom = wisdom;
        Charisma = charisma;
    }
    public Character(string name, int strength, int dexterity, int constitution, int intelligence, int wisdom, int charisma)
    {
        Id = NextId;
        NextId++;
        Name = name;
        Strength = strength;
        Dexterity = dexterity;
        Constitution = constitution;
        Intelligence = intelligence;
        Wisdom = wisdom;
        Charisma = charisma;
    }
}