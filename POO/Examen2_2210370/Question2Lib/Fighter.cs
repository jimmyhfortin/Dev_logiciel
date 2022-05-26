namespace Question2Lib;

public class Fighter : Character
{
    public Fighter(int id, string name, int strength, int dexterity, int constitution, int intelligence, int wisdom, int charisma) : base(id, name, strength, dexterity, constitution, intelligence, wisdom, charisma)
    {
    }

    public Fighter(string name, int strength, int dexterity, int constitution, int intelligence, int wisdom, int charisma) : base(name, strength, dexterity, constitution, intelligence, wisdom, charisma)
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