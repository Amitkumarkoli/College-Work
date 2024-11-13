// CommandLineArgs.cs
using System;

namespace CommandLineArgs
{
    class Program
    {
        static void Main(string[] args)
        {
            // Check if any command-line arguments were provided
            if (args.Length == 0)
            {
                Console.WriteLine("No command-line arguments provided.");
                return;
            }

            // Display the number of arguments provided
            Console.WriteLine($"Number of arguments: {args.Length}");

            // Loop through each argument and display it
            Console.WriteLine("\nArguments received:");
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine($"Argument {i + 1}: {args[i]}");
            }
        }
    }
}
