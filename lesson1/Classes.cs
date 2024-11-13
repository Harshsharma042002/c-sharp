using System;
using System.Collections.Generic;

public class Classes
{
    // Base Book class
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public bool IsCheckedOut { get; private set; }

        // Constructor
        public Book(string title, string author)
        {
            Title = title;
            Author = author;
            IsCheckedOut = false;
        }

        // Method to check out a book
        public virtual void CheckOut()
        {
            if (!IsCheckedOut)
            {
                IsCheckedOut = true;
                Console.WriteLine($"'{Title}' by {Author} has been checked out.");
            }
            else
            {
                Console.WriteLine($"'{Title}' by {Author} is already checked out.");
            }
        }

        // Method to return a book
        public void ReturnBook()
        {
            if (IsCheckedOut)
            {
                IsCheckedOut = false;
                Console.WriteLine($"'{Title}' by {Author} has been returned.");
            }
            else
            {
                Console.WriteLine($"'{Title}' by {Author} was not checked out.");
            }
        }
    }

    // Derived EBook class
    class EBook : Book
    {
        public double FileSizeMB { get; set; }

        // Constructor for EBook
        public EBook(string title, string author, double fileSizeMB) 
            : base(title, author)
        {
            FileSizeMB = fileSizeMB;
        }

        // Overriding CheckOut method for EBook
        public override void CheckOut()
        {
            Console.WriteLine($"E-Book '{Title}' by {Author} (size: {FileSizeMB}MB) has been downloaded.");
        }
    }

    // ClassesLesson method to demonstrate functionality
    public static void ClassesLesson()
    {
        Console.WriteLine("Welcome to the Library System:");

        // Creating instances of Book
        Book physicalBook1 = new Book("The Great Gatsby", "F. Scott Fitzgerald");
        Book physicalBook2 = new Book("To Kill a Mockingbird", "Harper Lee");

        // Creating an instance of EBook
        EBook ebook1 = new EBook("C# in Depth", "Jon Skeet", 5.6);

        // Adding books to a library (list)
        List<Book> library = new List<Book> { physicalBook1, physicalBook2, ebook1 };

        // Checking out physical books
        Console.WriteLine("\n--- Checking Out Physical Books ---");
        physicalBook1.CheckOut(); // Expected: Successful checkout
        physicalBook1.CheckOut(); // Expected: Already checked out

        // Returning a physical book
        Console.WriteLine("\n--- Returning Physical Books ---");
        physicalBook1.ReturnBook(); // Expected: Successful return
        physicalBook1.ReturnBook(); // Expected: Was not checked out

        // Checking out an EBook
        Console.WriteLine("\n--- Checking Out E-Books ---");
        ebook1.CheckOut(); // Expected: E-Book download message

        // Displaying all books in the library
        Console.WriteLine("\n--- Library Collection ---");
        foreach (Book book in library)
        {
            string type = book is EBook ? "E-Book" : "Physical Book";
            Console.WriteLine($"{type}: '{book.Title}' by {book.Author}");
        }
    }
}
