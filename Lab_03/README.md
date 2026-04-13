# Introduction to OOP using C#

[![Lab 03](https://img.shields.io/badge/-Lab%2003-0078D4?style=for-the-badge)]()
[![C#](https://img.shields.io/badge/-C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)]()
[![.NET](https://img.shields.io/badge/-.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white)]()
[![Run Code](https://img.shields.io/badge/-Run%20Code-white?style=for-the-badge&logo=visual-studio-code&logoColor=0078D4)](https://dotnetfiddle.net/wBSO4H)

## 📝 Assignment: Book Class Encapsulation

**Task:** Implement a `Book` class with access modifiers, encapsulation, and properties.

### Requirements:

**1. Create a `Book` class with:**
* `private string title`
* `private string author`
* `private double price`

**2. Implement properties:**
* `Title` (public get, private set)
* `Author` (public get, private set)
* `Price` (public get, set) → Ensure price cannot be negative.

**3. Add a constructor:** * To initialize the title, author, and price.

**4. Add a `DisplayInfo()` method:** * To print book details.

**5. In `Main()`:**
* Create two books.
* Try modifying their price (should be allowed).
* Try modifying their title or author (should be prevented).
