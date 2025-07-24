using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtensionLibrar;

namespace ExtensionExample2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Operations obj1 = new Operations();
            Console.WriteLine(obj1.MileStone1());
            Console.WriteLine(obj1.MileStone2());
            Console.WriteLine(obj1.MileStone4());
            Console.WriteLine(obj1.Poject());
        }
    }
}
