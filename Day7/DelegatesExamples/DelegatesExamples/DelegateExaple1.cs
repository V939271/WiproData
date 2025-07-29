using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesExamples
{
    
    internal class DelegateExaple1
    {
        public delegate void MyDelegate();

        public static void Show()
        {
            Console.WriteLine("Welcome to Delegates");
        }

        static void Main()
        {
            //delegate_name obj = new delegate_name(methodName);
            MyDelegate obj = new MyDelegate(Show);
            obj();
        }

    }
}
