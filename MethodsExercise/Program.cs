using System;

namespace MethodsExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var name = GetName();
            var age = GetAge();
            var pet = GetPet();
            var petName = GetPetName();
            var petColor = GetPetColor();
            var petAge = GetPetAge();

            Console.WriteLine($"\nThere once was a person named {name}, they were {age} years old. They had a {petColor} {pet} named {petName}.");
            Console.WriteLine($"{name} loved saying \"it\'s been 84 years\" just like Rose from Titanic.");
            
            int i = 12;

                if (i == Convert.ToInt32(petAge))
                {

                    Console.WriteLine($"Not only was {name} {age} years old. {petName} was {i} which, in dog years makes {age} years.");

                }
                else
                {
                    Console.WriteLine($"{name}\'s {pet} {petName} was {petAge} years old, {name} wishes to be that young again.");


                }
        }
        public static string GetName()
        {
            Console.WriteLine("What is your name?");
            return Console.ReadLine();
        }
        public static string GetAge()
        {
            Console.WriteLine("\nHow many years did Rose say it has been in Titanic?");
            return Console.ReadLine();
        }
        public static string GetPet()
        {
            Console.WriteLine("\nWhat kind of pet do you have or want?");
            return Console.ReadLine();
        }
        public static string GetPetName()
        {
            Console.WriteLine("\nWhat is your pets name?");
            return Console.ReadLine();
        }
        public static string GetPetColor()
        {
            Console.WriteLine("\nWhat is the color of your Pet?");
            return Console.ReadLine();
        }
        public static string GetPetAge()
        {
            Console.WriteLine("\nhow old is your pet?");
           
            return Console.ReadLine();

        }


    }

}
