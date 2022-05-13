using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace PersonLib;

public class CourseOffering
{
    public int Year { get; set; }
    public string Semester { get; set; }
    public Course course { get; set; }
    public Teacher? Teacher { get; set; }


    public CourseOffering(int year, string semester, Course course, [Optional] Teacher teacher) // normalement ,Teacher? teacher=null)
    {
        Year = year;
        Semester = semester;
        this.course = course;
        Teacher = teacher;
    }

    public override bool Equals(object? obj)
    {
        if (obj == null || this.GetType() != obj.GetType())
        {
            return false;
        }

        CourseOffering other = (CourseOffering) obj;
        return course.Equals(other.course) && course.Equals(other.course);
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }

    public override string ToString()
    {
        return $"Course Offering({Year}, {Semester}, {string.Join("\n", Teacher)})";
    }
}