using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectMethods
{
    internal class Employ
    {
        int empno;
        string name;
        double basic;

        public Employ() 
        {

        }
        //Because by default, ToString() prints the class name--
        //---(namespace + type name), not the object's data.
        public override string ToString()
        {
            return "Employ No " + empno + " Name " + name + " Basic " + basic;
        }

        public Employ(int empno, string name,double basic)
        {
            this.empno = empno;
            this.name = name;
            this.basic = basic;
        }
    }
}
