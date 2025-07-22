using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApplication
{
    internal class ArrayCopy
    {
        public void show()
        {
            int[] a = new int[] { 1, 2, 3, 45 };
            int[] b = a;
            for (int i = 0; i < b.Length; i++)
            {
                Console.WriteLine(b[i]);
            }
        }
        static void Main()
        {
            ArrayCopy obj = new ArrayCopy();
            obj.show();

        }
    }
}
