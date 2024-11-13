using System;

class Person
{
    private string name;
    private int age;

    // Property for name with encapsulation
    public string Name
    {
        get
        {
            return name;
        }
        set
        {
            //  name cannot be empty or null
            if (!string.IsNullOrEmpty(value))
            {
                name = value;
            }
            else
            {
                throw new ArgumentException("Name cannot be empty.");
            }
        }
    }

    // Property for age with encapsulation
    public int Age
    {
        get
        {
            return age;
        }
        set
        {
            // Age must be a positive number
            if (value > 0)
            {
                age = value;
            }
            else
            {
                throw new ArgumentException("Age must be positive.");
            }
        }
    }

    // Constructor
    public Person(string name, int age)
    {
        Name = name;  // Using the property to set the value
        Age = age;    // Using the property to set the value
    }

    // Method to display person details
    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create a new Person object
        Person person = new Person("anshuman", 20);
        
        // Display  information
        person.DisplayInfo();


    }
}
