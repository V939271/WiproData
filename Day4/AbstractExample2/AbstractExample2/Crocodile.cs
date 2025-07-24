using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractExample2
{
    internal class Crocodile : Animal
    {
        public override void Type()
        {
            Console.WriteLine("Name is Crocodile...");
        }

        public override void Name()
        {
            Console.WriteLine("Its water Animal..");
        }
        
    }
}
