using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesExamples
{
    internal class ActionDelegate8
    {
        public static void Greeting(string s)
        {
            Console.WriteLine("Good Moring "+s);
        }

        public static void EndNote(string s)
        {
            Console.WriteLine("Good Nyt "+s);
        }

        static void Main()
        {
            string s;
            Console.WriteLine("Enter Name ..");
            s = Console.ReadLine();
            Action<string> obj = Greeting;
            obj += EndNote;
            obj(s);
        }
    }
}
