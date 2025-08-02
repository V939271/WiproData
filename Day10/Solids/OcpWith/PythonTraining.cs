using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OcpWith
{
    internal class PythonTraining : ITraining
    {
        public void Info()
        {
            Console.WriteLine("Python Training is Going On...");
        }

        public void Timing()
        {
            Console.WriteLine("Timing is from 9 to 9");
        }
    }
}
