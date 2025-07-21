using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Calculation
    {
        static void Main()
        {
            int a, b;
            Console.WriteLine("Enter First Value ");
            a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Value ");
            b=Convert.ToInt32(Console.ReadLine());
            
            int add = a + b;
            int sub = a - b;
            int mul = a * b;
            Console.WriteLine("Addition "+add);
            Console.WriteLine("Substraction "+sub);
            Console.WriteLine("Multiplaction "+mul);

        }
    }
}
