using System;

class Addition // Base class
{
    // Method overloading: Same method name but different parameters
    public int Add(int a, int b)
    {
        return a + b;
    }

    public int Add(int a, int b, int c)
    {
        return a + b + c;
    }


    // Virtual method 
    public virtual string Add(string a, string b)
    {
        return a + " " + b;
    }
}

class ExtendedAddition : Addition // Derived class
{
    // Method overriding: Providing a new implementation for the base class's Add method
    public override string Add(string a, string b)
    {
        return a + " & " + b + " (overridden)";
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Method overloading demonstration
        Addition add = new Addition();
        Console.WriteLine("Addition of two integers: " + add.Add(5, 10));
        Console.WriteLine("Addition of three integers: " + add.Add(5, 10, 15));
       

        // Method overriding demonstration
        ExtendedAddition extendedAdd = new ExtendedAddition();
        Console.WriteLine("Concatenation of strings (overridden): " + extendedAdd.Add("Hello", "World"));

        
    }
}
