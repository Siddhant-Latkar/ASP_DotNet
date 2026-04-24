using System;

namespace DelegateLambdaDemo
{
    // Step 1: Declare delegate
    public delegate int Operation(int a, int b);

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Delegates and Lambda Expressions Demo ===\n");

            // Step 2: Using delegate with named method
            Operation add = Add;
            Console.WriteLine("Using Named Method (Add): " + add(10, 5));

            // Step 3: Using anonymous method
            Operation multiply = delegate (int a, int b)
            {
                return a * b;
            };
            Console.WriteLine("Using Anonymous Method (Multiply): " + multiply(10, 5));

            // Step 4: Using lambda expression
            Operation subtract = (a, b) => a - b;
            Console.WriteLine("Using Lambda Expression (Subtract): " + subtract(10, 5));

            // Step 5: Another lambda (division)
            Operation divide = (a, b) =>
            {
                if (b == 0)
                {
                    Console.WriteLine("Cannot divide by zero!");
                    return 0;
                }
                return a / b;
            };
            Console.WriteLine("Using Lambda Expression (Divide): " + divide(10, 5));

            Console.ReadLine();
        }

        // Named method
        public static int Add(int a, int b)
        {
            return a + b;
        }
    }
}