using System;

public class Structures
{
    // Define the Person struct with the required fields
    struct Person
    {
        public string Name;
        public int Age;
        public int Year; 
        
    }

    // Function that takes ref parameters for name and age
    static void ReturnPerson(ref string name, ref int age)
    {
        Console.WriteLine("Enter your name:");
        name = Console.ReadLine();
        Console.WriteLine("Enter your age:");
        age = Convert.ToInt32(Console.ReadLine());
    }

    // Function that returns a Person struct with name, age, and birth year
    static Person ReturnPerson2()
    {
        Console.WriteLine("Enter your name:");
        string name = Console.ReadLine();
        Console.WriteLine("Enter your age:");
        int age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter your birth year:");
        int year = Convert.ToInt32(Console.ReadLine());

        Person person;
        person.Name = name;
        person.Age = age;
        person.Year = year;
        return person;
    }

    public static void StructuresLesson()
    {
        Console.WriteLine("Hi from structures");
        
        // Create a person using the Person struct
        Person person;
        person.Name = "Harsh";
        person.Age = 22;
        person.Year = 2001; // Add a year if you want to use it
        Console.WriteLine($"My name is {person.Name}, my age is {person.Age}, and my birth year is {person.Year}");

        // Using ReturnPerson to fill name and age via ref parameters
        string newName = "";
        int newAge = 0;
        ReturnPerson(ref newName, ref newAge);
        Console.WriteLine($"Name: {newName}, Age: {newAge}");

        // Using ReturnPerson2 to get a Person struct and display the values
        Person personFromReturn = ReturnPerson2();
        Console.WriteLine($"My name is {personFromReturn.Name}, my age is {personFromReturn.Age}, and my birth year is {personFromReturn.Year}");
        
    }
}
