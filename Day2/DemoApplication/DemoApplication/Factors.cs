using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApplication
{
    internal class Factors
    {
        public void show(int n)
        {
            int i = 1;
            while (i <= n)
            {
                if (n % i == 0)
                {
                    Console.WriteLine("Factories of n is "+i);
                }
                i++;
            }
        }
        static void Main()
        {
            int n;
            Console.WriteLine("Enter a Num..");
            n = Convert.ToInt32(Console.ReadLine());
            Factors obj = new Factors();
            obj.show(n);
        }
    }
}
