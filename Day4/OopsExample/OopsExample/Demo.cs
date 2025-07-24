using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsExample
{
    internal class Demo

    {
        static int count;
        public void Increment() 
        { 
            count++;
        }

        public void Show() 
        {
            Console.WriteLine("Count  "+count);
        }
        static void Main(string[] args)
        {
            Demo demo = new Demo();
            Demo demo1 = new Demo();
            demo1.Increment();
            demo1.Show();
            demo.Show();
          

        }
    }
}
