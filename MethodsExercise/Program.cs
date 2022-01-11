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

            Console.WriteLine($"\nThere was a girl named {name}, she was {age} years old. She had a {petColor} {pet} named {petName}.");
            Console.WriteLine("She loved saying \"it\'s been 84 years\" just like Rose from Titanic.");

            
            for (int i = 12; i == Convert.ToInt32(petAge); i++)
                 if (i == 12)
                 {
                   
                    Console.WriteLine($"Not only was {name} {age} years old. Her {pet} was {i} which, in dog years makes {age} years.");
                   
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
