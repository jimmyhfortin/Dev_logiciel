namespace PersonLib;

public class Student : Person
{
    public int StudentId { get; set; }
    
    public List<CourseOffering> CourseList { get; set; } // pas besoin de le mettre dans le constructeur
    public Programe Programe { get; set; }


    public Student(int id, string name, DateOnly dob, int studentId, Programe programe) : base(id, name, dob)
    {
        StudentId = studentId;
        Programe = programe;
        CourseList = new List<CourseOffering>();
    }

    public Student(string name, DateOnly dob, int studentId,Programe programe) : base(name, dob)
    {
        StudentId = studentId;
        Programe = programe;
        CourseList = new List<CourseOffering>();
    }
    public Student(string name, DateOnly dob, int studentId,Programe programe, List<CourseOffering> courseList) : base(name, dob)
    {
        StudentId = studentId;
        Programe = programe;
        CourseList = courseList;
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

    public override string ToString()
    {
        return $"Employee({Id}, {Name}, {Dob}, {StudentId})";
    }
}