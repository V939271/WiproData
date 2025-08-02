using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Examples
{
    public class ThreadExample1
    {
        public static void OddShow()
        {
            for(int i=1; i <= 20; i += 2)
            {
                Console.WriteLine("Odd  "+i);
                Thread.Sleep(1000);

            }
        }
        public static void EvenShow()
        {
            for(int i = 0; i <= 20; i++)
            {
                Console.WriteLine("Even  "+i);
                Thread.Sleep(1000);
            }
        }
        public static void Fact()
        {
            int f = 1;
            for (int i = 1; i <= 8; i++)
            {
                f = f * i;
                Console.WriteLine("Factorial Value  " + f);
                Thread.Sleep(1000);

            }
        }

        static void Main()
        {
            ThreadStart t1 = new ThreadStart(EvenShow);
            ThreadStart t2 = new ThreadStart(OddShow);
            ThreadStart t3 = new ThreadStart(Fact);

            Thread t11 = new Thread(t1);
            Thread t22 = new Thread(t2);
            Thread t33 = new Thread(t3);

            t11.Start();
            t22.Start();
            t22.Join();
            t33.Start();


        }

    }
}
