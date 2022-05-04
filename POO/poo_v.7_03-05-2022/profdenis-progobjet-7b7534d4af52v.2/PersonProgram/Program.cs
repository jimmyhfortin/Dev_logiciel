using PersonLib;

namespace PersonProgram;

public class Program
{
    static void Main(string[] args)
    {
        Person person1 = new Person(1,"Denis", DateOnly.Parse("2000-05-25"));
        Person person2 = new Person(2,"Alice", DateOnly.Parse("1996-02-29"));
        Person person3 = new Person(3,"Alice", DateOnly.Parse("1997-02-28"));

        Console.WriteLine(person1);
        Console.WriteLine(person2);
        person3.Name = "++";
        Console.WriteLine(person3);
        Console.WriteLine(person1 == person2);
        Console.WriteLine(person1.Equals(person2));
        Console.WriteLine(person3 == person2);
        Console.WriteLine(person3.Equals(person2));

        Console.WriteLine(person1.Age);
            
        // person3.Name = null;
        // person3.Id = 4;

        int[] numbers1 = new int[5];
        numbers1[0] = 7;
        int[] numbers2 = {4, 8, 1, 3, 9};

        Person[] people = new Person[4];
        people[0] = person1;
        people[1] = new Person(4, "Bob", DateOnly.Parse("1988-08-12"));
        people[2] = person3;
        Console.WriteLine(people[0]);
        Console.WriteLine(people[1]);

        for (int i = 0; i < people.Length; i++)
        {
            Person person = people[i];
            Console.WriteLine(person);
        }
        foreach (Person person in people)
        {
            Console.WriteLine(person);
        }

        List<Person> personList = new List<Person>();
        personList.Add(new Person(5, "asdasd", DateOnly.Parse("1909-09-09")));
        personList.Add(person3);
        Employee employee = new Employee("Denis", new DateOnly(2000, 01, 10),
            1, "Informatique", false);
        personList.Add(employee);
        Console.WriteLine("\n\nEmployee: ");
        Console.WriteLine(employee);
        Console.WriteLine(employee.F());

        Person personTemp = employee;
        Console.WriteLine(personTemp.F());
        
        Console.WriteLine("\n\nforeach personList");
        foreach (Person person in personList)
        {
            Console.WriteLine(person);
        }
        Console.WriteLine("foreach personList");
        personList.Insert(0, person2);
        foreach (Person person in personList)
        {
            Console.WriteLine(person);
        }

        Console.WriteLine(personList[2]);
        Console.WriteLine(personList.Count);
        Console.WriteLine(Person.NextId);
        Console.WriteLine(person1.Name);
        int x = Person.IndexOf(people, person2);
        if (x == -1)
        {
            Console.WriteLine("Not found");
        }
        else
        {
            Console.WriteLine(x);
        }

        Person person4 = new Person("Denis", DateOnly.Parse("1977-08-12"));
        Console.WriteLine(person4);
    }


}