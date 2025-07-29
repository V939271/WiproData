using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject1
{
    public class EmployDao
    {
        static List<Employ> employList;

        static EmployDao()
        {
            employList = new List<Employ>()
            {
                new Employ{Empno=1,Name="Bash", Basic=31241},
                new Employ{ Empno=2,Name="Venkat",Basic=41241},
                new Employ{ Empno = 3, Name = "Sunil", Basic = 425452}
            };
        }
        public List<Employ> ShowEmploy()
        {
            return employList;
        }
        public Employ SearchEmploy(int empno)
        {
            Employ employFound = null;
            foreach (Employ employ in employList)
            {
                if (employ.Empno == empno)
                {
                    employFound = employ;
                }
            }
            return employFound;
        }

    }
}
