using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsExample
{
    class Data
    {
        public void Show()
        {
            Console.WriteLine("Show Method From Class Data..");
        }

        public static void Display()
        {
            Console.WriteLine("Diplay Method From Class Data...");
        }
    }
    internal class StaticMethodEx1
    {

        static void Main()
        {
            Data.Display();
            new Data().Show();
        }
    }
}
