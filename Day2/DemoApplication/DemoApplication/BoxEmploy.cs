using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApplication
{
    internal class BoxEmploy
    {
        public void Show(object obj)
        {
            string type = obj.GetType().Name;
            if (type.Equals("Employ"))
            {
                Employ employ = (Employ)obj;
                Console.WriteLine("Employee No "+employ.empno+ "Name " +employ.name+ "Basic "+employ.basic);
            }
        }
        static void Main()
        {
            Employ employ = new Employ();
            employ.empno = 1;
            employ.name = "Test";
            employ.basic = 2992.9;

            BoxEmploy obj = new BoxEmploy();
            obj.Show(employ);

        }
    }
}
