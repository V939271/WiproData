using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractExample1
{
    internal class Charan : Training
    {
        public override string Age()
        {
            return "Age is..." + 23;
        }

        public override void Name()
        {
            Console.WriteLine("Hi i am Charan...");
        }
    }
}
