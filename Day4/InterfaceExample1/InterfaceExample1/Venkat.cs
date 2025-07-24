using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample1
{
    internal class Venkat : ITraining
    {
        public void Email()
        {
            Console.WriteLine("Email is venkat@92");
        }

        public void Name()
        {
            Console.WriteLine("Hi Name is Venkat..");
        }
    }
}
