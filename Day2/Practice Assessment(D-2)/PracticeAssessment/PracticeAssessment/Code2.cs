using System;

class Book
{
    // Define properties
    public string Title;
    public string Author;
    public int Year;

    // Define constructor
    public Book(string title, string author, int year)
    {
        Title = title;
        Author = author;
        Year = year;
    }
}

internal class Code2
{
    static void Main(string[] args)
    {
        // Prompt the user to enter book details
        Console.WriteLine("Enter book's title:");
        string Title = Console.ReadLine();

        Console.WriteLine("Enter book's author:");
        string Author = Console.ReadLine();

        Console.WriteLine("Enter book's year:");
        int Year = Convert.ToInt32(Console.ReadLine());

        // Create an instance of the Book class
        Book book = new Book(Title, Author, Year);

        // Print book details
        Console.WriteLine("Book Title: " + book.Title);
        Console.WriteLine("Book Author: " + book.Author);
        Console.WriteLine("Book Year: " + book.Year);
    }
}