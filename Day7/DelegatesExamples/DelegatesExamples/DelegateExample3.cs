using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesExamples
{
    internal class DelegateExample3
    {
        public delegate void Delegate(int obj);

        public static void Fact(int n)
        {
            int f = 1;
            for (int i = 1; i <= n; i++)
            {
                f = f * i;
            }
            Console.WriteLine("Factorial Value " +f);
        }

        public static void PosNeg(int n)
        {
            if (n >= 0)
            {
                Console.WriteLine("Positive Number...");
            }
            else
            {
                Console.WriteLine("Negative Number..");
            }
        }

        public static void EvenOdd(int n)
        {
            if (n % 2 == 0)
            {
                Console.WriteLine("Even Numvers..");
            }
            else
            {
                Console.WriteLine("Odd Numbers...");
            }
        }

        static void Main()
        {
            int n;
            Console.WriteLine("Enter N value...");
            n = Convert.ToInt32(Console.ReadLine());
            Delegate obj = new Delegate(PosNeg);
            obj += new Delegate(Fact);
            obj += new Delegate(EvenOdd);
            obj(n);
        }
    }
}
