using System;

namespace MethodsExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            Console.WriteLine("How many years did Rose say it has been in Titanic?");
            string age = Console.ReadLine();

            Console.WriteLine("what kind of pet do you have or want?");
            string pet = Console.ReadLine();

            Console.WriteLine("What is the color of your Pet?");
            string petColor = Console.ReadLine();

            Console.WriteLine("how old is your pet?");
            string petAge = Console.ReadLine();


            Console.WriteLine($"There was a girl named {name}, she was {age} years old. She had {petColor} {pet} named Luna.");
            Console.WriteLine("She loved saying \"it\'s been 84 years\" just like Rose from Titanic.");
            Console.WriteLine($"Not only was {name} {age} years old. Her {pet} was {petAge} which, in dog years makes {age} years.");
            
         

            
        }
    }
}
