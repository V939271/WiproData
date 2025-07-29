using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionExamples
{
    internal class ReflectionExample4
    {
        [Obsolete("Deprecated Method",false)]
        public static void TestMethod()
        {
            Console.WriteLine("Demo Method..");
        }

        static void Main()
        {
            TestMethod();  // ⚠️ Will show a warning at compile-time
        }
    }
}
