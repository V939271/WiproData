using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesExamples
{
    internal class ActionDelegate7
    {
        public delegate void Delegate(string str);
        public static void Greeting(string s)
        {
            Console.WriteLine("Good Morning " + s);
        }

        static void Main()
        {
            Delegate obj = Greeting;
            obj("Venkat");

        }
    }
}
