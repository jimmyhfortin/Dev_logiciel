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
}