// BasicInputOutput.cs
using System;

namespace BasicInputOutput
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt for the user's name
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            // Prompt for the user's age
            Console.Write("Enter your age: ");
            string age = Console.ReadLine();

            // Prompt for the user's favorite color
           //
            // Display the collected information
            //Console.WriteLine("\n--- User Information ---");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            //Console.WriteLine($"Favorite Color: {favoriteColor}");
        }
    }
}
