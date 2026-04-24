using System;
class Book 
{
    public string Title;
    public string Author;
    public Book(string title, string author) 
    {
        Title = title;
        Author = author;
    }
    public void PrintDetails() 
    {
        Console.WriteLine($"Title: {Title}, Author: {Author}");
    }
}
class Program 
{
    static void Main() 
    {
        Book[] library = new Book[3];
        library[0] = new Book("C# Basics", "Dr.Mohamed Handosa");
        library[1] = new Book("OOP Fundamentals", "Dr.Sara El-Metwally");
        library[2] = new Book("Logic Circuits", "Dr.Muhammed Mahfouz");
        Console.WriteLine("--- Book List ---");
        foreach (Book b in library) 
        {
            if (b != null) 
                b.PrintDetails();
        }
    }
}
