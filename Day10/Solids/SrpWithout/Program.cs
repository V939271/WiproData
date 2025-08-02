using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SrpWithout
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employ e1 = new Employ();
            e1.Empno = 1;
            e1.Name = "Raj";
            e1.Basic = 88333;
            e1.AddEmploy(e1);
            List<Employ> employList = e1.ShowEmploy();
            foreach (var v in employList)
            {
                Console.WriteLine(v);
            }
        }
    }
}
