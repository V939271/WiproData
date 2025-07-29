using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionExamples
{
    internal class ReflectionExample2
    {
        static void Main()
        {
            Type t = typeof(string);
            Console.WriteLine("Name "+t.Name);
            Console.WriteLine("Full Name  "+t.FullName);
            Console.WriteLine("NameSpace "+t.Namespace);
            Console.WriteLine("Base Type "+t.BaseType);
        }
    }
}
