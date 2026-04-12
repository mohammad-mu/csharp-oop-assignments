# Introduction to OOP using C#

[![Lab 02](https://img.shields.io/badge/-Lab%2002-0078D4?style=for-the-badge)]()
[![C#](https://img.shields.io/badge/-C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)]()
[![.NET](https://img.shields.io/badge/-.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white)]()
[![Run Code](https://img.shields.io/badge/-Run%20Code-white?style=for-the-badge&logo=visual-studio-code&logoColor=0078D4)](#)

## 📝 Assignment: Student Class Constructors

**Objective:** Create a `Student` class in C# with different types of constructors. Demonstrate your understanding of default constructors, parameterized constructors, constructor overloading, and copy constructors.

### Instructions:

**1. Create the Student Class:**
Define the `Student` class with the following properties:
* `Name` (string)
* `Age` (int)
* `Grade` (double, representing the student's average grade)

**2. Implement Constructors:**
Implement the following constructors in your `Student` class:
* A **default constructor** that initializes the properties to `"Unknown"`, `0`, and `0.0` respectively.
* A **parameterized constructor** that takes name, age, and grade as parameters and sets the object’s properties accordingly.
* **Constructor overloading:** Create a constructor that takes only name and age, and sets the grade to a default value of `0.0` (indicating no grades yet).
* A **copy constructor** that creates a new `Student` object by copying the properties of an existing `Student` object.

**3. Create a Program Class:**
In the `Main` method of your `Program` class, create at least four instances of the `Student` class:
* Use the default constructor.
* Use the parameterized constructor with name, age, and grade.
* Use the constructor with just name and age, and set the grade to `0.0`.
* Create a `Student` object using the copy constructor by copying an existing object.

**4. Display Object Information:**
* In the `Student` class, add a method `DisplayInfo()` to display the details of the student object in the following format: `Name: <name>, Age: <age>, Grade: <grade>`.
* Add an additional method `UpdateGrade(double newGrade)` to the `Student` class. This method will allow you to update the student's grade.
* Call this method on one of the `Student` objects in your `Main` method and display the updated information.
