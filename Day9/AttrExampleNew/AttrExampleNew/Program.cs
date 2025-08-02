using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AttrExampleNew
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Type obj = typeof(Student);
            Assembly exex = Assembly.GetExecutingAssembly();
            Type[] types = exex.GetTypes();
            foreach (var v in types)
            {
                foreach (var a in v.GetCustomAttributes())
                {
                    Console.WriteLine(a.TypeId);
                }
            }
        }
    }
}
