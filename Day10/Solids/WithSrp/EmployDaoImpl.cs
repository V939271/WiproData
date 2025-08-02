using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithSrp
{
    internal class EmployDaoImpl : EmployDao
    {
        static List<Employ> employList;
        static EmployDaoImpl()
        {
            employList = new List<Employ>();
        }
        public string AddEmployDao(Employ employ)
        {
            employList.Add(employ);
            return "Employ Record Inserted...";
        }

        public List<Employ> GetAllEmploys()
        {
            return employList;
        }
    }
}
