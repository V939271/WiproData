using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoFirstLibrary
{
    internal class Test
    {
        public void Display()
        {
            Demo demo = new Demo();
            Console.WriteLine(demo.publicStr);
            Console.WriteLine(demo.internalStr);
            Console.WriteLine(demo.ipStr);
        }
        //static void Main()
        //{
        //    new Test().Display();
        //    new Data().Hello();
        //}
        // to checking perpose

    }
}