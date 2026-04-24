using System;

class Program
{
    static void Main(string[] args)
    {
        double num1, num2;

        Console.Write("Enter first number: ");
        num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter second number: ");
        num2 = Convert.ToDouble(Console.ReadLine());

        double addition = num1 + num2;
        double subtraction = num1 - num2;
        double multiplication = num1 * num2;
        double division = num2 != 0 ? num1 / num2 : 0;

        Console.WriteLine("\nResults:");
        Console.WriteLine("Addition: " + addition);
        Console.WriteLine("Subtraction: " + subtraction);
        Console.WriteLine("Multiplication: " + multiplication);

        if (num2 != 0)
            Console.WriteLine("Division: " + division);
        else
            Console.WriteLine("Division: Cannot divide by zero");

        Console.ReadLine();
    }
}