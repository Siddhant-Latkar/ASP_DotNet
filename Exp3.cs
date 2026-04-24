using System;

// Class 1: Handles student data
class Student
{
    public string Name { get; set; }
    public int Marks { get; set; }
}

// Class 2: Handles result calculation (separate responsibility)
class ResultCalculator
{
    public string GetResult(int marks)
    {
        if (marks >= 40)
            return "Pass";
        else
            return "Fail";
    }
}

// Class 3: Handles display (separate responsibility)
class Display
{
    public void Show(Student s, string result)
    {
        Console.WriteLine("Student Name: " + s.Name);
        Console.WriteLine("Marks: " + s.Marks);
        Console.WriteLine("Result: " + result);
    }
}

// Main class
class Exp3
{
    static void Main()
    {
        Console.WriteLine("Experiment 3: SRP in C#");

        // Create object
        Student s1 = new Student();
        s1.Name = "Siddhant";
        s1.Marks = 75;

        // Calculate result
        ResultCalculator rc = new ResultCalculator();
        string result = rc.GetResult(s1.Marks);

        // Display output
        Display d = new Display();
        d.Show(s1, result);
    }
}