using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp
{
    class C1
    {
        public C1()
        {
            Console.WriteLine("Base Class Constructor..");
        }

    }
    class C2 : C1 
    {
        public C2() 
        {
            Console.WriteLine("Derived Class Constructor..");
        
        }
    }
    internal class Inhc
    {
        static void Main() 
        {
            C1 C2 = new C2(); // A base class reference can hold a derived class object.
                              // First, the constructor of the base class (C1) is called.
                              // Then, the constructor of the derived class (C2) is called.
        }
    }
}
