namespace Question2Lib;

public class Druid : Character
{
    public Druid(int id, string name, int strength, int dexterity, int constitution, int intelligence, int wisdom, int charisma) : base(id, name, strength, dexterity, constitution, intelligence, wisdom, charisma)
    {
    }

    public Druid(string name, int strength, int dexterity, int constitution, int intelligence, int wisdom, int charisma) : base(name, strength, dexterity, constitution, intelligence, wisdom, charisma)
    {
    }

    public override string Speak()
    {
        return $"Did we just break devoted druid?";
    }

    public override string Attack()
    {
        return $"I knew this would happen some day";
    }

    public override string Die()
    {
        return $"Again?";
    }
}