using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApplication
{
    internal class PosNeg
    {
        public void Check(int n)
        {
            if (n >= 0)
            {
                Console.WriteLine("Positive Number...");
            }
            else
            {
                Console.WriteLine("Negative Number...");
            }
        }
        static void Main()
        {
            int n;
            Console.WriteLine("Enter a Number   ");
            n = Convert.ToInt32(Console.ReadLine());
            PosNeg obj = new PosNeg();
            obj.Check(n);
        }
    }
}
