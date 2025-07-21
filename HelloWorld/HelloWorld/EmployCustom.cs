using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class EmployCustom
    {
        static void Main()
        {
            Employ emp1 = new Employ();
            Employ emp2 = new Employ();
            Console.WriteLine("Enter First Emply Data..");
            emp1.Empno = Convert.ToInt32(Console.ReadLine());
            emp1.Name = Convert.ToString(Console.ReadLine());
            emp1.basic = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Enter Second  Employee Data..");
            emp2.Empno = Convert.ToInt32(Console.ReadLine());
            emp2.Name = Convert.ToString(Console.ReadLine());
            emp2.basic = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("First Emp Data..");
            Console.WriteLine("Emp NO " + emp1.Empno);
            Console.WriteLine("Emp Name "+emp1.Name);
            Console.WriteLine("Emp Basic "+emp1.basic);

            Console.WriteLine("Second Emp Data..");
            Console.WriteLine("Emp No "+emp2.Empno);
            Console.WriteLine("Emp Name "+emp2.Name);
            Console.WriteLine("Emp Basic "+emp2.basic);


        }
    }
}
