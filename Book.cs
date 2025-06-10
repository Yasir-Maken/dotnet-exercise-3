// Book.cs
// This file defines the Book class, demonstrating core object-oriented concepts like
// private members, constructors, and public methods.


// Define the Book class.
// A class is a blueprint for creating objects (instances).
public class Book
{
    // --- Private Member Variables (Fields) ---
    private string _title;
    private string _author;
    private int _publicationYear;

    // --- Default Constructor ---
    // takes no arguments and provides initial values for the object's members.
    public Book()
    {
        // Initialize private members with default "Unknown" values for title and author.
        _title = "Unknown";
        _author = "Unknown";
        // Initialize publication year with the current year using DateTime.Now.Year.
        _publicationYear = DateTime.Now.Year;
    }

    // --- Parameterized Constructor ---
    // This constructor accepts arguments to initialize the object's member variables
    // with specific values provided by the caller.
    
    public Book(string title, string author, int publicationYear)
    {
        // Assign the values passed as arguments to the corresponding private fields.
        _title = title;
        _author = author;
        _publicationYear = publicationYear;

    }

    // --- Public Method ---
    // It is 'public' so it can be called from outside the Book class (e.g., from Main method).
    public void DisplayBookInfo()
    {
        // Print the book's details to the console using string interpolation ($"").
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Publication Year: {_publicationYear}");
    }
}
