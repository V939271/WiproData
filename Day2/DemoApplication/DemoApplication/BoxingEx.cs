using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApplication
{
    internal class BoxingEx
    {
        static void Main()
        {
            int x = 12;
            string str = "Wipro";
            double y = 12.5;

            /* Implement Boxing */
            object obj1 = x;
            object obj2 = y;
            object obj3 = str;

            /* Implement Unboxing */

            int x1 = (Int32)obj1;
            string str1 = (string)obj3;
            double y1 = (double)obj2;

            Console.WriteLine(x1);
            Console.WriteLine(str1);
            Console.WriteLine(y1);

        }
    }
}
