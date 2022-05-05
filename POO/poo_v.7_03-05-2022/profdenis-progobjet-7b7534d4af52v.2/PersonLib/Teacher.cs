namespace PersonLib;

public class Teacher : Employee
{
    public string Title { get; set; }
    
    public Teacher(int id, string name, DateOnly dob, int employeeId, string department, 
        bool isPermanent, string title) : base(id, name, dob, employeeId, department, isPermanent)
    {
        Title = title;
    }

    public Teacher(string name, DateOnly dob, int employeeId, string department, 
        bool isPermanent, string title) : base(name, dob, employeeId, department, isPermanent)
    {
        Title = title;
    }

    public override string ToString()
    {
        return $"Employee({Id}, {Name}, {Dob}, {EmployeeId}, {Department}, {IsPermanent}, {Title})";
    }

    public override bool Equals(object? obj)
    {
        if (obj == null || this.GetType() != obj.GetType())
        {
            return false;
        }

        Person other = (Person)obj;
        return Id == other.Id;
    }

    public override int GetHashCode()
    {
        return Id.GetHashCode();
    }
}