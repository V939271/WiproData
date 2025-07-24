using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractExample1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Training obj1 = new Rajesh();
            //Training obj2 = new Venkat();
            //Training obj3 = new Mahi();

            //int[] a =new int[] { 1, 2, 3, 4 };


            Training[] arr = new Training[]
            {
                new Sunil(),
                new Venkat(),
                new Charan(),

            };

            foreach (Training t in arr) { t.Age(); t.Name(); }
        }
    }
}
