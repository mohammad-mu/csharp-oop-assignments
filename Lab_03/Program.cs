using System;

class Book 
{
    private string title;
    private string author;
    private double price;
    // Implement properties:
    // Title (public get, private set)
    public string Title 
    {
        get { return title; }
        private set { title = value; }
    }
    // Author (public get, private set)
    public string Author 
    {
        get { return author; }
        private set { author = value; }
    }
    // Price (public get, set) → Ensure price cannot be negative.
    public double Price 
    {
        get { return price; }
        set 
        {
            if (value >= 0) 
                price = value;
            else 
                Console.WriteLine("Price cannot be negative.");
        }
    }
    // Add a constructor to initialize the title, author, and price.
    public Book(string title, string author, double price) 
    {
        Title = title;
        Author = author;
        Price = price;
    }
    // Add a DisplayInfo() method to print book details.
    public void DisplayInfo() 
    {
        Console.WriteLine($"Title: {Title}, Author: {Author}, Price: {Price}");
    }
}
class Program 
{
    static void Main() 
    {
        // Create two books.
        Book book1 = new Book("C# Basics", "Dr.Mohamed Handosa", 150.0);
        Book book2 = new Book("OOP Fundamentals", "Dr.Sara El-Metwally", 200.0);
        book1.DisplayInfo();
        book2.DisplayInfo();
        // Try modifying their price
        Console.WriteLine("\n--- Updating Prices ---");
        book1.Price = 120.0;
        book2.Price = -50.0;
        book1.DisplayInfo();
        book2.DisplayInfo();
        // Try modifying their title or author
        // book1.Title = "New Title"; 
        // book2.Author = "New Author";
    }
}
