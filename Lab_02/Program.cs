using System;

class Student 
{
    // Attributes
    public string Name;
    public int Age;
    public double Grade;

    // 1. Default constructor
    public Student() 
    {
        Name = "Unknown";
        Age = 0;
        Grade = 0.0;
    }

    // 2. Parameterized constructor
    public Student(string name, int age, double grade) 
    {
        Name = name;
        Age = age;
        Grade = grade;
    }

    // 3. Constructor overloading (Name and Age only)
    public Student(string name, int age) 
    {
        Name = name;
        Age = age;
        Grade = 0.0;
    }

    // 4. Copy constructor
    public Student(Student original_object) 
    {
        Name = original_object.Name;
        Age = original_object.Age;
        Grade = original_object.Grade;
    }

    // Method to display student information
    public void DisplayInfo() 
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}, Grade: {Grade}");
    }

    // Method to update the student's grade
    public void UpdateGrade(double newGrade) 
    {
        Grade = newGrade;
    }
}

class Program 
{
    static void Main() 
    {
        // 1. Using the default constructor
        Student student1 = new Student();
        student1.DisplayInfo();

        // 2. Using the parameterized constructor
        Student student2 = new Student("Mohammad", 18, 2.5);
        student2.DisplayInfo();

        // 3. Using the constructor with just name and age
        Student student3 = new Student("Aly", 19);
        student3.DisplayInfo();

        // 4. Using the copy constructor (copying student2)
        Student student4 = new Student(student2);
        student4.DisplayInfo();

        // Updating the grade of student3 and displaying the updated info
        Console.WriteLine("\n--- Updating Aly's Grade ---");
        student3.UpdateGrade(3.5);
        student3.DisplayInfo();
    }
}
