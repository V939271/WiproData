using System;

class Book
{
    // Step 1: Define properties
    public string Title { get; set; }
    public string Author { get; set; }
    public int Year { get; set; }

    // Step 2: Define constructor
    public Book(string title, string author, int year)
    {
        Title = title;
        Author = author;
        Year = year;
    }
}

class Program1
{
    static void Main(string[] args)
    {
        // Step 3: Prompt the user to enter book title
        Console.WriteLine("Enter book's title:");
        string title = Console.ReadLine();

        // Step 4: Prompt the user to enter book author
        Console.WriteLine("Enter book's author:");
        string author = Console.ReadLine();

        // Step 5: Prompt the user to enter book year
        Console.WriteLine("Enter book's year:");
        int year = Convert.ToInt32(Console.ReadLine());

        // Step 6: Create an instance of the Book class
        Book myBook = new Book(title, author, year);

        // Step 7: Print book details (exact match with expected output)
        Console.WriteLine($"Book Title: {myBook.Title}");
        Console.WriteLine($"Book Author: {myBook.Author}");
        Console.WriteLine($"Book Year: {myBook.Year}");
    }
}