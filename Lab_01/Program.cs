using System;
class Student 
{
    // Attributes
    public string Name;
    public int ID;
    public double GPA;
    // Method
    public void DisplayInfo() 
    {
        Console.WriteLine($"Student Name: {Name}, ID: {ID}, GPA: {GPA}");
    }
}
class Program 
{
    static void Main() 
    {
        // Creating an object of Student
        Student myStudent = new Student();
        // Assigning values to its attributes
        myStudent.Name = "Mohammad Aly";
        myStudent.ID = 1000323788;
        myStudent.GPA = 2.5;
        // Calling DisplayInfo()
        myStudent.DisplayInfo();
    }
}
