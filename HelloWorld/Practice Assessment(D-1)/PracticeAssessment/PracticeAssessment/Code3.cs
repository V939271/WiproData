using System;

class Program
{
    static void Main(string[] args)
    {
        // Prompt the user to enter the first number
        Console.WriteLine("Enter the first number:");
        int num1;
        while (!int.TryParse(Console.ReadLine(), out num1))
        {
            Console.WriteLine("Invalid input. Please enter a valid integer:");
        }

        // Prompt the user to enter the second number
        Console.WriteLine("Enter the second number:");
        int num2;
        while (!int.TryParse(Console.ReadLine(), out num2))
        {
            Console.WriteLine("Invalid input. Please enter a valid integer:");
        }

        // Perform arithmetic operations
        /*
        
        
        Declare and Initialize Variables

Define two integers, num1 and num2, with appropriate values.
Declare variables sum, difference, product, and quotient to store results of operations.
Use a bool variable divisionByZero to track whether a division by zero is attempted.
Perform Addition, Subtraction, and Multiplication

Calculate the sum, difference, and product using standard arithmetic operators (+, -, *).
Store the results in the respective variables.
Handle Division Operation Safely

Before performing division, check if the divisor (num2) is not zero.
If num2 is non-zero, perform the division and cast the result to double for precise results.
If num2 is zero, set divisionByZero to true and avoid performing the division to prevent runtime exceptions.
Output Results (Optional)

Print the results of the arithmetic operations to the console.
If divisionByZero is true, display an appropriate message instead of the quotient.
        */


        // Print the results
        int sum = num1 + num2;                 // Addition
        int difference = num1 - num2;          // Subtraction
        int product = num1 * num2;             // Multiplication

        double quotient = 0;                   // For division result
        bool divisionByZero = false;           // Flag for divide-by-zero

        if (num2 != 0)
        {
            quotient = (double)num1 / num2;    // Safe division
        }
        else
        {
            divisionByZero = true;             // Division by zero occurred
        }

        Console.WriteLine("The sum is: " + sum);
        Console.WriteLine("The difference is: " + difference);
        Console.WriteLine("The product is: " + product);
        if (!divisionByZero)
        {
            Console.WriteLine("The quotient is: " + quotient);
        }
        else
        {
            Console.WriteLine("Error: Division by zero is not allowed.");
        }
    }
}