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
        throw new NotImplementedException();
    }

    public override string Attack()
    {
        throw new NotImplementedException();
    }

    public override string Die()
    {
        throw new NotImplementedException();
    }
}