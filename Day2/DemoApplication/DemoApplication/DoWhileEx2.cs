using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApplication
{
    internal class DoWhileEx2
    {
        static void Main()
        {
            int count = 10;

            do
            {
                Console.WriteLine("Hello! This will print at least once.");
            } while (count < 5);
        }
    }
}
