using Microsoft.JScript;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject1
{
    public class Employ
    {
        public int Empno { get; set; }
        public string Name { get; set; }
        public double Basic {  get; set; }


        public Employ() { }
        public Employ(int empno, string name, double basic)
        {
            Empno = empno;
            Name = name;
            Basic = basic;
        }

        public override string ToString()
        {
            return "Empno " + Empno + " Name " + Name + " Basic " + Basic;
        }
      
    }
}
