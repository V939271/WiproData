using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples
{
    internal class NullableEx1
    {
        static void Main()
        {
            Employ employ1 = new Employ();
            employ1.Empno = 1;
            employ1.Name = "Venkat";
            employ1.Basic = 43423;

            Employ employ2 = new Employ();
            employ2.Empno = 2;
            employ2.Name = "Kasi";
            employ2.Basic = 9999;
            employ2.LeaveDays = 3;

            if (employ1.LeaveDays.HasValue)
            {
                Console.WriteLine("{0} taken leave ",employ1.Name);
                employ1.Status = 1;
            }
            else
            {
                Console.WriteLine("{0} taken leave ", employ1.Name);
                employ1.Status = 0;
            }
            if (employ2.LeaveDays.HasValue)
            {
                Console.WriteLine("{0} taken leave ", employ2.Name);
                employ2.Status = 0;
            }
            else
            {
                Console.WriteLine("{0} not Taken leave "+ employ2.Name);
                employ2.Status = 1;
            }



        }
    }
}
