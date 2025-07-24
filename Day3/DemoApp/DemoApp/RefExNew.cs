using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp
{
    internal class RefExNew
    {
        public void Calc(int n, ref int f)
        {
            for (int i = 1; i <= n; i++)
            {
                f = f * i;
            }
        }

        static void Main()
        {
            int n, f = 1;
            Console.WriteLine("Enter N Value...");
            n = Convert.ToInt32(Console.ReadLine());
            RefExNew obj = new RefExNew();
            obj.Calc(n, ref f);
            Console.WriteLine("Factorial Value.." +f);
        }
    }
}
