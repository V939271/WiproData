using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClalculationLibrary;

namespace CalculationClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculation calculation = new Calculation();
            Console.WriteLine("Enter 2 Numbers...");
            int a, b;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sum is " +calculation.Sum(a, b));
            Console.WriteLine("Sub is "+calculation.Sub(a, b));
            Console.WriteLine("Mul is "+calculation.Mul(a, b));
        }
    }
}
