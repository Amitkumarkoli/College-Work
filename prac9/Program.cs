using System;

namespace CloneAndCompareSample
{
    class CloneExample
    {
        public static void RunCloneExample()
        {
            string[] arr = { "Amit", "Nitin", "Sunny", "Rahul" };
            string[] arrCloned = arr.Clone() as string[];

            Console.WriteLine("Original Array: " + string.Join(", ", arr));
            Console.WriteLine("Cloned Array: " + string.Join(", ", arrCloned));
        }
    }

    class CompareExample
    {
        public static void RunCompareExample()
        {
            string author1 = "Mahesh Chand";
            string author2 = "Praveen Kumar";
            string author3 = "Mahesh Chand";

            // Comparing strings using String.Equals
            if (String.Equals(author1, author2))
                Console.WriteLine($"{author1} and {author2} have the same value");
            else
                Console.WriteLine($"{author1} and {author2} are different");

            if (String.Equals(author1, author3))
                Console.WriteLine($"{author1} and {author3} have the same value");
            else
                Console.WriteLine($"{author1} and {author3} are different");

            // Using CompareTo method
            if (author1.CompareTo(author2) == 0)
                Console.WriteLine("Both strings have the same value");
            else if (author1.CompareTo(author2) < 0)
                Console.WriteLine($"{author1} precedes {author2}");
            else if (author1.CompareTo(author2) > 0)
                Console.WriteLine($"{author1} follows {author2}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Run the clone example
            CloneExample.RunCloneExample();
            Console.WriteLine();

            // Run the compare example
            CompareExample.RunCompareExample();

            Console.ReadLine();
        }
    }
}
