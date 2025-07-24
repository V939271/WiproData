using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoFirstLibrary;

namespace DemoSecondLibrary
{
    internal class Third : Demo
    {
        public void Test()
        {
            Third third = new Third();
            Console.WriteLine(third.publicStr);
            Console.WriteLine(third.protectedStr);
            Console.WriteLine(third.ipStr);
        }
    }
}