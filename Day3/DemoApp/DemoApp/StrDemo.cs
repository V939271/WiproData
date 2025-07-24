using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp
{
    internal class StrDemo
    {
        static void Main()
        {
            string name1 = "Venkat", name2 = "Kasi", name3 = "hari", name4 = "siva";
            Console.WriteLine(name1.GetHashCode());
            Console.WriteLine(name2.GetHashCode());
            Console.WriteLine(name3.GetHashCode());
            Console.WriteLine(name4.GetHashCode());


        }
    }
}
