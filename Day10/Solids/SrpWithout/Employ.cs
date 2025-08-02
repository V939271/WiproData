using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SrpWithout
{
    public class Employ
    {
        public int Empno { get; set; }
        public string Name { get; set; }
        public double Basic { get; set; }

        public override string ToString()
        {
            return "Employ No " + Empno + " Employ Name " + Name + " Basic " + Basic;
        }

        static List<Employ> employList;

        static Employ()
        {
            employList = new List<Employ>();
        }

        public List<Employ> ShowEmploy()
        {
            return employList;
        }

        public string AddEmploy(Employ employ)
        {
            employList.Add(employ);
            return "Emplo Record Inserted...";
        }
    }
}
