using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OcpWith
{
    internal class DotnetTraining : ITraining
    {
        public void Info()
        {
            Console.WriteLine("Dotnet FSD Training Info...");
        }

        public void Timing()
        {
            Console.WriteLine("Its from Morning 9 to 6");
        }
    }
}
