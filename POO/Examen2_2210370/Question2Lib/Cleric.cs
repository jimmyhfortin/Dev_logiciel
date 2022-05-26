namespace Question2Lib;

public class Cleric : Character
{
    public Cleric(int id, string name, int strength, int dexterity, int constitution, int intelligence, int wisdom, int charisma) : base(id, name, strength, dexterity, constitution, intelligence, wisdom, charisma)
    {
    }

    public Cleric(string name, int strength, int dexterity, int constitution, int intelligence, int wisdom, int charisma) : base(name, strength, dexterity, constitution, intelligence, wisdom, charisma)
    {
    }

    public override string Speak()
    {
        return $"Drive a motorcycle instead";
    }

    public override string Attack()
    {
        return $"From blackest night and Brightest sky";
    }

    public override string Die()
    {
        return $"The Blackest Night falls from the skies, The darkness grows as all light dies";
    }

    
}