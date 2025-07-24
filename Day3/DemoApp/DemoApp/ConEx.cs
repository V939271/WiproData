using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp
{
    internal class ConEx
    {
        //CLR sees ConEx used → calls static constructor once.
        static ConEx() //Runs before any instance is created with cls also it will provide the output once
        {
            Console.WriteLine("Static Constructor....");
        }

        ConEx() 
        {
            Console.WriteLine("Instance Constructor...");
        }

        static void Main()
        {
            ConEx obj = new ConEx(); //Called each time you create a new object using new.
            ConEx obj1 = new ConEx();

        }
    }
}
