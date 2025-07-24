using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp
{
    internal class Quiz1
    {
        int n;

        static void Main()
        {
            int x = 12;
            Quiz1 obj1 = new Quiz1();
            obj1.n = 12;
            Quiz1 obj2 = obj1;
            obj2.n = 13;
            Console.WriteLine(obj1.n);
            Console.WriteLine(obj1.GetHashCode());
            Console.WriteLine(obj2.GetHashCode());
        }
    }
}