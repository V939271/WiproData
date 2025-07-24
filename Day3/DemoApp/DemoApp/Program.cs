using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] a = new int[2, 3]
            {
                {1,2,3},
                {5,6,7}
            };
            Console.WriteLine("-----------------");
            Console.WriteLine(a[0,0]);
            Console.WriteLine(a[0,1]);
            Console.WriteLine(a[0,2]);
            Console.WriteLine(a[1,0]);
            Console.WriteLine(a[1,1]);
            Console.WriteLine(a[1,2]);



        }
    }
}
