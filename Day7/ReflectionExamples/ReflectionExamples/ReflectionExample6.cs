using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionExamples
{
    internal class ReflectionExample6
    {
        static void Main()
        {
            Type objstudent = typeof(Student);
            Console.WriteLine("Methods available are..");
            foreach(MethodInfo m in objstudent.GetMethods())
            {
                Console.WriteLine(m.Name);
            }
            Console.WriteLine("Fields available are ");
            foreach(FieldInfo f in objstudent.GetFields())
            {
                Console.WriteLine(f.Name);
            }
        }
    }
}
