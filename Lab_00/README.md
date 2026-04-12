# Introduction to OOP using C#

[![Lab 00](https://img.shields.io/badge/-Lab%2000-0078D4?style=for-the-badge)]()
[![C#](https://img.shields.io/badge/-C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)]()
[![.NET](https://img.shields.io/badge/-.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white)]()

<details>
<summary><b>Which of the following correctly declares a one-dimensional array of 10 integers?</b></summary>
<br>
<ul>
<li>A. <code>int[10] numbers;</code></li>
<li>B. <code>int numbers = new int[10];</code></li>
<li>C. <code>int[] numbers = new int[10];</code></li>
<li>D. <code>int numbers[] = new int;</code></li>
</ul>
<blockquote>
✅ <b>Correct Answer: C</b>
</blockquote>
</details>

<hr>

<details>
<summary><b>Given the 2D array declaration below, what is the output of <code>matrix.GetLength(0)</code>?</b><br>
<code>int[,] matrix = { {1, 2}, {3, 4}, {5, 6} };</code></summary>
<br>
<ul>
<li>A. 2</li>
<li>B. 3</li>
<li>C. 6</li>
<li>D. 0</li>
</ul>
<blockquote>
✅ <b>Correct Answer: B</b>
</blockquote>
</details>

<hr>

<details>
<summary><b>In a jagged array declared as <code>int[][] jagged = new int[3][];</code> and initialized as follows, what is the value of <code>jagged[1].Length</code>?</b><br>
<code>jagged[0] = new int[2] { 1, 2 };</code><br>
<code>jagged[1] = new int[4] { 3, 4, 5, 6 };</code><br>
<code>jagged[2] = new int[3] { 7, 8, 9 };</code></summary>
<br>
<ul>
<li>A. 3</li>
<li>B. 2</li>
<li>C. 4</li>
<li>D. 1</li>
</ul>
<blockquote>
✅ <b>Correct Answer: C</b>
</blockquote>
</details>

<hr>

<details>
<summary><b>What is the key difference between a 2D array and a jagged array in C#?</b></summary>
<br>
<ul>
<li>A. A 2D array is an array of arrays, while a jagged array is a rectangular block of elements.</li>
<li>B. A 2D array allows different row lengths, while a jagged array does not.</li>
<li>C. A jagged array is an array of arrays (each inner array can be of a different length), whereas a 2D array is a fixed-size rectangular grid.</li>
<li>D. There is no difference between them.</li>
</ul>
<blockquote>
✅ <b>Correct Answer: C</b>
</blockquote>
</details>

<hr>

<details>
<summary><b>Which of the following is NOT a valid method declaration in C#?</b></summary>
<br>
<ul>
<li>A. <code>public void Display();</code></li>
<li>B. <code>static int Sum(int a, int b) { return a + b; }</code></li>
<li>C. <code>private double CalculateArea(double radius) { return Math.PI * radius * radius; }</code></li>
<li>D. <code>public Sum(int a, int b) { return a + b; }</code></li>
</ul>
<blockquote>
✅ <b>Correct Answer: D</b>
</blockquote>
</details>

<hr>

<details>
<summary><b>Which statement about method overloading is true?</b></summary>
<br>
<ul>
<li>A. Two methods can have the same name if they differ in their return type only.</li>
<li>B. Two methods can have the same name if they have different parameter types or counts.</li>
<li>C. Method overloading is not allowed in C#.</li>
<li>D. Overloaded methods must have the same number of parameters.</li>
</ul>
<blockquote>
✅ <b>Correct Answer: B</b>
</blockquote>
</details>

<hr>

<details>
<summary><b>What is the return type of a method that does not return any value?</b></summary>
<br>
<ul>
<li>A. null</li>
<li>B. void</li>
<li>C. int</li>
<li>D. None</li>
</ul>
<blockquote>
✅ <b>Correct Answer: B</b>
</blockquote>
</details>

<hr>

<details>
<summary><b>Consider the following method. What does it return when called as <code>Multiply(4, 5)</code>?</b><br>
<code>public int Multiply(int a, int b) { return a * b; }</code></summary>
<br>
<ul>
<li>A. 9</li>
<li>B. 20</li>
<li>C. 45</li>
<li>D. 54</li>
</ul>
<blockquote>
✅ <b>Correct Answer: B</b>
</blockquote>
</details>

<hr>

<details>
<summary><b>Which of the following is NOT a valid way to pass parameters to a method in C#?</b></summary>
<br>
<ul>
<li>A. By value</li>
<li>B. By reference using the <code>ref</code> keyword</li>
<li>C. By reference using the <code>out</code> keyword</li>
<li>D. By pointer without using the <code>unsafe</code> context</li>
</ul>
<blockquote>
✅ <b>Correct Answer: D</b>
</blockquote>
</details>
