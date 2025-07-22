using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApplication
{
    internal class Fact
    {
        public void show(int n)
        {
            int i = 1, f = 1;
            for (i = 1; i <= n; i++)
            {
                f = f * i;
            }
            Console.WriteLine(f);
        }
        static void Main()
        {
            Console.WriteLine("Enter a Num..");
            int n;
            n = Convert.ToInt32(Console.ReadLine());
            Fact obj = new Fact();
            obj.show(n);

        }
    }
}
