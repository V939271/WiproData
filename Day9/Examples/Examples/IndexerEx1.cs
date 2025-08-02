using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples
{
    public class Demo
    {
        public string[] names = new string[5];
        public string this[int i]
        {
            get { return names[i]; }
            set { names[i] = value; }
        }
    }
    public class IndexerEx1
    {
        static void Main()
        {
            Demo demo = new Demo();
            demo[0] = "Venkat";
            demo[1] = "Sunil";
            demo[2] = "Kasi";
            demo[3] = "Bash";
            demo[4] = "Ramesh";
            Console.WriteLine("Data is ");
            foreach (var v in demo.names) Console.WriteLine(v);
        }
    }
}
