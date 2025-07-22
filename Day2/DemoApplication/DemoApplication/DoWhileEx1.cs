using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApplication
{
    internal class DoWhileEx1
    {
        static void Main()
        {
            int i = 1;
            do
            {
                Console.WriteLine(i);
                i++;
            } while (i <= 5);
        }
    }
}
