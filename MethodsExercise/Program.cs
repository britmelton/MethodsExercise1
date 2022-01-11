using System;

namespace MethodsExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var name = Prompt("What is your name?");
            var age = Prompt("\nHow many years did Rose say it has been in Titanic?");
            var pet = Prompt("\nWhat kind of pet do you have or want?");
            var petName = Prompt("\nWhat is your pets name?");
            var petColor = Prompt("\nWhat is the color of your Pet?");
            var petAge = Prompt("\nhow old is your pet?");
            
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

        /// <summary>
        /// ask user for input
        /// </summary>
        /// <param name="txt">the question</param>
        /// <returns></returns>
        public static string Prompt(string txt)
        {
            Console.WriteLine(txt); 
            return Console.ReadLine();

        }

    }

}
