namespace PersonLib;

public class Course
{
    public string Code { get; set; }
    public string Name { get; set; }
   

    public Course(string code, string name)
    {
        Code = code;
        Name = name;
    }

    public override bool Equals(object? obj)
    {
        if (obj == null || this.GetType() != obj.GetType())
        {
            return false;
        }

        Course other = (Course)obj;
        return Code == other.Code;
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }

    public override string ToString()
    {
        return $"Program({Code}, {Name}";
    }
}