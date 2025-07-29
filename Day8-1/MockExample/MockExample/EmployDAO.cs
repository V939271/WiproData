using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockExample
{
    public class EmployDAO : IEmployDAO
    {
        static List<Employ> employList;

        static EmployDAO()
        {
            employList = new List<Employ>()
            {
                new Employ{Empno=1,Name="Akhil",Basic=88323},
                new Employ{Empno=2,Name="Yash",Basic=91911},
                new Employ{Empno=3,Name="Manali",Basic=86444},
                new Employ{Empno=4,Name="Tamanna",Basic=89942},
                new Employ{Empno=5,Name="Anubhav",Basic=88932},
                new Employ{Empno=6,Name="Prathyusha",Basic=81323},
            };
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

        public List<Employ> ShowEmploy()
        {
            return employList;
        }
    
    }
}
