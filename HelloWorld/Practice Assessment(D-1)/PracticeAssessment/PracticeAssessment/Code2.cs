using System;

class Program
{
    static void Main(string[] args)
    {
        // Prompt the user to enter the first number
        Console.WriteLine("Enter the first number:");
        string a = Console.ReadLine();
        int num1 = Convert.ToInt32(a);

        // Complete Step 1:............

        // Prompt the user to enter the second number
        Console.WriteLine("Enter the second number:");
        string b = Console.ReadLine();
        int num2 = Convert.ToInt32(b);
        // Complete Step 2:............

        // Add the two numbers
        // Complete Step 3:............
        int sum = num1 + num2;

        // Print the sum
        // Complete Step 4:............
        Console.WriteLine("The sum is: " + sum);
    }
}