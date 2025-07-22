using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApplication
{
    internal class Max3
    {
        public void Show(int a, int b, int c)
        {
            int m = a;
            if (a < b)
            {
                a = b;
            }
            if (m < c)
            {
                m = c;
            }
            Console.WriteLine("Max value "+m);
        }
        static void Main()
        {
            int a, b, c;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            Max3 obj = new Max3();
            obj.Show(a, b, c);
        }
    }
}
