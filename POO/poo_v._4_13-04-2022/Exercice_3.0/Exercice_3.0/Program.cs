﻿using Exercice_3;


namespace Exercice_3
{
    public class Program
    {
        static void Main(string[] args)
        {
            Dice dice1 = new Dice(150);
            Console.WriteLine(dice1.NbFace);
            dice1.Throw();




        }
    }
}