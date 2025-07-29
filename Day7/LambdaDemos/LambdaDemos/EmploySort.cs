using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaDemos
{
    internal class EmploySort
    {
        static void Main()
        {
            List<Employ> employList = new List<Employ>
            {

                new Employ{ Empno = 12, Name="Venkat",Basic=88866},
                new Employ { Empno = 12, Name = "Rajesh", Basic = 88323 },
                new Employ { Empno = 33, Name = "Uday", Basic = 80022 },
                new Employ { Empno = 14, Name = "Pallavi", Basic = 90321 },
                new Employ { Empno = 25, Name = "Pralavi", Basic = 78822 },
                new Employ { Empno = 6, Name = "Anusha", Basic = 78823 },
            };

            employList.Sort();
            Console.WriteLine("Sorted Data (default w.r.t Empno) ");
            var result1 = employList.Select(x => x);
            foreach(var v in result1)
            {
                Console.WriteLine(v);
            }

            Console.WriteLine("Sort by Name-Wise  ");
            employList.Sort(new NameCompare());
            var result2 = employList.Select(x => x);
            foreach (var v in result2)
            {
                Console.WriteLine(v);
            }

            Console.WriteLine("Sort by basic-wise ");
            employList.Sort(new BasicComparer());
            foreach(var v in employList)
            {
                Console.WriteLine(v);
            }

        }
    }
}
