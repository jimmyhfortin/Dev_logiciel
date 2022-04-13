using System.Security.Principal;
using PersonLib;

namespace PersonProgram
{
    class Program
    {
        static void Main(string[] args)
        {

            Person person1 = new Person(1,"Denis", DateOnly.Parse("1988-03-10"));
            Person person2 = new Person(2,"Alice", DateOnly.Parse("1998-02-05"));
            Person person3 = new Person(3,"Alice", DateOnly.Parse("1998-02-05"));
            Person person4 = new Person(3,"Alice", DateOnly.Parse("1998-02-05"));
            Console.WriteLine(person1);
            Console.WriteLine(person2);
            Console.WriteLine(person1.Equals(person2));
            Console.WriteLine(person1.Age);



        }



    }
}    