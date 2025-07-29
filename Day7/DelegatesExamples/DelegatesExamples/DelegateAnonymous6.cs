using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesExamples
{
    internal class DelegateAnonymous6
    {
        public delegate void AnouDelegate(string str);
        static void Main()
        {
            AnouDelegate obj = delegate(string str)
            {
                Console.WriteLine("This is Anonymous Method  "+str);

            };

            obj("Prasanna Sir");
        }
    }
}
