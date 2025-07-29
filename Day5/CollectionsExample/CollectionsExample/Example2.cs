using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;

namespace CollectionsExample
{
    internal class Example2
    {
        static void Main()
        {
            Employ employ1 = new Employ();
            employ1.Empno = 1;
            employ1.Name = "Rajesh";
            employ1.Basic = 88233.11;

            Employ employ2 = new Employ();
            employ2.Empno = 2;
            employ2.Name = "Sunil";
            employ2.Basic = 98822.11;

            Employ employ3 = new Employ();
            employ3.Empno = 3;
            employ3.Name = "Yamini";
            employ3.Basic = 89911.11;

            ArrayList arrayList = new ArrayList();
            arrayList.Add(employ1);
            arrayList.Add(employ2);
            arrayList.Add(employ3);
            //arrayList.Add(12);

            foreach (object obj in arrayList)
            {
                Employ employ = (Employ)obj;
                Console.WriteLine(employ);
            }
        }
    }
}