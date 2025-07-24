using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionExample1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculation calculation = new Calculation();
            Console.WriteLine(calculation.Sub(10,20));
            Console.WriteLine(calculation.Sum(10,29));
            Console.WriteLine(calculation.Mul(10,20));
        }
    }
}
