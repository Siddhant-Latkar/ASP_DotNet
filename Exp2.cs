using System;

// Class definition
class Student
{
    // Private data members (Encapsulation)
    private string name;
    private int age;

    // Public method to set values
    public void SetData(string n, int a)
    {
        name = n;
        age = a;
    }

    // Public method to display values
    public void DisplayData()
    {
        Console.WriteLine("Student Name: " + name);
        Console.WriteLine("Student Age: " + age);
    }
}

// Main class
class Exp2
{
    static void Main()
    {
        Console.WriteLine("Experiment 2: OOP Concepts in C#");

        // Creating object
        Student s1 = new Student();

        // Setting values using method
        s1.SetData("Siddhant", 19);

        // Displaying values
        s1.DisplayData();
    }
}