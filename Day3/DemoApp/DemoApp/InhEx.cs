using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp
{
    class First
    {
        public void Show()
        {
            Console.WriteLine("Show Method for Class First....");
        }
    }

    class Second : First 
    {
        public void Display()
        {
            Console.WriteLine("Display Method form Class Secnd..");
        }
    }
    internal class InhEx
    {
        static void Main(string[] args) 
        {
            Second obj = new Second();
            obj.Show();
            obj.Display();
        }

    }
}
