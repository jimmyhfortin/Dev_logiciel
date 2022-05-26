namespace Question2Lib;

public abstract class Character
{
    public static int NextId { get; set; } = 1;
    private int _id;
    public int Id
    {
        get => _id;
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Id cannot be negative");
            }

            _id = value;
        }

    }
    public string Name { get; set; }
    private int _strength;
    public int Strength
    {
        get => _strength;
        set
        {
            if (value < 3 || value > 20)
            {
                throw new ArgumentException("character skill must be between 3 and 20");
            }

            _strength = value;
        }

    }

    private int _dexterity;
    public int Dexterity
    {
        get => _dexterity;
        set
        {
            if (value < 3 || value > 20)
            {
                throw new ArgumentException("character skill must be between 3 and 20");
            }

            _dexterity = value;
        }

    }

    private int _constitution;
    public int Constitution
    {
        get => _constitution;
        set
        {
            if (value < 3 || value > 20)
            {
                throw new ArgumentException("character skill must be between 3 and 20");
            }

            _constitution = value;
        }

    }

    private int _intelligence;
    public int Intelligence
    {
        get => _intelligence;
        set
        {
            if (value < 3 || value > 20)
            {
                throw new ArgumentException("character skill must be between 3 and 20");
            }

            _intelligence = value;
        }

    }

    private int _wisdom;
    public int Wisdom 
    {
        get => _wisdom;
        set
        {
            if (value < 3 || value > 20)
            {
                throw new ArgumentException("character skill must be between 3 and 20");
            }

            _wisdom = value;
        }

    }

    private int _charisma;
    public int Charisma 
    {
        get => _charisma;
        set
        {
            if (value < 3 || value > 20)
            {
                throw new ArgumentException("character skill must be between 3 and 20");
            }

            _charisma = value;
        }

    }

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

    public abstract string Speak();


    public abstract string Attack();


    public abstract string Die();
    

    public override bool Equals(object? obj)
    {
        if (obj == null || this.GetType() != obj.GetType())
        {
            return false;
        }

        Character other = (Character)obj;
        return Id == other.Id;
    }

    public override int GetHashCode()
    {
        return Id.GetHashCode();
    }

    public override string ToString()
    {
        //return $"({base.GetType()}) ({Id}) {Name} [{Strength} {Dexterity} {Constitution} {Intelligence} {Wisdom} {Charisma}]";
        return $"({GetType().Name}) ({Id}) {Name} [{Strength} {Dexterity} {Constitution} {Intelligence} {Wisdom} {Charisma}]";
    }
}