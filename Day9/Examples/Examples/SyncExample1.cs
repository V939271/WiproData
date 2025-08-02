using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Examples
{
    class Data
    {
        public void Show(String name)
        {
            lock (this)
            {
                Console.WriteLine("Hello  " + name);
                Thread.Sleep(1000);
                Console.WriteLine(" How are you...");
            }
        }
    }
    public class SyncExample1
    {
        Data data;
        SyncExample1(Data data)
        {
            this.data = data;
        }

        public void Venkat()
        {
            data.Show("Venkat");
        }

        public void Sunil()
        {
            data.Show("Sunil");
        }

        static void Main()
        {
            SyncExample1 obj = new SyncExample1(new Data());
            ThreadStart th1 = new ThreadStart(obj.Venkat);
            ThreadStart th2 = new ThreadStart(obj.Sunil);
            Thread t1 = new Thread(th1);
            Thread t2 = new Thread(th2);

            t1.Start();
            t2.Start();
        }
    }
}
