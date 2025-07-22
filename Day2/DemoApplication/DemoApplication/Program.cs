using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/// <summary>
/// Program to perform Calculation of 2 Numbers
/// </summary>

namespace DemoApplication
{
    internal class Calculation
    {
        public int sum(int a, int b)
        {
            return a + b;
        }

        public int sub(int a, int b)
        {
            return a - b;
        }
        public int mul(int a,int b)
        {
            return a * b;
        }
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Enter 2 Numbers :");
            a= Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            Calculation calc = new Calculation();

            int result = calc.sum(a,b);
            Console.WriteLine("Sum is "+result);

            result = calc.sub(a, b);
            Console.WriteLine("Sub is " + result);

            result = calc.mul(a, b);
            Console.WriteLine("Sum is " + result);



        }
    }
}
