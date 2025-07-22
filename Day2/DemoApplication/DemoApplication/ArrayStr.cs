using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApplication
{
    internal class ArrayStr
    {
        public void show()
        {
            string[] anmes = new string[] { "Venkat", "Dilip", "Kasi" };
            foreach (string name in anmes)
            {
                Console.WriteLine(name);
            }

        }

        static void Main()
            {
                ArrayStr obj = new ArrayStr();
                obj.show();
            }
    }
}
