using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample1
{
    internal class Kasi : ITraining
    {
        public void Email()
        {
            Console.WriteLine("Email id is Kasi@92");
        }

        public void Name()
        {
            Console.WriteLine("Name is Kasi..");
        }
    }
}
