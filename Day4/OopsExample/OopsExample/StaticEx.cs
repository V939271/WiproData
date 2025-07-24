using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsExample
{
    internal class StaticEx
    {
        static int count;
        public void Increment()
        {
            count++;
        }

        public void Show()
        {
            Console.WriteLine("Count..."+count);
        }

        static void Main()
        {
            StaticEx obj1 = new StaticEx();
            StaticEx obj2 = new StaticEx();
            StaticEx Obj3 = new StaticEx();

            obj1.Increment();
            obj2.Increment();
            Obj3.Increment();
            obj1.Show();
        }

    }

   

}
