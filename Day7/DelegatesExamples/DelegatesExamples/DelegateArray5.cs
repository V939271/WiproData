using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesExamples
{
    internal class DelegateArray5
    {
        public delegate void Delegate(int n);

        public static void Fact(int n)
        {
            int f = 1;
            for (int i = 1; i <= n; i++)
            {
                f = f * i;
            }

            Console.WriteLine("Factorail value " + f);
        }

        public static void PosNeg(int n)
        {
            if(n >= 0)
            {
                Console.WriteLine("Positive Number..");
            }
            else
            {
                Console.WriteLine("Negative Numbers...");
            }
        }

        public static void EvenOdd(int n)
        {
            if (n % 2 == 0)
            {
                Console.WriteLine("Even Number...");
            }
            else
            {
                Console.WriteLine("Odd Number...");
            }
        }

        static void Main()
        {
            Console.WriteLine("Enter N Value...");
            int n = Convert.ToInt32(Console.ReadLine());

            Delegate[] arr =
                {
                new Delegate(PosNeg),
                new Delegate(Fact),
                new Delegate(EvenOdd)

            };

            foreach(Delegate m in arr)
            {
                m(n);
            }



        }



    }
}
