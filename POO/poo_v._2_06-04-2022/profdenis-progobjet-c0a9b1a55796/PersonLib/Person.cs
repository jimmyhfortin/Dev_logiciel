namespace PersonLib;

public class Person
{
    private string _name;
    private int _id;

    public int Id
    {
        get => _id;
        set
        {
            _id = 1 + _id;
            for (int i = _id; i <= _id; i++)
            {
                _id++;
            }

            
        }
    }

    public string Name
    {
        get => _name;
        set
        {
            if (value.Length < 2)
            {
                throw new ArgumentException("the bname must be at leat 2 chararcter long");
            }
        }
    }

    public DateOnly Dob { get; set; }
    
    public int Age => Convert.ToInt32((DateTime.Today - Dob.ToDateTime(new TimeOnly(0,0))).Days /365.25);
    


    public Person(int _id, string name, DateOnly dob)
    {
        Id = _id;
        Name = name;
        Dob = dob;
    }

    public Person()
    {
        throw new NotImplementedException();
    }

    public override bool Equals(object? obj)
    {
        if (obj == null || GetType() != obj.GetType())
        {
            return false;
        }

        Person other = (Person) obj;
        //return Name.Equals(other.Name) && Dob.Equals(other.Dob);
        return Id == other.Id;

    }

    public override int GetHashCode()
    {
        //return HashCode.Combine(Name, Dob);
        return Id.GetHashCode();
    }

    public override string ToString()
    {
        return $"Person({Id}, {Name}, {Dob})";
    }
}