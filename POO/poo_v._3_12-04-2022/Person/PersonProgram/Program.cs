﻿using PersonLib;

namespace PersonProgram
{
    public class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person(1,"Denis", DateOnly.Parse("2000-05-25"));
            Person person2 = new Person(2,"Alice", DateOnly.Parse("1996-02-29"));
            Person person3 = new Person(2,"Alice", DateOnly.Parse("1997-02-28"));

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
            // int y = 3;
            // int x = y > 5 ? 7 : 8;
            // if (y > 5)
            // {
            //     x = 7;
            // }
            // else
            // {
            //     x = 8;
            // }
        }
    }
}