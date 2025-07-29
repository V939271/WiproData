using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace CollectionsExample
{
    internal class StackExample
    {
        static void Main()
        {

            // Pushing items into the stack
            Stack stack = new Stack();
            stack.Push("Venkat");
            stack.Push("Kasi");
            stack.Push("Siva");
            Console.WriteLine("Stack Data....");

            foreach (object o in stack)
            {
                Console.WriteLine(o);
            }
            stack.Pop();
            Console.WriteLine("Poping one Element ");
            foreach(object o in stack)
            {
                Console.WriteLine(o);
            }
        }
    }
}
