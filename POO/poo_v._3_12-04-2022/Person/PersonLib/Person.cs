﻿namespace PersonLib;

public class Person
{
    private string _name;
    public int Id { get; }
    public string Name
    {
        get => _name;
        set
        {
            if (value.Length < 2)
            {
                throw new ArgumentException("the name must be at least 2 characters long");
            }
            _name = value;
        }
    }

    public DateOnly Dob { get; set; }

    public int Age => Convert.ToInt32((DateTime.Today - Dob.ToDateTime(new TimeOnly(0,0))).Days / 365.25);

    public Person(int id, string name, DateOnly dob)
    {
        Id = id;
        Name = name;
        Dob = dob;
    }

    public override bool Equals(object? obj)
    {
        if (obj == null || this.GetType() != obj.GetType())
        {
            return false;
        }

        Person other = (Person)obj;
        // return Name.Equals(other.Name) && Dob.Equals(other.Dob);
        return Id == other.Id;
    }

    public override int GetHashCode()
    {
        // return HashCode.Combine(Name, Dob);
        return Id.GetHashCode();
    }

    public override string ToString()
    {
        return $"Person({Id}, {Name}, {Dob})";
    }
}