using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionExamples
{
    internal class ReflectionExample1
    {
        static void Main()
        {
            Type typeobj = typeof(Test);
            Console.WriteLine("Methods Avaialble in Test class are");
            foreach (MethodInfo mi in typeobj.GetMethods())
            {
                Console.WriteLine(mi.Name);
            }
            Console.WriteLine("Variables available in the Test class are");
            foreach (FieldInfo fi in typeobj.GetFields())
            {
                Console.WriteLine(fi.Name);
            }

        }
    }
}
