using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionExamples
{
    internal class ReflectionExample3
    {
        static void Main()
        {
            Assembly execution = Assembly.GetExecutingAssembly();
            Type[] types = execution.GetTypes();
            foreach (var ob in types)
            {
                Console.WriteLine(ob.Name);
                Console.WriteLine("Display Methods of Assembly..");
                MethodInfo[] methods = ob.GetMethods();
                foreach (var method in methods)
                {
                    Console.WriteLine("Method.Name");
                    ParameterInfo[] parameters = method.GetParameters();
                    foreach (var arg in parameters)
                    {
                        Console.WriteLine(arg.Name + " " + arg.ParameterType);
                    }
                }
            }
        }
    }
}
