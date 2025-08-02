using System;

// Step-1  Delegate
public delegate int Operation(int a, int b);

class Program
{
    // Step-2  Methods
    static int Add(int a, int b) => a + b;
    static int Subtract(int a, int b) => a - b;
    static int Multiply(int a, int b) => a * b;
    static int Divide(int a, int b)
    {
        if (b == 0) throw new DivideByZeroException();
        return a / b;
    }

    // Step-3  Callback
    static int PerformOperation(int x, int y, Operation op) => op(x, y);

    static void Main()
    {
        /* prompts – must be exact */
        Console.WriteLine("Enter first number:");
        string s1 = Console.ReadLine();
        Console.WriteLine("Enter second number:");
        string s2 = Console.ReadLine();
        Console.WriteLine("Enter operation (add, subtract, multiply, divide):");
        string opText = Console.ReadLine()?.Trim().ToLower();

        /* number validation */
        if (!int.TryParse(s1, out int n1) || !int.TryParse(s2, out int n2))
        {
            Console.WriteLine("Invalid input");
            return;                   // one extra line only
        }

        /* map word → delegate */
        Operation op = opText switch
        {
            "add" => Add,
            "subtract" => Subtract,
            "multiply" => Multiply,
            "divide" => Divide,
            _ => null
        };

        if (op == null)
        {
            Console.WriteLine("Invalid operation");
            return;
        }

        /* perform */
        try
        {
            int result = PerformOperation(n1, n2, op);
            Console.WriteLine("Result: " + result);
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Error: Division by zero.");
        }
    }
}
