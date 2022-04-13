using PersonLib;

namespace PersonProgram
{
    public class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person(1,"Denis", DateOnly.Parse("2000-05-25"));
            Person person2 = new Person(2,"Alice", DateOnly.Parse("2000-04-29"));
            Person person3 = new Person(3,"Alice", DateOnly.Parse("2000-02-28"));

            Console.WriteLine(person1);
            Console.WriteLine(person2);
            // person3.Name = "";
            Console.WriteLine(person3);
            Console.WriteLine(person1 == person2);
            Console.WriteLine(person1.Equals(person2));
            Console.WriteLine(person3 == person2);
            Console.WriteLine(person3.Equals(person2));

            Console.WriteLine(person1.Age);
            Console.WriteLine(person2.Age);
            Console.WriteLine(person3.Age);
            
            //Cours du 13 avril Tableau et liste
            int[] number1 = new int[5];
            number1 [0] = 7;
            int[] number2 = {4, 8, 1, 3, 9};

            Person[] people = new Person[4];
            people[2] = new Person(4,"Bob", DateOnly.Parse("1988-08-12"));
            people[0] = person1;
            Console.WriteLine(people[0]);
            Console.WriteLine(people[1]);

            for (int i = 0; i < people.Length; i++)
            {
                Person person = people[i];
                Console.WriteLine(person);
            }
            foreach (Person personne in people)
            {
                Console.WriteLine(personne);
            }

            List<Person> personList = new List<Person>();
            personList.Add(new Person(5,"dr",DateOnly.Parse("199-09-09")));
            personList.Add(person3);
            Console.WriteLine(personList[2]);
            personList.Insert(0, person2);
            personList.
            
        }
    }
}