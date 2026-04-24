using System;
class Student 
{
    public string Name;
    public int Age;
    public Student(string name, int age) 
    {
        Name = name;
        Age = age;
    }
    public void ShowInfo() 
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }
}
class Classroom 
{
    private Student[] students;
    public Classroom(int size) 
    {
        students = new Student[size];
    }
    public void AddStudent(int index, string name, int age) 
    {
        students[index] = new Student(name, age);
    }
    public void ShowAllStudents() 
    {
        foreach (var student in students) 
        {
            if (student != null) 
                student.ShowInfo();
        }
    }
    public double CalculateAverageAge() 
    {
        int totalAge = 0;
        int count = 0;
        foreach (var student in students) 
        {
            if (student != null) 
            {
                totalAge += student.Age;
                count++;
            }
        }
        return count > 0 ? (double)totalAge / count : 0;
    }
}
class Program 
{
    static void Main() 
    {
        Classroom classroom = new Classroom(3);
        classroom.AddStudent(0, "Mohammad", 20);
        classroom.AddStudent(1, "Aly", 22);
        classroom.AddStudent(2, "Ahmad", 19);
        Console.WriteLine("--- Students List ---");
        classroom.ShowAllStudents();
        double avgAge = classroom.CalculateAverageAge();
        Console.WriteLine($"\nAverage Age of Students: {avgAge:F2}");
    }
}
