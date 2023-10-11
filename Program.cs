using System;

// Define a class named "Person"
class Person
{
    // Properties (attributes) of the class
    public string FirstName { get; set; }
    public string LastName { get; set; }

    // Constructor to initialize the object
    public Person(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    // Method to display the full name
    public string GetFullName()
    {
        return $"{FirstName} {LastName}";
    }
}

// Main class with the entry point
class Program
{
    static void Main(string[] args)
    {
        // Create instances (objects) of the "Person" class
        Person person1 = new Person("John", "Doe");
        Person person2 = new Person("Jane", "Smith");

        // Access properties and methods of the objects
        Console.WriteLine("Person 1: " + person1.GetFullName());
        Console.WriteLine("Person 2: " + person2.GetFullName());

        Console.ReadLine();
    }
}


