using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp
{
    internal class OverloadEx1
    {
        public void show(int x)
        {
            Console.WriteLine("Show Method w.r.t int "+x);
        }
        public void show(double x)
        {
            Console.WriteLine("Show Method w.r.t double  "+x);
        }

        public void show(string x) 
        {
            Console.WriteLine("Show Methods w.r.t String  "+x);
        }

        static void Main()
        {
            OverloadEx1 obj = new OverloadEx1();
            obj.show(12);
            obj.show("Venkat");
            obj.show(23.55);

        }
    }
}
