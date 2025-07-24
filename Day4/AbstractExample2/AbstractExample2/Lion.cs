using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractExample2
{
    internal class Lion : Animal
    {
        public override void Name()
        {
            Console.WriteLine("Name is Lion...");
        }

        public override void Type()
        {
            Console.WriteLine("Its Wild Animla....");
        }
       
    }
}
