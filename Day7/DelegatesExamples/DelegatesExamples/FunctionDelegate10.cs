using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesExamples
{
    internal class FunctionDelegate10
    {
        public static int Sum(int x, int y)
        {
            return x + y;
        }

        public static int Sub(int x, int y)
        {
            return x - y;
        }

        public static int Mult(int x, int y)
        {
            return x + y;
        }

        static void Main()
        {
            int a = 5;
            int b = 5;
            Func<int, int, int> obj = Sum;
            Console.WriteLine(obj(a,b));

        }

    }
}
