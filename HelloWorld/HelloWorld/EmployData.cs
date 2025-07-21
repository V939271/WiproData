using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class EmployData
    {
        static void Main()
        {
            Employ emp1 = new Employ();
            emp1.Empno = 1;
            emp1.Name = "Venkat";
            emp1.basic = 88893;

            Employ emp2 = new Employ();
            emp2.Empno = 2;
            emp2.Name = "Kasi";
            emp2.basic = 532543;

            Console.WriteLine("First Employ Data ..");
            Console.WriteLine("Employ Num " +emp1.Empno);
            Console.WriteLine("Emp Name " +emp1.Name);
            Console.WriteLine("Emp Basic "+emp1.basic);

            Console.WriteLine("Second Employee Data...");
            Console.WriteLine("Emp Num "+emp2.Empno);
            Console.WriteLine("Emp Name "+emp2.Name);
            Console.WriteLine("Emp basic "+emp2.basic);



        }
    }
}
