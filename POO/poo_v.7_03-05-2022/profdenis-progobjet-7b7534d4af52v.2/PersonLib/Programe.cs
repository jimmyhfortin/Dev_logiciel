namespace PersonLib;

public class Programe
{
    public string Name { get; set; }
    public List<Course> courses { get; set; }

    public Programe(string name)
    {
        Name = name;
        courses = new List<Course>();
    }

    public Programe(string name, params Course[] courses)
    {
        Name = name;
        this.courses = new List<Course>(courses);
    }

    public override bool Equals(object? obj)
    {
        if (obj == null || this.GetType() != obj.GetType())
        {
            return false;
        }

        Programe other = (Programe) obj;
        return Name.Equals(other.Name);
    }

    public override int GetHashCode()
    {
        return Name.GetHashCode();
    }

    public override string ToString()
    {
        return $"Program({Name})\n{string.Join("\n", courses)};";
    }
}