using System.Runtime.InteropServices;

namespace PersonLib;

public class CourseOffering
{
    public int Year { get; set; }
    public string Semester { get; set; }
    public List<Student> studentList { get; set; }
    public List<Course> coursesList { get; set; }
    

    public CourseOffering(int year, string semester, Course course, [Optional]Teacher teacher)
    {
        Year = year;
        Semester = semester;
        studentList = new List<Student>();
        coursesList = new List<Course>();
    }

    public override bool Equals(object? obj)
    {
        if (obj == null || this.GetType() != obj.GetType())
        {
            return false;
        }

        CourseOffering other = (CourseOffering)obj;
        return studentList.Equals(other.coursesList) && coursesList.Equals(other.coursesList);
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }

    /*public override string ToString()
    {
        return $"Course Offering({Year}, {Semester},{String.Join<studentList>("\n", studentList)})";
    }*/
}