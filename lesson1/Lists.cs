using System;
using System.Collections.Generic;
using System.Linq; 

public class Lists
{
    // Method to display elements of the list
    public static void DisplayList(List<int> list)
    {
        if (list.Count == 0)
        {
            Console.WriteLine("List is empty.");
        }
        else
        {
            Console.WriteLine("List elements: " + string.Join(", ", list));
        }
    }

    public static void ListLesson()
    {
        Console.WriteLine("Hi from list!");

        
        List<int> listNumber = new List<int>();

        listNumber.Add(10);
        listNumber.Add(20);
        listNumber.Add(30);
        listNumber.Add(40);
        listNumber.Add(50);

        // Display the initial list
        Console.WriteLine("\nInitial list:");
        DisplayList(listNumber);

        // Insert an element at a specific position (index 2)
        listNumber.Insert(2, 25);
        Console.WriteLine("\nAfter inserting 25 at position 2:");
        DisplayList(listNumber);

        // Removing an element by value (remove 40)
        listNumber.Remove(40);
        Console.WriteLine("\nAfter deleting 40:");
        DisplayList(listNumber);

        // Removing an element by index (remove at index 3)
        listNumber.RemoveAt(3);
        Console.WriteLine("\nAfter deleting value at index 3:");
        DisplayList(listNumber);

        // Finding the maximum and minimum elements in the list
        int max = listNumber.Max();
        int min = listNumber.Min();
        Console.WriteLine($"\nThe Maximum element is: {max}, and Minimum element is: {min}");

        // Converting the list to an array
        int[] listArray = listNumber.ToArray();
        Console.WriteLine("\nConverted to array:");
        Console.WriteLine(string.Join(", ", listArray));

        // Clearing the entire list
        listNumber.Clear();
        Console.WriteLine("\nAfter clearing the list:");
        DisplayList(listNumber);
    }
}
