namespace PersonLib;

public class CourseOffering
{
    public int Year { get; set; }
    public string Semester { get; set; }
    public Course Course { get; set; }
    public Teacher? Teacher { get; set; }

    public CourseOffering(int year, string semester, Course course, Teacher teacher)
    {
        Year = year;
        Semester = semester;
        Course = course;
        Teacher = teacher;
    }

    public CourseOffering(int year, string semester, Course course)
    {
        Year = year;
        Semester = semester;
        Course = course;
    }
}