using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples
{
    internal class IndexerEx2
    {
        Emp[] arr = new Emp[5];
        public Emp this[int id]
        {
            get { return arr[id]; }
            set { arr[id] = value; }
        }

        static void Main()
        {
            IndexerEx2 obj = new IndexerEx2();
            obj[0] = new Emp { Empno = 1, Name = "Venkat", Basic = 8888 };
            obj[1] = new Emp { Empno = 2, Name = "Sunil", Basic = 7777 };
            obj[2] = new Emp { Empno = 3, Name = "Kasi", Basic = 6666 };
            obj[3] = new Emp { Empno = 4, Name = "Bash", Basic = 9999 };

            foreach (var v in obj.arr)
            {
                Console.WriteLine(v);
            }
        }
    }
}
