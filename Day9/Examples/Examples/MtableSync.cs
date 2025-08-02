using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Examples
{
    class MTable
    {
        public void Table(int n)
        {
            lock (this)
            {
                int p;
                for (int i = 1; i <= 10; i++)
                {
                    p = n * i;
                    Console.WriteLine(n + " * " + i + " = " + p);
                    Thread.Sleep(1000);
                }

            }
        }
    }
    internal class MtableSync
    {
        MTable mTable;
        MtableSync(MTable mTable)
        {
            this.mTable = mTable;
        }

        public void Tab1()
        {
            mTable.Table(5);
        }

        public void Tab2()
        {
            mTable.Table(9);
        }
        public void Tab3()
        {
            mTable.Table(11);
        }

        static void Main()
        {
            MtableSync obj = new MtableSync(new MTable());
            ThreadStart th1 = new ThreadStart(obj.Tab1);
            ThreadStart th2 = new ThreadStart(obj.Tab2);
            ThreadStart th3 = new ThreadStart(obj.Tab3);

            Thread t1 = new Thread(th1);
            Thread t2 = new Thread(th2);
            Thread t3 = new Thread(th3);

            t1.Start();
            t2.Start();
            t3.Start();
        }
    }
}
