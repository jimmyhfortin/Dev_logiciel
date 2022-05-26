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
        return $"Until the END!";
    }

    public override string Attack()
    {
        return $"You gonna die MOFO!";
    }

    public override string Die()
    {
        return $"Holy HELL!";
    }
}