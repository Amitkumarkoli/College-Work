using System;

class Program
{
    static void Main()
    {
        // Input strings for comparison
        Console.WriteLine("Enter the first string:");
        string str1 = Console.ReadLine();

        Console.WriteLine("Enter the second string:");
        string str2 = Console.ReadLine();

        // String comparison (case-sensitive)
        Console.WriteLine("\nComparing strings with case-sensitivity:");
        if (str1 == str2)
        {
            Console.WriteLine("The strings are equal .");
        }
        else
        {
            Console.WriteLine("The strings are not equal .");
        }

        // String comparison (case-insensitive)
        Console.WriteLine("\nComparing strings without case-sensitivity:");
        if (string.Equals(str1, str2, StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine("The strings are equal (case-insensitive).");
        }
        else
        {
            Console.WriteLine("The strings are not equal (case-insensitive).");
        }

        // Compare method
        Console.WriteLine("\nUsing the Compare method:");
        int result = string.Compare(str1, str2);
        if (result == 0)
        {
            Console.WriteLine("The strings are equal.");
        }
        else if (result < 0)
        {
            Console.WriteLine("The first string is less than the second.");
        }
        else
        {
            Console.WriteLine("The first string is greater than the second.");
        }
    }
}
