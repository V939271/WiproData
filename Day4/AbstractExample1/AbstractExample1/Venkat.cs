using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractExample1
{
    internal class Venkat : Training
    {
        public override string Age()
        {
            return "Age is " + 22;
        }

        public override void Name()
        {
            Console.WriteLine("Hi My Name is Venkat...");
        }
    }
}
