using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithSrp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employ e1 = new Employ();
            e1.Empno = 1;
            e1.Name = "Venkat";
            e1.Basic = 88114;

            EmployDao employDao = new EmployDaoImpl();
            employDao.AddEmployDao(e1);
            List<Employ> employList = employDao.GetAllEmploys();
            foreach (var v in employList)
            {
                Console.WriteLine(v);
            }
        }
    }
}
