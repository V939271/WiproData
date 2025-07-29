using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesExample
{
    internal class Employ
    {
        public int Emmno { get; set; }
        public string Empname { get; set; }
        public double Basic { get; set; }

    }
    internal class AutoImplement
    {
        static void Main()
        {
            Employ employ1 = new Employ();
            employ1.Emmno = 1;
            employ1.Basic = 2232.242;
            employ1.Empname = "Venkat";

            Employ employ2 = new Employ();
            employ1.Emmno = 2;
            employ1.Basic = 2232.265;
            employ1.Empname = "Kasi";

            Employ employ3 = new Employ();
            employ3.Emmno = 3;
            employ3.Empname = "Vasim";
            employ3.Basic = 88124.23;

            Console.WriteLine("First Employee Record(s)  ");
            Console.WriteLine("Employ No  " + employ1.Emmno + " Employ Name " + employ1.Empname + " Employ Basic  " + employ1.Basic);
            Console.WriteLine("Employ No  " + employ2.Emmno + " Employ Name " + employ2.Empname + " Employ Basic  " + employ2.Basic);
            Console.WriteLine("Employ No  " + employ3.Emmno + " Employ Name " + employ3.Empname + " Employ Basic  " + employ3.Basic);
        }
    }
}
