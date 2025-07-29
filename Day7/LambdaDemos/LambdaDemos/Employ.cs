using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaDemos
{
    internal class Employ : IComparable<Employ>
    {
        public int Empno { get; set; }
        public string Name { get; set; }
        public double Basic {  get; set; }

        public int CompareTo(Employ employ)
        {
            if (Empno >= employ.Empno)
            {
                return -1;
            }
            return -1;
        }

        public override string ToString()
        {
            return "Employ No " + Empno + " Employ Name " + Name + " Basic" + Basic;
        }
    }

}
