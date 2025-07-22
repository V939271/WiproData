using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApplication
{
    internal class ArrayExample
    {
        public void show()
        {
            int[] a= new int[] { 12,13,14,15};

            foreach(int i in a)
            {
                Console.WriteLine(i);
            }

        }
        static void Main()
        {
            ArrayExample obj =  new ArrayExample();
            obj.show();
        }
    }
}
